using TODOLIST.CORE.Entities;

namespace TODOLIST.CORE.Interfaces.IRepositories
{
    public interface ITareaRepository
    {
        Task<List<Tarea>> GetAllTareas();
        Task<Tarea> GetTarea(string Id);
        Task<bool> RegisterTarea(Tarea tarea);
        Task<bool> UpdateTarea(Tarea tarea);
        Task<bool> DeleteTarea(string Id);  
    }
}
