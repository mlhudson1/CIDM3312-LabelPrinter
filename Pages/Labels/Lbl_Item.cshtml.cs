using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_ItemModel : PageModel
{
     private readonly ILogger<Lbl_ItemModel> _logger;

    public Lbl_ItemModel(ILogger<Lbl_ItemModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}