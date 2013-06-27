Imports System
Imports System.Console
Module Game

'Load Classes
Dim Commands as new Main

'Player Stats
Dim Health as Integer = Nothing
Dim Damage as Integer = Nothing

'UI Vars
Dim Prompt as string = "> "
Dim Color as Boolean = True
Dim PromptColor as ConsoleColor = ConsoleColor.Cyan
Dim TextColor as ConsoleColor = ConsoleColor.White
Dim command as string = Nothing

	Sub Main()
		Console.WriteLine("Welcome to " & Commands.Title & " version " & Commands.Ver)
		Console.WriteLine()
		Console.WriteLine("Type 'help' for a list of commads")
		Console.WriteLine()
		Console.WriteLine("Press 'ENTER' to jump into a new world.")
		Console.ReadLine()
		LoadVars()
	End Sub
	
		
	Private Sub LoadVars()
		
		Console.WriteLine(Commands.Cmd("Play First Intro"))
		Game()
	End Sub

	
	Sub Game()
		Console.Write(prompt)
		command = Console.ReadLine()
		Console.WriteLine(Commands.Cmd(command))
		Game()
	End Sub
	
End Module