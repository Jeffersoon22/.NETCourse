using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Tutorial_1.Model;
using Tutorial_1.Services;

namespace Tutorial_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IPositionService _positionService;
        private readonly IFileService _fileService;

        public HomeController(IContactService contactService, IPositionService positionService, IFileService fileService)
        {
            _contactService = contactService;
            _positionService = positionService;
            _fileService = fileService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = _contactService.GetContacts();
            return View(contacts);
        }

        public IActionResult Create(string name, string phone, string position)
        {
            var contactPosition =  _positionService.GetPositions().SingleOrDefault(x => x.Name == position);

            var contact = new Contact() { Name = name, Phone = phone, Position = contactPosition};
            _contactService.AddContact(contact);
            var contacts = _contactService.GetContacts();

            _fileService.SaveToFile(contacts.ToList());

            return View("Contact", contacts);
        }

        [HttpGet("Home/CreateContact")]
        public IActionResult CreateContact()
        {
            var positions = _positionService.GetPositions();

            ViewBag.positions = positions;

            return View();
        }
    }
}
