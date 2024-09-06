using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.Helper;
using BlogPhotographerSystem_Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BlogPhotographerSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;
        private readonly IServiceService _service;
        private readonly IOrderService _orderService;
        private readonly IContactRequestService _contactRequestService;
        private readonly IProblemService _problemService;
        private readonly IGalleryService _galleryService;

        public AdminController(IBlogService blogService, ICategoryService categoryService, IUserService userService, IServiceService service, IOrderService orderService, IContactRequestService contactRequestService, IProblemService problemService, IGalleryService galleryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _userService = userService;
            _service = service;
            _orderService = orderService;
            _contactRequestService = contactRequestService;
            _problemService = problemService;
            _galleryService = galleryService;
        }
        /// <summary>
        /// Retrieves all blogs of the admin.
        /// </summary>
        /// <response code="200">Returns the list of all blog posts created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the blogs.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBlogsForAdmin()
        {
            try
            {
                return StatusCode(200, await _blogService.GetAllBlogsDetails());
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred{ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves all contact requests of the admin.
        /// </summary>
        /// <response code="200">Returns the list of all contact requests created by clients.</response>
        /// <response code="404">No content found or an error occurred while retrieving the contact requests.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllContactRequestsForAdmin()
        {
            try
            {
                return StatusCode(200, await _contactRequestService.GetAllContactRequests());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }



        /// <summary>
        /// Retrieves all categories of the admin.
        /// </summary>
        /// <response code="200">Returns the list of all the Categories created by admin.</response>
        /// <response code="404">No content found or an error occurred while retrieving the Categories.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllCategoriesForAdmin()
        {
            try
            {
                return StatusCode(200, await _categoryService.GetAllCategoriesForAdmin());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }



        /// <summary>
        /// Retrieves all public galleries of the admin.
        /// </summary>
        /// <response code="200">Returns list of all public galleries created by admin.</response>
        /// <response code="404">No content found or an error occurred while retrieving the public galleries.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllPublicGalleries()
        {
            try
            {
                return StatusCode(200, await _galleryService.GetPublicGalleries());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }



        /// <summary>
        /// Retrieves all users of the admin.
        /// </summary>
        /// <response code="200">Returns list of all users created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the users.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllUsersForAdmin()
        {
            try
            {
                return StatusCode(200, await _userService.GetAllUsersDetails());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Retrieves all services of the admin.
        /// </summary>
        /// <response code="200">Returns list of all services created by admin.</response>
        /// <response code="404">No content found or an error occurred while retrieving the services.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllServicesDetailsForAdmin()
        {
            try
            {
                return StatusCode(200, await _service.GetAllServicesForAdmin());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves all orders of the admin.
        /// </summary>
        /// <response code="200">Returns list of all orders created.</response>
        /// <response code="404">No content found or an error occurred while retrieving the orders.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllOrdersDetailsForAdmin()
        {
            try
            {
                return StatusCode(200, await _orderService.GetAllOrders());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Retrieves all problems of the admin.
        /// </summary>
        /// <response code="200">Returns list of all problems created by admin.</response>
        /// <response code="404">No content found or an error occurred while retrieving the problems.</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllProblemsDetailsForAdmin()
        {
            try
            {
                return StatusCode(200, await _problemService.GetAllProblems());
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
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
        ///       "fileName": "Rami"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UploadPublicGalleryFiles(CreatePublicGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _galleryService.UploadFilesForPublicGallery(dto);
                return StatusCode(201, "New File Has Been created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Creates a new service of the admin.
        /// </summary>
        /// <response code="201">New service has been successfully created.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during service creation.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Admin
        ///     {        
        ///       "name": "Macro Photography",
        ///       "description": "Macro photography session.",
        ///       "imagePath": "macro.jpg",
        ///       "price": 50,
        ///       "quantity": 2,
        ///       "isHaveDiscount": true,
        ///       "disacountAmount": 10,
        ///       "discountType": "Percent",
        ///       "categoryID": 10        
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewService( CreateServiceAdminDTO  dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _service.CreateService(dto);
                return StatusCode(201, "New Service Has Been Created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Createa a new blog of the admin.
        /// </summary>
        /// <response code="201">New blog has been successfully created.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during blog creation.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Admin
        ///     {        
        ///        "title": "Saleh blog",
        ///        "description": "lorem .....",
        ///        "article": "lorem .....",
        ///        "filePath": [
        ///        "photo/saleh.JPEG"
        ///        ]       
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewBlog( CreateBlogAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _blogService.CreateBlog(dto);
                return StatusCode(201, "New Blog Has Been Created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Creates a new category of the admin.
        /// </summary>
        /// <response code="201">New category has been successfully created.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during category creation.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Admin
        ///     {        
        ///       "title": "Landscape Photography",
        ///       "description": "Category for landscape photography articles",
        ///       "imagePath": "landscape.jpg",    
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewCategory(CreateCategoryAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _categoryService.CreateCategory(dto);
                return StatusCode(201, "New Category Has Been Created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Creates a new admin of the admin.
        /// </summary>
        /// <response code="201">New admin has been successfully created.</response>
        /// <response code="400">Bad request, indicating missing or invalid data, or an error occurred during admin creation.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Post api/Admin
        ///     {        
        ///       "firstName": "Khaled",
        ///       "lastName": "Ali",
        ///       "email": "Khaled.Ali88@yahoo.com",
        ///       "password": "khaledB123#",
        ///       "birthDate": "1988-06-12T17:43:07.185Z",
        ///       "imagePath": "photos/Khaled",
        ///       "phone": "00962799553026"      
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewAdmin(CreateUserAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _userService.CreateNewAdmin(dto);
                return StatusCode(201, "New Admin Has Been Created");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Sends files to a user's private gallery by admin.
        /// </summary>
        /// <response code="201">New private gallery files have been successfully sent.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="503">Service unavailable, an error occurred while sending the files.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "path": "videos/shadi",
        ///       "orderID": 5        
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendPrivateGalleryFiles(SendPrivateGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _galleryService.SendFilesForUserByPrivateGallery(dto);
                return StatusCode(201, "New Private Gallery File For A Specific Order Has Been Sent");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Updates an existing blog data of the admin.
        /// </summary>
        /// <response code="200">The blog has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The blog post was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "id": 22,
        ///       "attachementId": 10,
        ///       "title": "asem blog",
        ///       "description": null,
        ///       "article": null,
        ///       "blogDate": "2024-06-10T17:47:40.882Z",
        ///       "isApproved": true,
        ///       "authorID": null,
        ///       "path": "Wildlif.png"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBlogData([FromBody] UpdateBlogAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _blogService.UpdateBlog(dto);
                return StatusCode(200, "The Blog has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Updates an existing service data of the admin.
        /// </summary>
        /// <response code="200">The service has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The servicet was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "id": 11,
        ///       "name": "service 1",
        ///       "description": null,
        ///       "imagePath": null,
        ///       "price": 15,
        ///       "quantity": null,
        ///       "isHaveDiscount": true,
        ///       "disacountAmount": 60,
        ///       "discountType": "Percent",
        ///       "categoryID": null   
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateServiceData([FromBody] UpdateServiceAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _service.UpdateService(dto);
                return StatusCode(200, "The Service has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing category data of the admin.
        /// </summary>
        /// <response code="200">The category has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The category was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {       
        ///       "id": 11,
        ///       "title": "Category 11",
        ///       "description": null,
        ///       "imagePath": null
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCategoryData([FromBody] UpdateCategoryAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _categoryService.UpdateCategory(dto);
                return StatusCode(200, "The Category has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing private or public gallery data of the admin.
        /// </summary>
        /// <response code="200">The gallery has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The gallery was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {       
        ///       "id": 22,
        ///       "path": "Image/Sami",
        ///       "fileName": "Sami"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGalleryData([FromBody] UpdateGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _galleryService.UpdatePrivateGallery(dto);
                return StatusCode(200, "The Gallery has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific order of the admin.
        /// </summary>
        /// <response code="200">The order has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The order was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificOrder(int ID)
        {
            if (ID == null)
                return BadRequest("Please filling OrderId");
            try
            {
                await _orderService.DeleteOrder(ID);
                return StatusCode(200, "The Order has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Deletes a specific gallery of the admin.
        /// </summary>
        /// <response code="200">The gallery has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The gallery was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificGallery(int ID)
        {
            if (ID == null)
                return BadRequest("Please filling PrivateGalleryId");
            try
            {
                await _galleryService.DeletePrivateGallery(ID);
                return StatusCode(200, "The Private Gallery has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific contact request of the admin.
        /// </summary>
        /// <response code="200">The contact request has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The contact request was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificContactRequest(int ID)
        {

            if (ID == null)
                return BadRequest("Please filling ContactRequestId");
            try
            {
                await _contactRequestService.DeleteContactRequest(ID);
                return StatusCode(200, "The ContactRequest has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific service of the admin.
        /// </summary>
        /// <response code="200">The service has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The service was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificService(int ID)
        {
            if (ID == null)
                return BadRequest("Please filling ServiceId");
            try
            {
                await _service.DeleteService(ID);
                return StatusCode(200, "The Service has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific blog of the admin.
        /// </summary>
        /// <response code="200">The blog has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificBlog(int ID)
        {
            if (ID == null)
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
        /// Deletes a specific user Account.
        /// </summary>
        /// <response code="200">The admin has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The admin was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9"        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteUserAccount([FromHeader] string token/*int ID*/)
        {
            int userID = TokenHelper.IsValidToken2(token);
            if (!TokenHelper.IsValidToken(token))
            {
                return BadRequest("you're token failed");
            }
            try
            {
                await _userService.DeleteUser(userID);
                return StatusCode(201, "The User has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific user.
        /// </summary>
        /// <response code="200">The admin has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The admin was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 5        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteUser(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Fill the userId");
            }
            try
            {
                await _userService.DeleteUser(ID);
                return StatusCode(201, "The User has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Deletes a specific category of the admin.
        /// </summary>
        /// <response code="200">The category has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The category was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificCategory( int ID)
        {
            if (ID == null)
                return BadRequest("Please filling CategoryId");
            try
            {
                await _categoryService.DeleteCategory(ID);
                return StatusCode(200, "The Category has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a specific problem of the admin.
        /// </summary>
        /// <response code="200">The problem has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The problem was not found or an error occurred during deletion.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> DeleteSpecificProblem(int ID)
        {
            if (ID == null)
                return BadRequest("Please filling ProblemId");
            try
            {
                await _problemService.DeleteProblem(ID);
                return StatusCode(200, "The Problem has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
  
        /// <summary>
        /// Confirm user blog and post to client by admin.
        /// </summary>
        /// <response code="202">The blog has been successfully approved and published.</response>
        /// <response code="400">Bad request, indicating missing or invalid blog ID, or an error occurred during the process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "blogID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{blogID}")]
        public async Task<IActionResult> ConfirmUserBlogAndPublish(int blogID)
        {
            if (blogID == null)
                return BadRequest("Please filling BlogId");
            try
            {
                await _blogService.ConfirmUserBlog(blogID);
                return StatusCode(202, "The Blog has been successfully Approved");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }


        /// <summary>
        /// Cancel Client blog by admin.
        /// </summary>
        /// <response code="202">The blog has been successfully approved and published.</response>
        /// <response code="400">Bad request, indicating missing or invalid blog ID, or an error occurred during the process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "blogID": 3        
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]/{blogID}")]
        public async Task<IActionResult> CancelUserBlog(int blogID)
        {
            if (blogID == null)
                return BadRequest("Please filling BlogId");
            try
            {
                await _blogService.CancelUserBlog(blogID);
                return StatusCode(202, "The Blog has been successfully Canceled");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Change order status by admin.
        /// </summary>
        /// <response code="202">The blog has been successfully approved and published.</response>
        /// <response code="400">Bad request, indicating missing or invalid blog ID, or an error occurred during the process.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "orderID": 3,
        ///       "status": "Pending"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> ChangeOrderStatus(ChangeSatausDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling Order ID");
            try
            {
                await _orderService.ChangeStatusSpecificOrder(dto);
                return StatusCode(202, "The Order has been successfully Changed");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }
    }
}
