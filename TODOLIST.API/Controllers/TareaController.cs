using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TODOLIST.CORE.Entities;
using TODOLIST.CORE.Interfaces.IServices;
using TODOLIST.CORE.Response;

namespace TODOLIST.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaService _tareaService;
        public TareaController(ITareaService tareaService)
        {
            _tareaService = tareaService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTareas()
        {
            ApiResponse<List<Tarea>> apiResponse = new ApiResponse<List<Tarea>>();
            try
            {
                List<Tarea> tareas = await _tareaService.GetAllTareas();
                apiResponse.Data = tareas;
                apiResponse.SetSuccess();
            }
            catch (Exception ex)
            {
                apiResponse.SetException(ex);
            }
            return Ok(apiResponse);
        }
        [HttpPost]
        public async Task<IActionResult> RegisterTarea(Tarea tarea)
        {
            ApiResponse<bool> apiResponse = new ApiResponse<bool>();
            try
            {
                bool canRegister = await _tareaService.RegisterTarea(tarea);
                apiResponse.Data = canRegister;
                apiResponse.SetSuccess();
            }
            catch (Exception ex)
            {
                apiResponse.SetException(ex);
            }
            return Ok(apiResponse);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTarea(Tarea tarea)
        {
            ApiResponse<bool> apiResponse = new ApiResponse<bool>();
            try
            {
                bool canRegister = await _tareaService.UpdateTarea(tarea);
                apiResponse.Data = canRegister;
                apiResponse.SetSuccess();
            }
            catch (Exception ex)
            {
                apiResponse.SetException(ex);
            }
            return Ok(apiResponse);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarea(string id)
        {
            ApiResponse<bool> apiResponse = new ApiResponse<bool>();
            try
            {
                bool canDelete = await _tareaService.DeleteTarea(id);
                apiResponse.Data = canDelete;
                apiResponse.SetSuccess();
            }
            catch (Exception ex)
            {
                apiResponse.SetException(ex);
            }
            return Ok(apiResponse);
        }
    }
}
