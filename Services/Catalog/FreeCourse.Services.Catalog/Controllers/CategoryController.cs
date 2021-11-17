using Microsoft.AspNetCore.Mvc;
using FreeCourse.Services.Catalog.Services;
using FreeCourse.Shared.ControllerBases;
using System.Threading.Tasks;
using FreeCourse.Services.Catalog.Dtos;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        internal CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return CreateActionResultInstance(categories);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            return CreateActionResultInstance(category);
        }

        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var response = await _categoryService.CreateAsync(categoryDto);

            return CreateActionResultInstance(response);
        }
    }
}