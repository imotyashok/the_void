using System;
using System.Threading;

class TheVoid
{
	public static void descentIntoHell(){
		var chars = "\n\n\nA B C D E F G H I J K L M N O P Q R S T U V W 	"+
					"X Y Z 		abcdefghijklmnopqrstuvwxyz 0123456789 		"+
					"!@#$%^&*()-_=+	 	 	        		  	/?><,.";
		var stringChars = new char[100];
		var random = new Random();
		
		while (true){
			for (int i = 0; i < stringChars.Length; i++)
			{
			    stringChars[i] = chars[random.Next(chars.Length)];
			}
			var finalString = new String(stringChars);
			Console.WriteLine(finalString);
			Thread.Sleep(50);
		}
	}
	
	public static void enterVoid(){
		Console.WriteLine(">>> Approaching the void...");
		Thread.Sleep(1500);
		Console.WriteLine(">>> Entering the void....");
		Thread.Sleep(1500);
		Console.WriteLine("Uh oh! You have been consumed by the vo-");
		Thread.Sleep(1000);
		descentIntoHell();
	}
	
	
	public static void Main(string[] args)
	{
		string choice = null;
		Console.WriteLine("Do you wish to enter the void? (y/n)");
		choice = Console.ReadLine();
		switch(choice){
			case "y":
				enterVoid();
				break;
			default:
				while (choice != "y"){
					Console.WriteLine("Wrong choice. Try again.");
					choice = Console.ReadLine();
					if (choice == "y"){
						enterVoid();
					}
				}
				break;
		}
	}
}

