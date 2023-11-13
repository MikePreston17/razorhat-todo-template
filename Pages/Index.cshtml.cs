using CodeMechanic.Embeds;
using CodeMechanic.Extensions;
using CodeMechanic.RazorPages;
using Microsoft.AspNetCore.Mvc;
using RazorHat_Template;

namespace RazorHAT_Template.Pages;

[BindProperties]
public class IndexModel : HighSpeedPageModel
{
    private readonly ILogger<IndexModel> _logger;

    public ContactEmail UserContact { get; set; } = new ContactEmail();

    public IndexModel(
        IEmbeddedResourceQuery embeddedResourceQuery
        , ICommentService commentService
    )
        : base(embeddedResourceQuery)
    {
    }

    public async Task OnGet()
    {
    }


    public async Task<IActionResult> OnPostContactMe()
    {
        // TODO: finish the implementation!
        // var emailer = new MassEmailer();

        UserContact.Dump("user added as a contact!");

        return Partial("Success", new AlertModel()
        {
            Title = "Success!",
            Text = "The email was sent without a hitch!"
        });
    }
}