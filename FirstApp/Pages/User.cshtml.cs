using FirstApp.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace FirstApp.Pages;

public class UserModel : PageModel
{
    public List<userModel> Users { get; set; }
    public void OnGet()
    {
        Users = UserFilling.GetUserFilling();
    }
}
