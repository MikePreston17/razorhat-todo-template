using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Neo4j.Driver;

using CodeMechanic.Extensions;

using CodeMechanic.RazorHAT;
namespace TPOT_Links.Pages.Sandbox;

public class IndexModel : HighSpeedPageModel
{

    private static int count = 0;

    public IndexModel(
        IEmbeddedResourceQuery embeddedResourceQuery
        , IDriver driver) 
    : base(embeddedResourceQuery, driver)
    {
    }

    public void OnGet()
    {
        // reset on refresh
        count = 0;
    }

    public IActionResult OnPostIncrement()
    {
        Console.WriteLine("Post!");
        return Content($"<span>{++count}</span>", "text/html");
    }

    public IActionResult OnGetStuff()
    {
        return Content($"<b>Stuff for u!<br/> One lump, or 2?</b>");
    }

    public async Task<IActionResult> OnGetRecommendations()
    {
        var failure = Content(
            $"<div class='alert alert-error'><p class='text-xl text-warning text-sh'>An Error Occurred...  But fret not! Our team of intelligent lab mice are on the job!</p></div>");

        string query = "...";

        // Magically infers that the current method name is referring to 'Recommendations.cypher'
        string resource = new StackTrace().GetCurrentResourcePath().Dump("resource path");
        if(embeddedResourceQuery == null) 
            return failure;

        // Reads from file system...
        await using Stream stream = embeddedResourceQuery.Read<IndexModel>(resource);

        // Reads the any file I tell it to as a query.
        query = await stream.ReadAllLinesFromStreamAsync();
        query.Dump("Query");

        // var records = await SearchNeo4J(query, new {});

        // return Partial("_RecordsTable", records);
        
        /// This can also be a template
        return Content(
            $"<div class='alert alert-primary'><p class='text-xl text-secondary text-sh'>{query}</p></div>");

    }

}


