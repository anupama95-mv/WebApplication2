using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            // TEMP login check (later connect to API/DB)
            if (Username == "admin" && Password == "1234")
            {
                return RedirectToPage("ProductListPage");
            }

            ErrorMessage = "Invalid Username or Password";
            return Page();
        }
    }
}
