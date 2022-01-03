using TODOLIST.CORE.Entities;
using TODOLIST.CORE.Interfaces.IRepositories;
using TODOLIST.CORE.Interfaces.IServices;

namespace TODOLIST.CORE.Services
{
    public class TareaService : ITareaService
    {
        private readonly ITareaRepository _tareaRepository;
        public TareaService(ITareaRepository tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }

        public async Task<bool> DeleteTarea(string Id)
        {
            return await _tareaRepository.DeleteTarea(Id);
        }

        public async Task<List<Tarea>> GetAllTareas()
        {
            return await _tareaRepository.GetAllTareas();
        }

        public async Task<bool> RegisterTarea(Tarea tarea)
        {
            tarea.CreateDate = DateTime.Now;
            return await _tareaRepository.RegisterTarea(tarea);
        }

        public async Task<bool> UpdateTarea(Tarea tarea)
        {
            Tarea _tarea = await _tareaRepository.GetTarea(tarea.ID);
            tarea.CreateDate = _tarea.CreateDate;
            tarea.UpdateDate = DateTime.Now;
            return await _tareaRepository.UpdateTarea(tarea);
        }
    }
}
