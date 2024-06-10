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

        /// <summary>
        /// Retrieves all blog posts of the admin.
        /// </summary>
        /// <response code="200">Returns the list of all blog posts created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the blogs.</response>
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

        /// <summary>
        /// Retrieves all services.
        /// </summary>
        /// <response code="200">Returns the list of all services created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the services.</response>
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

        /// <summary>
        /// Retrieves all photos for public gallery.
        /// </summary>
        /// <response code="200">Returns the list of all photos created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the photos.</response>
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

        /// <summary>
        /// Retrieves all videos for public gallery.
        /// </summary>
        /// <response code="200">Returns the list of all videos created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the videos.</response>
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

        /// <summary>
        /// Retrieves all categories.
        /// </summary>
        /// <response code="200">Returns the list of all categories created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the categories.</response>
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

        /// <summary>
        /// Creates a new client.
        /// </summary>
        /// <response code="201">New client has been successfully created.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during client creation.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Guest
        ///     {        
        ///       "firstName": "Rania",
        ///       "lastName": "Ali",
        ///       "email": "Rania.Ali77@yahoo.com",
        ///       "password": "Raniae123#",
        ///       "birthDate": "1988-06-12T17:43:07.185Z",
        ///       "imagePath": "photos/Khaled",
        ///       "phone": "00962799553077"      
        ///     }
        /// </remarks>
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

        /// <summary>
        /// Logs in a user account.
        /// </summary>
        /// <response code="201">The user has successfully logged in.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">Service unavailable, an error occurred during the login process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Guest
        ///     {        
        ///       "userName": "alice.johnson@hotmail.com",
        ///       "password": "Charlie3$"    
        ///     }
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

        /// <summary>
        /// Logs out a user account.
        /// </summary>
        /// <response code="201">The user has successfully logged out.</response>
        /// <response code="400">Bad request, indicating missing or invalid user ID.</response>
        /// <response code="503">Service unavailable, an error occurred during the logout process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Guest
        ///     {        
        ///       "userID": "alice.johnson@hotmail.com"   
        ///     }
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

        /// <summary>
        /// Resets the password for a user account.
        /// </summary>
        /// <response code="201">The password has been successfully reset.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">Service unavailable, an error occurred during the password reset process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Guest
        ///     {        
        ///       "userName": "david.wilson@gmail.com",
        ///       "password": "davidw123!"  
        ///     }
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
