using Assignment4V3.Data;
using Assignment4V3.ModelView;

namespace Assignment4V3.Service
{
    public class RoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RoomViewModel> GetAvailableRooms(DateTime checkin, DateTime checkout, BedOptions bedOption
                    , decimal Prise, bool Booked)
        {
            // الحصول على قائمة الغرف التي تم حجزها في الفترة المحددة
            var reservedRooms = _context.Reservations
                .Where(r => (r.CheckInDate < checkout && r.CheckOutDate > checkin))
                .Select(r => r.RoomId)
                .ToList();

            // الحصول على قائمة كاملة من الغرف
            var allRooms = _context.Rooms.ToList();

            // استبعاد الغرف التي تم حجزها بناءً على الفترة المحددة
            var availableRooms = allRooms
                .Where(room => !reservedRooms.Contains(room.Id))
                .Select(room => new RoomViewModel
                {
                    Id = room.Id,
                   
                    Booked = room.Booked,
                    Checkin = checkin,
                    Checkout = checkout,

                    // قم بإضافة أي خصائص إضافية إلى RoomViewModel إذا كانت مطلوبة
                })
                .ToList();

            return availableRooms;
        }
    }
}
