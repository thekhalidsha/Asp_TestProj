using ToDoAppLatest.Data;
using ToDoAppLatest.Models;
using ToDoAppLatest.Models.ViewModel;
namespace ToDoAppLatest.Repository
{
    public class ToDoTypeRepository : IToDoTypeRepository
    {

        private readonly ApplicationDbContext _context;
        public ToDoTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<ToDoType> GetAllType()
        {
            return _context.ToDoType.ToList();
        }
        public ToDoType GetTypeById(int id)
        {
            return _context.ToDoType.Where(x => x.ToDoTypeId == id).SingleOrDefault();
        }


    }
}
