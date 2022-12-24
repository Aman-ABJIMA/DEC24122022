using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleGame
{
    class PlayerCharacter
    {
        //Pre condition attribute:**********************************************************************************************************

        private string _name = GenerateName();


        [AllowNull]  //Allow Null Attribute
        public string Name
        {
            get => _name;
            set => _name = value ?? GenerateName();
        }
        private static string GenerateName()
        {
            var names = new string[] { "AMAN", "KULDEEP", "ISHANSHI" };
            var random = new Random();
            return names[random.Next(0, 3)];
        }

        private string? _bio;

        [DisallowNull]    //dis-allow null attribute
        public string? Bio
        {
            get => _bio;
            set => _bio = value ?? throw new ArgumentNullException(nameof(value));
        }
//***********************************************************************************************************************************************





        public string? Naam { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public static bool TryParse(string input,[NotNullWhen(true)] out PlayerCharacter? player)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                player = null;
                return false;

            }
            if(!input.StartsWith("Name:"))
            {
                player = null;
                return false;
            }
            string parsedName = input.Split(':')[1];
            player = new PlayerCharacter { Name = parsedName };
            return true;
        }

        
    }
}