using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleGame
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter[] players =
              {
                      new PlayerCharacter { Name = "AMAN"},
                      new PlayerCharacter { Name = "KULDEEP"},
                      new PlayerCharacter { Name = "ISHANSHI"},
                    //null   //Excepsion 
              };



              PlayerDisplayer.Write(players[0]);
              PlayerDisplayer.Write(players[1]);
              PlayerDisplayer.Write(players[2]);
            //PlayerDisplayer.Write(players[3]);
        /********************************************************/

            string badWay = "Name-Aman";
            string goodWay = "Name:Aman";
            if (PlayerCharacter.TryParse(badWay,out var p1))
            {
                Console.WriteLine(p1.Name);
            }
            else
            {
                Console.WriteLine("Could not parse " + badWay);
            }

            if(PlayerCharacter.TryParse(goodWay,out var p2))
            {
                Console.WriteLine("Good Parse:"+p2.Name);
            }

            Console.WriteLine("pls Enter a name:");
            string? name = Console.ReadLine();
            if(name is null)
            {
                LogAndExit("Null name was input");
            }
            Console.WriteLine("Length:"+name.Length);//warning-10

/*****************************************************************************************/

                    PlayerCharacter p3 = new();
                    p3.Naam = null;//here it will give warning! To avoid warning,we use [AllowNull] Attribute
                    p3.Bio = null; //After Declaring nullable,it is still showing warning because of the using of [DisallowNull] Attribute

                    Console.WriteLine("Pls Enter Bio:");
                    string? bio = Console.ReadLine();

                    ExitProgramIfNull(bio,"bio information");
                    p3.Bio = bio;        

                }

                static void ExitProgramIfNull([NotNull]string? input,string inputDesp)
                {
                    if(input is null)
                    {
                        Console.WriteLine($"{inputDesp} was Null, Exiting Program.");
                        Environment.Exit(-1);
                    }
              
       
         
        
                }

        [DoesNotReturn]//avoid warning-10
        static void LogAndExit(string logMessage)
        {
            Console.WriteLine(logMessage);
            Environment.Exit(0);
        }
    }
}