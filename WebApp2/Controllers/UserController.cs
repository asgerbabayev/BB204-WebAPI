using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApp2.DataAccess;
using WebApp2.DTO_s.UserDto_s;

namespace WebApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        AppDbContext AppDbContext { get; }
        private readonly IMapper _mapper;
        public UserController(AppDbContext appDbContext, IMapper mapper)
        {
            AppDbContext = appDbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<List<UserGetDto>>(AppDbContext.AppUser.ToList()));
        }
    }
}
