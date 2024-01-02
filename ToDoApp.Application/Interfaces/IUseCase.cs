namespace ToDoApp.Application.Interfaces
{
    public interface IUseCase<Tinput, Toutput>
    {
        Task<Toutput> ExecuteAsync(Tinput input);
    }

    public interface IUseCase<Toutput>
    {
        Task<Toutput> ExecuteAsync();
    }
}