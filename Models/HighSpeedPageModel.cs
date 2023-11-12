using CodeMechanic.Embeds;
using CodeMechanic.Types;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeMechanic.RazorPages;

///<summary>
///Airtable https://github.com/ngocnicholas/airtable.net/wiki/Documentation
///</summary>
public abstract class HighSpeedPageModel : PageModel //, IQueryNeo4j, IQueryAirtable
{
    protected readonly IEmbeddedResourceQuery embeddedResourceQuery;
    public bool DebugMode;

    protected HighSpeedPageModel(
        IEmbeddedResourceQuery embeddedResourceQuery
    )
    {
        this.embeddedResourceQuery = embeddedResourceQuery;
        DebugMode = Environment.GetEnvironmentVariable("DEBUG_MODE").ToBoolean();

        if (DebugMode)
        {
            // do something custom here ...
            Console.WriteLine("Debug Mode? " + (DebugMode ? "Debug Mode on!" : "Debug Mode Off!"));
        }
    }
}