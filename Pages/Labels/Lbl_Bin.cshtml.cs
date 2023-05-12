using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using LabelPrinter.Models;


namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_BinModel : PageModel
{
    private readonly LabelContext _context;
     private readonly ILogger<Lbl_BinModel> _logger;
     public List<Lbl_Bin> Labels {get;set;}=default!;

    public Lbl_BinModel(LabelContext context,ILogger<Lbl_BinModel> logger)
    {
        _logger = logger;        
        _context = context;
    }

    public void OnGet()
    {
        Labels = _context.Lbls_Bin.ToList();
    }
}