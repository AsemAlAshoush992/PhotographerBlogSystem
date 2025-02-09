using BlogPhotographerSystem_Core.DTOs.Comment;
using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.Helper;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

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
        private readonly ICommentService _commentService;
        private readonly EmailService _emailService;
        private readonly OTPService _otpService;
        public GuestController(IUserService userService, ILoginService loginService, IBlogService blogService, IServiceService serviceService, IGalleryService galleryService, ICategoryService categoryService, ICommentService commentService, EmailService emailService, OTPService otpService)
        {
            _userService = userService;
            _loginService = loginService;
            _blogService = blogService;
            _serviceService = serviceService;
            _galleryService = galleryService;
            _categoryService = categoryService;
            _commentService = commentService;
            _emailService = emailService;
            _otpService = otpService;
        }

        /// <summary>
        /// Retrieves all blog posts of Guest.
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
        /// Retrieves blog post Deatails of Guest.
        /// </summary>
        /// <response code="200">Returns the post Deatails created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the blog Details.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Guest
        ///     {        
        ///       "blogId": 10      
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{blogId}")]
        public async Task<IActionResult> GetBlogDetailsForUserById(int blogId)
        {
            if (blogId == 0)
                return BadRequest("Please filling BlogId");
            try
            {
                return StatusCode(201, await _blogService.GetBlogDetailsById(blogId));
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves all services by category ID.
        /// </summary>
        /// <response code="200">Returns the list of all services created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the services.</response>
        [HttpGet]
        [Route("[action]/{categoryId}")]
        public async Task<IActionResult> GetAllServicesByCategoryId(int categoryId)
        {
            if (categoryId == 0)
                return BadRequest("Please filling CategoryId");
            try
            {
                return StatusCode(201, await _serviceService.GetAllServices(categoryId));
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
                var otpCode = _otpService.GenerateAndStoreOtp(dto.Email);
                // إرسال بريد إلكتروني للتحقق
                var emailSent = await _emailService.SendEmailAsync(dto.Email, "Email Verification",
                 $@"<html>
                   <body>
                  <p>Hello {dto.FirstName} {dto.LastName},</p>
                  <p>Thank you for registering on our site! To verify your email address, please use the following OTP code:</p>
                  <p><strong>OTP Code: {otpCode}</strong></p>
                  <p>Please enter this code on the verification page to complete your registration. This code is valid for 10 minutes only.</p>
                  <p>If you did not request this verification, please ignore this message.</p>
                  <p>Thank you,<br/>Support Team</p>
                   </body>
                  </html>");

                if (emailSent)
                {
                    return StatusCode(201, "A verification email has been sent. Please check your email to complete registration.");
                }

                return BadRequest("Failed to send verification email.");

            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> VerifyOtp([FromBody] VerifyOtpDTO dto)
        {

            if (_otpService.ValidateOtp(dto.Email, dto.OtpCode))
            {
                return Ok("OTP verified successfully. Registration complete!");
            }

            return BadRequest("Invalid or expired OTP code.");

        }
        /// <summary>
        /// Creates a new Comment.
        /// </summary>
        /// <response code="201">New Comment has been successfully created.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during client creation.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Guest
        ///     {        
        ///       "blogId": 5,
        ///       "authorName": "Ali",
        ///       "content": "Very Good!"   
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewComment([FromBody] CreateCommentDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _commentService.CreateComment(dto);
                return StatusCode(201, "New Comment Has Been Created");
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
        ///       "userName": "Majed.Mohammed7@yahoo.com",
        ///       "password": "MajedM323#"   
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LoginUserAccount([FromBody] CreateLoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.UserName) || string.IsNullOrEmpty(dto.Password))
                return BadRequest("Please filling All Data");
            try
            {
                var token = await _loginService.GenerateUserAccessToken(dto);
                return StatusCode(200, token);
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }


        /// <summary>
        /// Logs in a admin account.
        /// </summary>
        /// <response code="201">The user has successfully logged in.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">Service unavailable, an error occurred during the login process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Guest
        ///     {        
        ///       "userName": "Majed.Mohammed7@yahoo.com",
        ///       "password": "MajedM323#"   
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LoginAdminAccount([FromBody] CreateLoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.UserName) || string.IsNullOrEmpty(dto.Password))
                return BadRequest("Please filling All Data");
            try
            {
                var token = await _loginService.GenerateAdminAccessToken(dto);
                return StatusCode(200, token);
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
        ///       "token": "eyJhbGciOiJIUzI1N"   
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LogoutUserAcount([FromHeader] string token /*int userID*/)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
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
        ///       "userName": "david.wilson",
        ///       "password": "davidw123!"  
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]/{email}")]
        public async Task<IActionResult> ChangePassword(string email, [FromBody] ChangePasswordDTO dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.NewPassword) || string.IsNullOrWhiteSpace(dto.ConfirmPassword))
            {
                return BadRequest("Invalid request.");
            }
            try
            {
                await _loginService.ChangePassword(email, dto);
                return StatusCode(201, "Password has been reset successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> RequestPasswordReset([FromBody] ResetPasswordDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.UserName))
            {
                return BadRequest("Email is required.");
            }
            try
            {
                await _loginService.ResetPassword(dto);
                var resetToken = Guid.NewGuid().ToString(); // توليد توكن

                var resetLink = $"http://localhost:4200/resetpasswordTwo?token={resetToken}";
                // إرسال البريد الإلكتروني
                var subject = "Password Reset Request";
                var body = $"Click the following link to reset your password: <a href='{resetLink}'>Reset Password</a>";
                await _emailService.SendEmailAsync(dto.UserName, subject, body);
                return StatusCode(201, "A reset password link has been sent to your email.");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error Ocurred {ex.Message}");
            }
        }
    }
}
