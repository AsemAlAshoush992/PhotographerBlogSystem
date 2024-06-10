using BlogPhotographerSystem_Core.DTOs.Blog;
using BlogPhotographerSystem_Core.DTOs.Category;
using BlogPhotographerSystem_Core.DTOs.ContactRequest;
using BlogPhotographerSystem_Core.DTOs.Gallery;
using BlogPhotographerSystem_Core.DTOs.Login;
using BlogPhotographerSystem_Core.DTOs.Order;
using BlogPhotographerSystem_Core.DTOs.Problem;
using BlogPhotographerSystem_Core.DTOs.Service;
using BlogPhotographerSystem_Core.DTOs.User;
using BlogPhotographerSystem_Core.IServices;
using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Infra.Services;
using Microsoft.AspNetCore.Http;
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
        /// Retrieves contact request by ID of the admin.
        /// </summary>
        /// <response code="200">Returns the specific contact request by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the contact request.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 2        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetContactRequestDetailsByID(int ID)
        {

            if (ID == null)
            {
                return BadRequest("Please filling ContactRequestID");
            }
            try
            {
                return StatusCode(200, await _contactRequestService.GetContactRequestDetailsById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves blog details by ID of the admin.
        /// </summary>
        /// <response code="200">Returns the specific blog by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the blog.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 4        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetBlogDetailsByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling BlogID");
            }
            try
            {
                return StatusCode(200, await _blogService.GetBlogDetailsForAdminById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves user details by ID of the admin.
        /// </summary>
        /// <response code="200">Returns the specific user by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the user.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 5        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetUserDetailsByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling UserID");
            }
            try
            {
                return StatusCode(200, await _userService.GetUserDetailsById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred{ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves service details by ID of the admin.
        /// </summary>
        /// <response code="200">Returns the specific service by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the service.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 4        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetServiceDetailsByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling ServiceID");
            }
            try
            {
                return StatusCode(200, await _service.GetServiceDetailsById(ID));
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
        /// Retrieves category details by ID of the admin.
        /// </summary>
        /// <response code="200">Returns specific category by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the category.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 3        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetCategoryDetailsByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling CategoryID");
            }
            try
            {
                return StatusCode(200, await _categoryService.GetCategoryDetailsById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves order details by ID of the admin.
        /// </summary>
        /// <response code="200">Returns specific order by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the order.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 2        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetOrderDetailsByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling OrderID");
            }
            try
            {
                return StatusCode(200, await _orderService.GetOrderDetailsById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves problem details by ID of the admin.
        /// </summary>
        /// <response code="200">Returns specific problem by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the problem.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 1        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetProblemDetailsByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling ProblemID");
            }
            try
            {
                return StatusCode(200, await _problemService.GetProblemDetailsById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves public gallery by ID of the admin.
        /// </summary>
        /// <response code="200">Returns specific public gallery by ID.</response>
        /// <response code="404">No content found or an error occurred while retrieving the public gallery.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "ID": 4        
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]/{ID}")]
        public async Task<IActionResult> GetPublicGalleryByID(int ID)
        {
            if (ID == null)
            {
                return BadRequest("Please filling PublicGalleryID");
            }
            try
            {
                return StatusCode(200, await _galleryService.GetPublicGalleryDetailsById(ID));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Filters users based on their email or phone number.
        /// </summary>
        /// <response code="200">Returns the list of users that match the provided email or phone number.</response>
        /// <response code="204">No users match the provided criteria or an error occurred.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Admin
        ///     {        
        ///       "Email": "asem.saleh2017@gmail.com",
        ///       "Phone": "00962795747446"
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FilterUsersByPhoneOrEmail(string? Email, string? Phone)
        {
            try
            {
                return StatusCode(200, await _userService.FilterUsersByPhoneOrEmail(Email, Phone));
            }
            catch (Exception ex)
            {
                return StatusCode(204, $"Error occurred {ex.Message}");
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
        ///       "imagePath": "/services/macro.jpg",
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
        public async Task<IActionResult> CreateNewService(CreateServiceAdminDTO dto)
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
        ///        "isApproved": true,
        ///        "authorId": 1,
        ///        "attachments": [
        ///          {
        ///            "filePath": "photo/saleh",
        ///            "fileName": "spring",
        ///            "fileType": "Image"
        ///          }
        ///        ]       
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewBlog(CreateBlogAdminDTO dto)
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
        ///       "imagePath": "/images/landscape.jpg",
        ///       "creatorUserId": 1      
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
        ///       "password": "Khaled123#",
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
        ///       "title": "asem blog",
        ///       "description": null,
        ///       "article": null,
        ///       "blogDate": "2024-06-10T17:47:40.882Z",
        ///       "isApproved": true,
        ///       "authorID": null,
        ///       "modifiedDate": "2024-06-10T17:47:40.882Z",
        ///       "modifiedUserId": null,
        ///       "isDeleted": null      
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
        ///       "disacountAmount": null,
        ///       "discountType": null,
        ///       "categoryID": null,
        ///       "modifiedDate": "2024-06-10T17:55:16.997Z",
        ///       "modifiedUserId": 0,
        ///       "isDeleted": null     
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
        /// Updates an existing contact request data of the admin.
        /// </summary>
        /// <response code="200">The contact request has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The contact request was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "id": 106,
        ///       "clientName": "Wael",
        ///       "email": null,
        ///       "phone": null,
        ///       "description": null,
        ///       "purpose": null,
        ///       "budget": 40,
        ///       "userID": null,
        ///       "modifiedDate": "2024-06-10T17:58:09.010Z",
        ///       "modifiedUserId": 0,
        ///       "isDeleted": null   
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateContactRequestData([FromBody] UpdateContactRequestDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _contactRequestService.UpdateContactRequest(dto);
                return StatusCode(200, "The ContactRequest has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing admin data of the admin.
        /// </summary>
        /// <response code="200">The admin has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The admin was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {        
        ///       "id": 755,
        ///       "firstName": "Omar",
        ///       "lastName": "defallah",
        ///       "email": "Omar.defallah@gmail.com",
        ///       "imagePath": "photos/Omar",
        ///       "phone": null,
        ///       "birthDate": "2024-06-10T18:03:30.366Z",
        ///       "modifiedUserId": 0,
        ///       "isDeleted": null  
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateAdminData([FromBody] UpdateUserAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _userService.UpdateUser(dto);
                return StatusCode(200, "The Admin Data has been Updated successfully");
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
        ///       "imagePath": null,
        ///       "modifiedDate": "2024-06-10T18:14:17.496Z",
        ///       "modifiedUserId": null,
        ///       "isDeleted": null
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
        /// Updates an existing order data of the admin.
        /// </summary>
        /// <response code="200">The order has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The order was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {       
        ///       "id": 31,
        ///       "orderDate": "2024-06-10T18:17:07.604Z",
        ///       "title": "Macro order",
        ///       "note": null,
        ///       "status": null,
        ///       "paymentMethod": null,
        ///       "userID": null,
        ///       "serviceID": null,
        ///       "modifiedDate": "2024-06-10T18:17:07.604Z",
        ///       "modifiedUserId": null,
        ///       "isDeleted": null
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateOrderData([FromBody] UpdateOrderAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _orderService.UpdateOrder(dto);
                return StatusCode(200, "The Order has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing problem data of the admin.
        /// </summary>
        /// <response code="200">The problem has been updated successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The problem was not found or an error occurred during the update.</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Put api/Admin
        ///     {       
        ///       "id": 20,
        ///       "title": "مشكلة التسليم",
        ///       "purpose": null,
        ///       "description": null,
        ///       "userID": 10,
        ///       "orderID": null,
        ///       "modifiedDate": "2024-06-10T18:25:48.562Z",
        ///       "modifiedUserId": null,
        ///       "isDeleted": null
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateProblemData([FromBody] UpdateProblemDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _problemService.UpdateProblem(dto);
                return StatusCode(200, "The Problem has been Updated successfully");
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
        ///       "path": "Image/Sami/file",
        ///       "fileName": "Sami",
        ///       "fileType": null,
        ///       "isPrivate": null,
        ///       "orderID": null,
        ///       "modifiedDate": "2024-06-10T18:45:33.681Z",
        ///       "modifiedUserId": null,
        ///       "isDeleted": null
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGalleryData([FromBody] UpdatePrivateGalleryDTO dto)
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
                return StatusCode(200, "The PrivateGallery has been Deleted successfully");
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
        /// Deletes a specific admin of the admin.
        /// </summary>
        /// <response code="200">The admin has been deleted successfully.</response>
        /// <response code="400">Bad request, indicating missing or invalid data.</response>
        /// <response code="404">The admin was not found or an error occurred during deletion.</response>
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
        public async Task<IActionResult> DeleteAdmin(int ID)
        {
            if (ID == null)
                return BadRequest("Please filling UserId");
            try
            {
                await _userService.DeleteUser(ID);
                return StatusCode(201, "The Admin has been Deleted successfully");
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
        ///       "path": "photos/shadi",
        ///       "fileName": null,
        ///       "fileType": null,
        ///       "orderID": null        
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
                return StatusCode(201, "New Private Gallery Files Has Been Sent");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
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
        [Route("[action]/{ID}")]
        public async Task<IActionResult> ConfirmUserBlogAndPublish([FromRoute] int blogID)
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
    }
}
