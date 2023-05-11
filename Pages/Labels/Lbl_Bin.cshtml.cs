using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_BinModel : PageModel
{
     private readonly ILogger<Lbl_BinModel> _logger;

    public Lbl_BinModel(ILogger<Lbl_BinModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}