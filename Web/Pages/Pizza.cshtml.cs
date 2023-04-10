using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store;

namespace Web.Pages
{
    public class PizzaModel : PageModel
    {
        public List<Product> products = new List<Product>()
        {
            new Product()
            {
                
            },
            new Product()
            {

            },
            new Product()
            {

            },
            new Product()
            {

            },
            new Product()
            {

            }
        };

        public void OnGet()
        {
        }
    }
}
