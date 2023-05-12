using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LabelPrinter.Models;

namespace CIDM3312_LabelPrinter.Pages;

public class IndexModel : PageModel
{
     [BindProperty]
     [Display(Name ="UserName")]
     [Required]
     public string usrName{get;set;}= string.Empty;

     //[BindProperty]
     //[Display(Name ="Password")]
     public string usrPassword{get;set;}= string.Empty;
     public int clickCount{get;set;} = 1;

    private readonly ILogger<IndexModel> _logger;
    private readonly LabelContext _context;
    public IndexModel(LabelContext context,ILogger<IndexModel> logger)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {

    }
public void OnPost()
    {
        // Check login 
        // if pass redirect to next page
        //var username="";
        //User = _context.Users;
        Response.Redirect("/Labels");
        // if fail error on index
        // _logger.LogWarning($"Name: {usrName} \n EMail: {eMail} \n Message: {message}");
    }

}
