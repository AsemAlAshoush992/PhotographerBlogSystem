using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.Helper;
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
        /// <summary>
        /// Retrieves personal information by userID of the client.
        /// </summary>
        /// <response code="200">Returns the specific personal information by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the personal information.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Client
        ///     {        
        ///       "token": "eyJhbGciOiJIUzI1N"        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetPersonalInformationByUserID([FromHeader] string token/*int userID*/)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
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

        /// <summary>
        /// Retrieves all blogs by userID of the client.
        /// </summary>
        /// <response code="200">Returns list of all blogs by userID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the blogs.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Client
        ///     {        
        ///       "token": "eyJhbGciOiJIUzI1N"         
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBlogsByUserID([FromHeader] string token/*,int userID*/)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
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

        /// <summary>
        /// Retrieves all private galleries by userID of the client.
        /// </summary>
        /// <response code="200">Returns list of all private galleries by userID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the private galleries.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Client
        ///     {        
        ///       "token": "eyJhbGciOiJIUzI1N"       
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllPrivateGalleriesByUserId([FromHeader] string token/*int UserId*/)
        {

            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            try
            {
                return StatusCode(200, await _galleryService.GetAllPrivateGalleriesByUserId(userID));
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred{ex.Message}");
            }
        }



        /// <summary>
        /// Retrieves all private galleries Videos by userID of the client.
        /// </summary>
        /// <response code="200">Returns list of all private galleries by userID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the private galleries.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Client
        ///     {        
        ///       "token": "eyJhbGciOiJIUzI1N"       
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllPrivateGalleriesVideosByUserId([FromHeader] string token/*int UserId*/)
        {

            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            try
            {
                return StatusCode(200, await _galleryService.GetAllPrivateGalleriesVideosByUserId(userID));
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred{ex.Message}");
            }
        }


        /// <summary>
        /// Retrieves all private galleries by userID without orders of the client.
        /// </summary>
        /// <response code="200">Returns list of all private galleries by userID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the private galleries.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Client
        ///     {        
        ///       "token": "eyJhbGciOiJIUzI1N"         
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllPrivateGalleriesByUserIdWithoutOrders([FromHeader] string token/*int UserId*/)
        {

            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            try
            {
                return StatusCode(200, await _galleryService.GetAllPrivateGalleriesByUserIdWithoutOrders(userID));
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred{ex.Message}");
            }
        }


        /// <summary>
        /// Sends a user's blog post for approval.
        /// </summary>
        /// <response code="201">The blog post has been successfully sent for approval.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during the process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Client
        ///     { 
        ///         
        ///        "token": "eyJhbGciOiJIUzI1N"
        ///        "title": "Rania blog",
        ///        "description": "lorem .....",
        ///        "article": "lorem .....",
        ///        "filePath": [
        ///          "photo/Rania.JPEG"
        ///        ]       
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendBlogFromUserForApproval([FromHeader] string token, CreateBlogAdminDTO dto)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _blogService.SendClientBlogRequest(dto, userID);
                return StatusCode(201, "New Blog Has Been sent");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }



        /// <summary>
        /// Sends an order for a specific service.
        /// </summary>
        /// <response code="201">The order has been successfully sent.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">Service unavailable, an error occurred while sending the order.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Client
        ///     { 
        ///       "paymentMethod": "Cash",
        ///       "token": "eyJhbGciOiJIUzI1N" 
        ///       "serviceName": "Travel Photoshoot"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendOrderForSpecificService([FromHeader] string token,CreateOrderClientDTO dto)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                int orderId = await _orderService.SendOrderForSpecificService(dto, userID);
                return StatusCode(202, $"New Order Has Been sent, your order number is {orderId} please keep it");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Sends an contact request for a specific service.
        /// </summary>
        /// <response code="201">The contact request has been successfully sent.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">Service unavailable, an error occurred while sending the contact request.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Client
        ///     { 
        ///       "clientName": "Bob Smith",
        ///       "email": "bob.smith@yahoo.com",
        ///       "phone": "00962712345679",
        ///       "description": "I need Portrait Session",
        ///       "purpose": "Portrait",
        ///       "budget": 100
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendContactRequestForSpecifiService(CreateContactRequestDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _contactRequestService.SendContactRequestForService(dto);
                return StatusCode(202, "New Contact Request Has Been Sent");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Uploads files to a user's private gallery.
        /// </summary>
        /// <response code="201">The files have been successfully uploaded.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during the upload process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Client
        ///     { 
        ///       "path": "photos/Rami",
        ///       "token": "eyJhbGciOiJIUzI1N" 
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UploadPrivateGalleryFiles([FromHeader] string token,CreatePrivateGalleryDTO dto)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _galleryService.UploadFilesForUserByPrivateGallery(dto, userID);
                return StatusCode(201, "New File Has Been created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }
        //one problem has one order but one user has many problem
        /// <summary>
        /// Sends an technical support request for the admin.
        /// </summary>
        /// <response code="201">The technical support request has been successfully sent.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">technical support unavailable, an error occurred while sending the technical support request.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Client
        ///     { 
        ///       "title": "Photo Quality",
        ///       "purpose": "Service",
        ///       "description": "Poor photo quality.",
        ///       "token": "eyJhbGciOiJIUzI1N" 
        ///       "orderId": 31
        ///     }
        /// </remarks>

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendTechnicalSupportRequest([FromHeader] string token, CreateProblemDTO dto)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _problemService.SendTechnicalSupportRequest(dto, userID);
                return StatusCode(202, "New Technical Support Has Been sent");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Updates an existing personal information data of the client.
        /// </summary>
        /// <response code="200">The personal information has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The personal information was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Client
        ///     { 
        ///       "token": "eyJhbGciOiJIUzI1N" 
        ///       "firstName": "Shadi",
        ///       "lastName": "Khalil",
        ///       "password": "Shadik123@",
        ///       "birthDate": null,
        ///       "imagePath": null,
        ///       "phone": null     
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdatePersonalInformationForUserAcount([FromHeader] string token,[FromBody] UpdateUserDTO dto)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _userService.UpdateUserAccount(dto, userID);
                return StatusCode(200, "The Personal Information has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing blog data of the client.
        /// </summary>
        /// <response code="200">The blog has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The blog was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Client
        ///     { 
        ///       "id": 25,
        ///       "attachementId": 37,
        ///       "title": "Ibrahim blog",
        ///       "description": "lorem ...",
        ///       "article": null,
        ///       "path": null
        ///     }
        /// </remarks>
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

        /// <summary>
        /// Updates an existing private gallery file of the client.
        /// </summary>
        /// <response code="200">The private gallery file has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The private gallery file was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Client
        ///     { 
        ///       "id": 21,
        ///       "path": "photos/Sameer"
        ///     }
        /// </remarks>
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

        /// <summary>
        /// Deletes a specific blog of the client.
        /// </summary>
        /// <response code="200">The blog has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The blog was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Client
        ///     { 
        ///       "ID": 10
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteBlogForSpecificUser(int ID)
        {
            if (ID == 0)
                return BadRequest("Please filling BlogId");
            try
            {
                await _blogService.DeleteBlog(ID);
                return StatusCode(200, "The Blog has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific private gallery file of the client.
        /// </summary>
        /// <response code="200">The private gallery file has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The private gallery file was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Client
        ///     { 
        ///       "ID": 10
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeletePrivateGalleryFile(int ID)
        {
            if (ID == 0)
                return BadRequest("Please filling PrivateGalleryId");
            try
            {
                await _galleryService.DeletePrivateGallery(ID);
                return StatusCode(200, "The Private Gallery File has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        
        /// <summary>
        /// Cancels an order for a specific service for a client.
        /// </summary>
        /// <response code="200">The service request has been successfully canceled.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The order was not found or an error occurred during the cancellation process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Client
        ///     { 
        ///       "orderId": 20,
        ///       "reason": "Poor quality"
        ///     }
        /// </remarks>
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
