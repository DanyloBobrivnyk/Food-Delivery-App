using AutoMapper;
using Lab1_bobrivnyk.Rest.Configurations;
using Lab1_bobrivnyk.Rest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_bobrivnyk.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemsController : ControllerBase
    {
        private IFoodItemService _foodItemService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public FoodItemsController(
            IFoodItemService foodItemService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _foodItemService = foodItemService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var foodItems = _foodItemService.GetAll();
            return Ok(foodItems);
        }
    }
}
