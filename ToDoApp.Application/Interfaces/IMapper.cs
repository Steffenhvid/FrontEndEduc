namespace ToDoApp.Application.Interfaces
{
    public interface IMapper<Tentity, Tdto>
    {
        Tentity FromDTO(Tdto dto);

        Tdto FromEntity(Tentity entity);
    }
}