using Assignment4V3.Data;
using Assignment4V3.Models;
using Assignment4V3.ModelView;
using Assignment4V3.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4V3.Controllers
{
    public class RoomSearchController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoomService _roomService;

        public RoomSearchController(ApplicationDbContext context, RoomService roomService)
        {
            _context = context;
            _roomService = roomService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search([Bind("Checkin,Checkout,BedOption,roomSize,Booked")] RoomViewModel searchModel)
        {
            DateTime checkInDate = searchModel.Checkin ?? DateTime.Today;
            DateTime checkOutDate = searchModel.Checkout ?? DateTime.Today.AddDays(1);

           if (ModelState.IsValid)
            {
                var availableRooms = _roomService.GetAvailableRooms(
                   searchModel.Checkin ?? DateTime.Today,
                    searchModel.Checkout ?? DateTime.Today.AddDays(1),
                    searchModel.BedOption,
                    searchModel.Price,
                    false // أو أي معايير إضافية
                );

                // يمكنك إرجاع النتائج هنا إلى View جديد أو نفس الـ View.
                return View("Search", availableRooms.ToList());
            }

            // إذا لم يكن نموذج البحث صحيح، أعد المستخدم إلى النموذج 
            return View("Search", searchModel);
        }

        public IActionResult GetAvailableRooms(DateTime checkin, DateTime checkout, BedOptions bedOption, decimal Pris, bool Booked)
        {
            var availableRooms = _roomService.GetAvailableRooms(checkin, checkout, bedOption, Pris, false);

            // يمكنك تنسيق البيانات وإرسالها إلى عرض الواجهة الأمامية هنا
            return View(availableRooms);
        }

    }
}
