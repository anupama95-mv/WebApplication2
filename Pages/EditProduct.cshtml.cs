using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class EditProductModel : PageModel
    {
        [BindProperty]
        public ProductModel Product { get; set; }

        // ✅ GET (load data)
        public void OnGet(int id)
        {
            // TEMP dummy data (replace with DB later)
            Product = new ProductModel
            {
                Id = id,
                ProductName = "Sample Product",
                Price = 100
            };
        }

        // ✅ POST (update data)
        public IActionResult OnPost()
        {
            // TODO: Save to DB

            return RedirectToPage("/ProductListPage");
        }
    }

    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
