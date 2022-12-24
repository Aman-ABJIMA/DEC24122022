using ConsoleGame;
using System;

static class PlayerDisplayer
{
	public static void Write(PlayerCharacter player)
	{
		if(player.Name is null)
		{
			Console.WriteLine("N/A");
			goto here;
		}
		Console.WriteLine(player.Name);

		int days = player.DaysSinceLastLogin ?? -1;
		Console.WriteLine($"last login:{days}");


		if (player.DateOfBirth == null)
		{
			Console.WriteLine("DOB:N/A");
		}
		else
		{
			Console.WriteLine("DOB:" + player.DateOfBirth);
		}
	here:
		Console.WriteLine("");
	}
}
