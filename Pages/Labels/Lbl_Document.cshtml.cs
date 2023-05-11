using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_DocumentModel : PageModel
{
     private readonly ILogger<Lbl_DocumentModel> _logger;

    public Lbl_DocumentModel(ILogger<Lbl_DocumentModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}