using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class LabelsModel : PageModel
{
     private readonly ILogger<LabelsModel> _logger;

    public LabelsModel(ILogger<LabelsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}