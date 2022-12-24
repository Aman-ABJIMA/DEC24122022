using System;
namespace CS_NULL_Basics
{
    class Program
    {


        static void Main()
        {
            
            //here disabling the nullable checking local directive below (simple)*********************************************************
            #nullable disable
            string str = null;
            Console.WriteLine("String:"+str);
            str = "hii";
            Console.WriteLine("String:"+str);

            //creating instance of class (using properties)**************************************************************
            Message message = new Message();
            Console.WriteLine("String 1:"+message.Str1);
            Console.WriteLine("String 2:"+message.Check());

            //set our own custom values (using properties)
            Message message2 = new()
            {
                Str1 = "Hello!!",
                Str2 = null
            };
            Console.WriteLine("String 1: " + message2.Str1);
            Console.WriteLine("String 2: " + message2.Str2);


           //Using the Null-forgiving operator to override the compiler
           // MessgaePop.Pop(message2);
            Console.WriteLine("String 2: Lengths="+message2.Str2.Length); //Null Reference Exception
            Console.WriteLine("String 2:"+message2.Str2);

        }
    }
}