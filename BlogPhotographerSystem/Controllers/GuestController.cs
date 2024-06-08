using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPhotographerSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILoginService _loginService;
        private readonly IBlogService _blogService;
        private readonly IServiceService _serviceService;
        private readonly IGalleryService _galleryService;
        private readonly ICategoryService _categoryService;
        public GuestController(IUserService userService, ILoginService loginService, IBlogService blogService, IServiceService serviceService, IGalleryService galleryService, ICategoryService categoryService)
        {
            _userService = userService;
            _loginService = loginService;
            _blogService = blogService;
            _serviceService = serviceService;
            _galleryService = galleryService;
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBlogCards()
        {
            try
            {
                return StatusCode(201, await _blogService.GetAllBlogsInfo());
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllServices()
        {
            try
            {
                return StatusCode(201, await _serviceService.GetAllServices());
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllPhotosForPublicGallery()
        {
            try
            {
                return StatusCode(201, await _galleryService.GetAllPhotosForPublicGallery());
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllVideosForPublicGallery()
        {
            try
            {
                return StatusCode(201, await _galleryService.GetAllVideosForPublicGallery());
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                return StatusCode(201, await _categoryService.GetAllCategories());
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewClient([FromBody] RegisterDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _userService.Register(dto);
                return StatusCode(201, "New Account Has Been Created");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> LoginUserAccount([FromBody] CreateLoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.UserName) || string.IsNullOrEmpty(dto.Password))
                return BadRequest("Please filling All Data");
            try
            {
                await _loginService.Login(dto);
                return StatusCode(201, "Login has been successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> LogoutUserAcount([FromBody] int userID)
        {
            if (userID == null)
            {
                return BadRequest("Please filling All Data");
            }   
            try
            {
                await _loginService.Logout(userID);
                return StatusCode(201, "Logout has been successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> ResetPasswordUserAcount([FromBody]CreateLoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.UserName) || string.IsNullOrEmpty(dto.Password))
            {
                return BadRequest("Please filling All Data");
            }   
            try
            {
                await _loginService.ResetPassword(dto);
                return StatusCode(201, "Reset Password has been successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
    }
}
