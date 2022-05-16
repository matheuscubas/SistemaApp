using System.Data;
using System.Dynamic;
using System.Text;
using Dapper;

namespace SistemaApp.Core.Extensions
{
    public static class QueryExentions
    {
        public static async Task<PaginationResult<T>> GetUsingSqlServerNativePagination<T, TParams>(
            this IDbConnection connection, string query, TParams parameters, int pageSize, int pageNumber,
            bool enableOrdering = false, bool isDistinct = false)
        {
            StringBuilder quantidadItensBuilder = new(";WITH Resultado AS ( ");
            quantidadItensBuilder.Append(query);

            quantidadItensBuilder.Append(enableOrdering ? " OFFSET 0 ROWS " : string.Empty)
                .Append(") SELECT COUNT(*) FROM Resultado");
            int quantidadeItens =
                await connection.QueryFirstOrDefaultAsync<int?>(quantidadItensBuilder.ToString(), parameters) ?? 0;
            quantidadItensBuilder.Length = 0;

            dynamic paginatedParams = new ExpandoObject();
            var dictionary = (IDictionary<string, object>)paginatedParams;
            foreach (var property in parameters.GetType().GetProperties())
            {
                dictionary.Add(property.Name, property.GetValue(parameters));
            }

            paginatedParams.PageNumber = pageNumber;
            paginatedParams.PageSize = pageSize;

            StringBuilder paginatedQueryBuilder = new();
            paginatedQueryBuilder.Append(isDistinct ? "SELECT * FROM ( " : string.Empty).Append(query).Append(isDistinct ? " ) TABELA " : string.Empty);

            paginatedQueryBuilder.Append(enableOrdering ? string.Empty : " ORDER BY (SELECT NULL) ");
            paginatedQueryBuilder.Append(" OFFSET ((@PageNumber - 1) * @PageSize) ROWS FETCH NEXT @PageSize ROWS ONLY ");
            var paginatedResultSet =
                await connection.QueryAsync<T>(paginatedQueryBuilder.ToString(), (object)paginatedParams);
            paginatedQueryBuilder.Length = 0;

            var pageCount = Convert.ToInt32(Math.Ceiling((double)quantidadeItens / pageSize));

            var resultSet = paginatedResultSet.ToList();

            var firstItem = resultSet.IndexOf(resultSet.FirstOrDefault()) >= 0
                ? resultSet.IndexOf(resultSet.FirstOrDefault())
                : 0;

            var lastItem = resultSet.Count != 0 ? resultSet.IndexOf(resultSet[^1]) : 0;

            return new PaginationResult<T>
            {
                Items = resultSet,
                PageCount = pageCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                HasNextPage = pageNumber <= pageCount,
                HasPreviousPage = pageNumber < 0,
                IsFirstPage = pageNumber == 1,
                TotalItemCount = resultSet.Count,
                FirstItemOnPage = firstItem,
                LastItemOnPage = lastItem
            };
        }
    }
}