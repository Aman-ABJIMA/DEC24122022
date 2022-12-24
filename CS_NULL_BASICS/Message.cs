using System;
public class Message
{
    //Properties
    public string Str1 { get; set; }
    public string Str2 { get; set; }

    //Constructor
    public Message(string xyz = "hii", string abc = "hello")
    {
        Str1 = xyz.ToUpperInvariant();
        Str2 = abc;
    }

    //Method
    public string Check()        //this method returns Str2 in uppercase!!!
    {
        if (Str2 is null)
        {
            return "";
        }
        else
        {
            return Str2.ToUpperInvariant();
        }
    }
}
