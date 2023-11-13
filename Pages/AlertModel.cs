namespace RazorHAT_Template.Pages;

/// <summary>
/// TODO: Use this as a model for rendering a Daisy alert or a toast message that indicates success
/// </summary>
public record AlertModel
{
    public string Title { get; set; } = "Success!";
    public string Status { get; set; } = "Success";
    public string Text { get; set; } = string.Empty;
}