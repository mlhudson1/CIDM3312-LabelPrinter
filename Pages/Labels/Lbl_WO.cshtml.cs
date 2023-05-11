using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_WOModel : PageModel
{
     private readonly ILogger<Lbl_WOModel> _logger;

    public Lbl_WOModel(ILogger<Lbl_WOModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}