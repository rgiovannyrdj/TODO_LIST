using TODOLIST.CORE.Entities;

namespace TODOLIST.CORE.Interfaces.IServices
{
    public interface ITareaService
    {
        Task<List<Tarea>> GetAllTareas();
        Task<bool> RegisterTarea(Tarea tarea);
        Task<bool> UpdateTarea(Tarea tarea);
        Task<bool> DeleteTarea(string Id);
    }
}
