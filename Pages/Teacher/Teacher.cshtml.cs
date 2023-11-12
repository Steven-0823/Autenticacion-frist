using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Teacher
{
    public class TeacherModel : PageModel
    {
		[Authorize]
		public void OnGet()
        {
        }
    }
}
