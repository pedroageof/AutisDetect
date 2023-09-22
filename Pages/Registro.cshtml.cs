using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutisDetect.Pages;

public class RegistroModel : PageModel
{
    private readonly ILogger<RegistroModel> _logger;

    public RegistroModel(ILogger<RegistroModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}