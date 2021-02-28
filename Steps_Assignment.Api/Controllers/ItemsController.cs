using System;
using Microsoft.AspNetCore.Mvc;
using Steps_Assignment.Models;
using Steps_Assignment.Services;

namespace Steps_Assignment.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemsService;
        public ItemsController(IItemService itemsService)
        {
            _itemsService = itemsService;
        }
        [HttpGet]
        [Route("{stepId}")]
        public ActionResult GetItemByStep(int stepId)
        {
            var result = _itemsService.GetAll(stepId);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateItemDTO model)
        {
            try
            {
                var item = _itemsService.Create(model);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] UpdateItemDTO model)
        {
            try
            {
                _itemsService.Update(model);
                return Ok(true);
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
                _itemsService.Delete(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
