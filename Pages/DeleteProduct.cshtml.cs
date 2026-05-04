using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models; 

namespace WebApplication2.Pages
{
    public class DeleteProductModel : PageModel
    {
        [BindProperty]
        public ProductModel Product { get; set; }

        public void OnGet(int id)
        {
            Product = new ProductModel
            {
                Id = id,
                ProductName = "Sample Product",
                Price = 100
            };
        }

        public IActionResult OnPost()
        {
            int id = Product.Id;

            // TODO: delete logic

            return RedirectToPage("/ProductListPage");
        }
    }
}