using Microsoft.AspNetCore.Mvc;
using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Bulky.Models;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API calls
        [HttpGet]
        public IActionResult GetAll()
        {
            List<OrderHeader> objOrderHeader = _unitOfWork.OrderHeader.GetAll(includeProperties: "ApplicationUser").ToList();
            return Json(new { data = objOrderHeader });
        }

        #endregion
    }
}
