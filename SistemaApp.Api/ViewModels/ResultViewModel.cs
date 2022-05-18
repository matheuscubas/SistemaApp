namespace SistemaApp.Api.ViewModels
{
    public class ResultViewModel<T>
    {
        public T? Data { get; set; }
        public bool Sucess { get; set; }
        public List<string> Errors { get; set; }
    }
}
