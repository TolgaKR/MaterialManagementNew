using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MaterialManagement.ViewModels;

namespace MaterialManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Adres boşsa, varsayılan değer ekle
                if (string.IsNullOrEmpty(model.Address))
                {
                    model.Address = "Adres girilmedi"; // Varsayılan değeri burada ekleyin
                }
                // UserViewModel'den AppUser'a verileri taşıyoruz
                var user = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PasswordHash = model.Password,
                    Name = model.Name,
                    Surname = model.Surname,
                  
                    Department = model.Department,
                    IdentityCard = model.IdentityCard,
                    PhoneNumber = model.PhoneNumber, // İsteğe bağlı
                      Address = model.Address// Burada varsayılan değer ile kullanıcıyı kaydedin
                };


                // UserService ile kullanıcıyı kaydetme
                var result = await _userService.RegisterUserAsync(model.Email, model.Password, model.Address, model.PhoneNumber, model.Department, model.Name, model.Surname, model.IdentityCard);

                if (result.Succeeded)
                {
                    TempData["SuccessMessage"] = "Kayıt işlemi başarılı!";
                    return RedirectToAction("Index", "Home"); // Kayıt başarılı olunca yönlendirme
                }

                // Hataları modele ekleme
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model); // Hatalı durumlarda aynı sayfayı geri döndür
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
