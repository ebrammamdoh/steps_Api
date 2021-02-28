using System;
using Microsoft.AspNetCore.Mvc;
using Steps_Assignment.Api.Services;
using Steps_Assignment.Models;
using Steps_Assignment.Services;

namespace Steps_Assignment.Controllers
{
    [ApiController]
    [Route("api/steps")]
    public class StepsController : ControllerBase
    {
        private readonly IStepService _stepService;
        public StepsController(IStepService stepService)
        {
            _stepService = stepService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var result = _stepService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Create()
        {
            try
            {
                var item = _stepService.Create();
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _stepService.Delete(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
