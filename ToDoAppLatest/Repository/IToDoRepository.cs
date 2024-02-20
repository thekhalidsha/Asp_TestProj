using ToDoAppLatest.Data;
using ToDoAppLatest.Models;
using ToDoAppLatest.Models.ViewModel;

namespace ToDoAppLatest.Repository
{
    public interface IToDoRepository
    {
        List<ToDo> GetToDoList();
        ToDo GetTypeById(int id);
        ToDo GetToDoById(int id);
        bool SaveToDo(ToDo obj);
        bool UpdateToDo(ToDo obj);
        List<ToDoVM> GetToDoListForGrid();
    }
}
