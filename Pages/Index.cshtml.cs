using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

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

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
public void OnPost()
    {
        // Check login 
        // if pass redirect to next page
        Response.Redirect("/Labels");
        // if fail error on index
        // _logger.LogWarning($"Name: {usrName} \n EMail: {eMail} \n Message: {message}");
    }

}
