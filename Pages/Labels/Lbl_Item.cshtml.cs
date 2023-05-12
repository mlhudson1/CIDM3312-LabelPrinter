using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using LabelPrinter.Models;

namespace CIDM3312_LabelPrinter.Pages.Labels;

public class Lbl_ItemModel : PageModel
{
    private readonly LabelContext _context;
    private readonly ILogger<Lbl_ItemModel> _logger;
    public List<Lbl_Item> Labels {get;set;}=default!;
    public Lbl_ItemModel(LabelContext context, ILogger<Lbl_ItemModel> logger)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        Labels = _context.Lbls_Item.ToList();
    }
}