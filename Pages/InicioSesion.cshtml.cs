using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutisDetect.Pages;

public class InicioSesionModel : PageModel
{

    
    private readonly ILogger<InicioSesionModel> _logger;

    public InicioSesionModel(ILogger<InicioSesionModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}