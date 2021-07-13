using AutoMapper;
using IoT_Project_Food_Ordering.Models;
using Lab1_bobrivnyk.Rest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_bobrivnyk.Rest.Services
{
    public interface IFoodItemService
    {
        IEnumerable<FoodItem> GetAll();
    }

    public class FoodItemService
    {
        private AzureDbContext _context;
        private IJwtUtils _jwtUtils;
        private readonly IMapper _mapper;

        public FoodItemService(
            AzureDbContext context,
            IJwtUtils jwtUtils,
            IMapper mapper)
        {
            _context = context;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
        }

        public IEnumerable<FoodItem> GetAll()
        {
            return _context.FoodItems;
        }
    }
}
