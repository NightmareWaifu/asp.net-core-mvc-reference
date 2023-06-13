using Healthcare.Data;
using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Controllers
{


    public class AppointmentController : Controller
    {
        private readonly HealthcareDbContext dbContext;

        public AppointmentController(HealthcareDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allAppointments = await dbContext.Appointments.ToListAsync();
            return View(allAppointments);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Appointment appointmentDetails)
        {
            var appointment = new Appointment()
            {
                Id = Guid.NewGuid(),
                Type = appointmentDetails.Type,
                Date = appointmentDetails.Date,
                Doctor = appointmentDetails.Doctor,
                Description = appointmentDetails.Description
            };

            await dbContext.Appointments.AddAsync(appointment);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
