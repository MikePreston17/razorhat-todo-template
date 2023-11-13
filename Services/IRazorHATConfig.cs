namespace RazorHat_Template.Services;

public interface IRazorHATConfig
{
    public string GetKey(string key_name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Reads and deserializes a razorhat.json file
    /// </summary>
    /// <param name="filepath"></param>
    /// <returns></returns>
    public T Import<T>(string filepath)
    {
        throw new NotImplementedException();
    }

    public string DummyValue { get; set; } // = "Come Sail Away";
}

public class RazorHATConfig : IRazorHATConfig
{
    public string DummyValue { get; set; } = "Visual Basic sucks!";
}