using System.Text;
using CodeMechanic.Advanced.Regex;
using CodeMechanic.Embeds;
using CodeMechanic.RazorPages;
using CodeMechanic.Types;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver;
using Newtonsoft.Json;

namespace RazorHAT_Template.Pages;

public class IndexModel : HighSpeedPageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(
        IEmbeddedResourceQuery embeddedResourceQuery
    )
        : base(embeddedResourceQuery)
    {
    }

    public async Task OnGet()
    {
    }
}