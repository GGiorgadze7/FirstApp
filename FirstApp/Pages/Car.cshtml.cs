using System.Security.Cryptography.X509Certificates;
using FirstApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstApp.Pages;

    public class CarPageModel : PageModel
    {

        public List<CarModel> Cars {  get; set; }
        public void OnGet()
        {
            Cars = CarFilling.GetCarFilling();

        }
    }

