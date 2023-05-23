using AutoMapper;
using FastFood.Data;
using FastFood.Web.ViewModels.Items;
using Microsoft.AspNetCore.Mvc;

namespace FastFood.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly FastFoodContext _context;
        private readonly IMapper _mapper;

        public ItemsController(FastFoodContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Create()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Create(CreateItemInputModel model)
        {
            throw new NotImplementedException();
        }

        public IActionResult All()
        {
            throw new NotImplementedException();
        }
    }
}
