using MongoDB.Driver;
using TODOLIST.CORE.Entities;
using TODOLIST.CORE.Interfaces.IRepositories;
using TODOLIST.INFRASTRUCTURE.Data;

namespace TODOLIST.INFRASTRUCTURE.Repositories
{
    public class TareaRepository : ITareaRepository
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoCollection<Tarea> _collection;
        public TareaRepository()
        {
            _client = new MongoClient(ConnectionProps.ConnectionString);
            _mongoDatabase = _client.GetDatabase("todo_roberto");
            _collection = _mongoDatabase.GetCollection<Tarea>("tareas");
        }

        public async Task<bool> DeleteTarea(string Id)
        {
            await _collection.DeleteOneAsync(t => t.ID == Id);
            return true;
        }

        public async Task<List<Tarea>> GetAllTareas()
        {
            List<Tarea> tareas = _collection.Find(t => true).ToList();
            return await Task.FromResult(tareas);
        }

        public Task<Tarea> GetTarea(string Id)
        {
            Tarea tarea = _collection.Find(t => t.ID == Id).First();
            return Task.FromResult(tarea);
        }

        public async Task<bool> RegisterTarea(Tarea tarea)
        {
            await _collection.InsertOneAsync(tarea);

            return true;
        }
        public async Task<bool> UpdateTarea(Tarea tarea)
        {
            await _collection.ReplaceOneAsync(d => d.ID == tarea.ID, tarea);
            return true;
        }
    }
}
