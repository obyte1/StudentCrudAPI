namespace StudentCrud.Data
{
    public interface IUnitOfWork
    {
        Task SavechangesAsync();
    }
}
