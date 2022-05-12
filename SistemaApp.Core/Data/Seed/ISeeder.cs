namespace SistemaApp.Core.Data.Seed
{
    public interface ISeeder
    {
        public void SeedData(SistemaAppDbContext context);
    }
}
