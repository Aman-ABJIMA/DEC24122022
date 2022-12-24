using System;
using System.Reflection;

static class MessgaePop
{
	public static void Pop(Message message2)
	{
		message2.GetType().InvokeMember("Str2",
			BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
			Type.DefaultBinder, message2, new[] { "I am from Pop(set using reflection)" });
	}
	
}
