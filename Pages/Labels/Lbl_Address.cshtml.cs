using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_AddressModel : PageModel
{
     private readonly ILogger<Lbl_AddressModel> _logger;

    public Lbl_AddressModel(ILogger<Lbl_AddressModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}