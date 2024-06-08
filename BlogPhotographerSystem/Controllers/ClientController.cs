using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Infra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPhotographerSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IBlogService _blogService;
        private readonly IOrderService _orderService;
        private readonly IContactRequestService _contactRequestService;
        private readonly IProblemService _problemService;
        private readonly IGalleryService _galleryService;

        public ClientController(IUserService userService, IBlogService blogService, IOrderService orderService, IContactRequestService contactRequestService, IProblemService problemService, IGalleryService galleryService)
        {
            _userService = userService;
            _blogService = blogService;
            _orderService = orderService;
            _contactRequestService = contactRequestService;
            _problemService = problemService;
            _galleryService = galleryService;
        }
        //PersonalInformations
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetPersonalInformationsByUserID([FromBody] int userID)
        {

            if (userID == null)
            {
                return BadRequest("Please filling UserID");
            }
            try
            {
                return StatusCode(200, await _userService.GetPersonalInformationsById(userID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBlogsByUserID(int userID)
        {

            if (userID == null)
            {
                return BadRequest("Please filling UserID");
            }
            try
            {
                return StatusCode(200, await _blogService.GetAllBlogsByUserId(userID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }

        //PrivateGallery
        [HttpGet]
        [Route("[action]/{UserId}")]
        public async Task<IActionResult> GetAllPrivateGalleriesByUserId(int UserId)
        {

            if (UserId == null)
            {
                return BadRequest("Please filling UserId");
            }
            try
            {
                return StatusCode(200, await _galleryService.GetAllPrivateGalleriesByUserId(UserId));
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred{ex.Message}");
            }
        }
        
        
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendBlogFromUserForApproval(CreateBlogAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _blogService.SendClientBlogRequest(dto);
                return StatusCode(201, "New Blog Has Been sent");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }
        //UpdatePersonalInformationForUserAcount

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdatePersonalInformationForUserAcount([FromBody] UpdateUserDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _userService.UpdateUserAccount(dto);
                return StatusCode(200, "The Personal Information has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBlogForSpecificUser([FromBody] UpdateBlogClientDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _blogService.UpdateClientBlog(dto);
                return StatusCode(200, "The Blog has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        //PrivateGallery
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdatePrivateGalleryFile([FromBody] UpdatePrivateGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _galleryService.UpdateFilesForClientByPrivateGallery(dto);
                return StatusCode(200, "The Private Gallery File has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteBlogForSpecificUser([FromBody] UpdateBlogAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling BlogId");
            try
            {
                await _blogService.DeleteBlog(dto);
                return StatusCode(200, "The Blog has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeletePrivateGalleryFile([FromBody] UpdatePrivateGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling PrivateGalleryId");
            try
            {
                await _galleryService.DeleteFilesForClientByPrivateGallery(dto);
                return StatusCode(200, "The Private Gallery File has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        //DeletePrivateGallery
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendOrderForSpecificService(CreateOrderClientDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _orderService.SendOrderForSpecificService(dto);
                return StatusCode(202, "New Order Has Been sent");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendContactRequestForSpecifiService(CreateContactRequestDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _contactRequestService.SendContactRequestForService(dto);
                return StatusCode(202, "New Contact Request Has Been sent");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UploadPrivateGalleryFiles(CreatePrivateGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _galleryService.UploadFilesForUserByPrivateGallery(dto);
                return StatusCode(201, "New File Has Been created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }
        //UploadPrivateGallery
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendTechnicalSupportRequest(CreateProblemDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _problemService.SendTechnicalSupportRequest(dto);
                return StatusCode(202, "New Technical Support Has Been sent");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }
        //SendTechnicalSupportRequest
        //SendContactRequestForSpecifiService
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> CancelOrderForSpecificServiceForUser([FromBody] CancelOrderClientDTO dto )
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _orderService.CancelOrderForSpecificService(dto);
                return StatusCode(200, "The Service Request has been successfully cancelled");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
     
    }
}
