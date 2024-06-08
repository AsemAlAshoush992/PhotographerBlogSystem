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
        //ContactRequests
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

        //GetContactRequestByID
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
        //Users
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
        //Orders
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

        //Problem

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

        //PrivateGallery
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
        //CreateService
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
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBlogData([FromBody] UpdateBlogAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling All Data");
            try
            {
                await _blogService.UpdateBlog(dto);
                return StatusCode(200,"The Blog has been Updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }

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

        //ContactRequest
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
        //Problem
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
        //PrivateGallery
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
        
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificOrder([FromBody] UpdateOrderAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling OrderId");
            try
            {
                await _orderService.DeleteOrder(dto);
                return StatusCode(200, "The Order has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        //PrivateGallery
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificGallery([FromBody] UpdatePrivateGalleryDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling PrivateGalleryId");
            try
            {
                await _galleryService.DeletePrivateGallery(dto);
                return StatusCode(200, "The PrivateGallery has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        
        //ContactRequest
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificContactRequest([FromBody] UpdateContactRequestDTO dto)
        {
           
            if (dto == null)
                return BadRequest("Please filling ContactRequestId");
            try
            {
                await _contactRequestService.DeleteContactRequest(dto);
                return StatusCode(200, "The ContactRequest has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificService([FromBody] UpdateServiceAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling ServiceId");
            try
            {
                await _service.DeleteService(dto);
                return StatusCode(200, "The Service has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificBlog([FromBody] UpdateBlogAdminDTO dto)
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
        public async Task<IActionResult> DeleteAdmin([FromBody] UpdateUserAdminDTO  dto)
        {
            if (dto == null)
                return BadRequest("Please filling UserId");
            try
            {
                await _userService.DeleteUser(dto);
                return StatusCode(201, "The Admin has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(503, $"Error occurred {ex.Message}");
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificCategory([FromBody] UpdateCategoryAdminDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling CategoryId");
            try
            {
                await _categoryService.DeleteCategory(dto);
                return StatusCode(200, "The Category has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        //Problem
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSpecificProblem([FromBody] UpdateProblemDTO dto)
        {
            if (dto == null)
                return BadRequest("Please filling ProblemId");
            try
            {
                await _problemService.DeleteProblem(dto);
                return StatusCode(200, "The Problem has been Deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Error occurred {ex.Message}");
            }
        }
        //PrivateGallery
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SendPrivateGalleryFiles(CreatePrivateGalleryDTO dto)
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

        [HttpPut]
        [Route("[action]/{blogID}")]
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
