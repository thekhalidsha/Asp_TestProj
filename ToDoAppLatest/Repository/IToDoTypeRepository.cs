using ToDoAppLatest.Models;

namespace ToDoAppLatest.Repository
{
    public interface IToDoTypeRepository
    {
        List<ToDoType> GetAllType();
        ToDoType GetTypeById(int id);
    }
}
