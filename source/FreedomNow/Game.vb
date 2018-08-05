Imports System
Imports System.Console
Imports System.IO
Module Game

'Load Classes
Dim GameCore as new GameCore

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
		Console.Title = GameCore.Title
		Console.WriteLine("Welcome to " & GameCore.Title & " version " & GameCore.Ver)
		Console.WriteLine()
		Console.WriteLine("Type 'help' in the game for a list of commads")
		Console.WriteLine()
		Console.WriteLine("Press 'ENTER' to jump into a new world.")
		Dim temp as string = Console.ReadLine()
		If temp.tolower = "debug" then
			Console.WriteLine("Debugging Enabled")
			DebugMenu()
		Else
			LoadVars()
		End If
	End Sub
		
	Private Sub LoadVars()
		Try
			GameCore.GameVars = File.ReadAllLines("Variables.txt")
			GameCore.PlayerInv = File.ReadAllText("Inventory.txt")
			Console.WriteLine(GameCore.Cmd("Play First Intro"))
			Game()
		Catch
			Console.WriteLine(GameCore.Title & " exiting with error number " & Err.Number & " with the description " & Err.Description)
		End Try
	End Sub

	Sub Game()
		While 1
			Console.Write(prompt)
			command = Console.ReadLine()
			Console.WriteLine(GameCore.Cmd(command))
			Game()
		End While
	End Sub
	
	Private Sub DebugMenu()
		Console.Title = GameCore.Title & " - Debugging Mode"
		Console.WriteLine(VbNewLine & "Welcome to the debugger menu")
		Console.WriteLine("Here you can change any public or local vars as you wish!" & VbNewLine)
		Console.Write("Vars: Health(I), Damage(I), Prompt(S), Color(B), PromptColor(CC), TextColor(CC), ")
		Console.WriteLine("OS(S), GameVars(S), PlayerInv(S), LocationNorth(I) LocationWest(I) LocationEast(I) LocationSouth(I)" & VbNewLine)
		Console.WriteLine("Type 'Game()' to jump to the game." & VbNewLine)
		'(I) = Integer	(S) = String	(B) = Boolean	(CC) = ConsoleColor
		Do While True
			Console.Write("debug> ")
			Dim cmd as string = Console.ReadLine
			cmd = cmd.tolower
			If cmd = "game()" then
				Game()
			ElseIf cmd.startswith("set ") = true then
				cmd = cmd.Remove(0, 4)
				Dim temp() as string = Split(cmd, "=")
				Console.WriteLine(SetVar(temp(0), temp(1)))
			ElseIf cmd = "clear" or cmd = "cls" then
				Console.Clear()
			Else
				Console.WriteLine("Unknown Command '" & cmd & "'")
			End if
		Loop
	End Sub
	
	Private Function SetVar(Byval Var as string, Byval Value as String) As String
		Try
			If Var = "health" then
				Health = Value
			ElseIf Var = "damage" then
				Damage = Value
			ElseIf Var = "prompt" then
				Prompt = Value
			ElseIf Var = "color" then
				If Value = "true" then
					Color = True
				ElseIf Value = "false" then
					Color = False
				Else
					Color = Value
				End If
			ElseIf Var = "promptcolor" then
				If Value = "green" then
					PromptColor = ConsoleColor.Green
				ElseIf Value = "blue" then
					PromptColor = ConsoleColor.Blue
				ElseIf Value = "gray" then
					PromptColor = ConsoleColor.Gray
				ElseIf Value = "red" then
					PromptColor = ConsoleColor.Red
				ElseIf Value = "yellow" then
					PromptColor = ConsoleColor.Yellow
				ElseIf Value = "cyan" then
					PromptColor = ConsoleColor.Cyan
				Else
					PromptColor = Value
				End If
			ElseIf Var = "textcolor" then
				If Value = "green" then
					TextColor = ConsoleColor.Green
				ElseIf Value = "blue" then
					TextColor = ConsoleColor.Blue
				ElseIf Value = "gray" then
					TextColor = ConsoleColor.Gray
				ElseIf Value = "red" then
					TextColor = ConsoleColor.Red
				ElseIf Value = "yellow" then
					TextColor = ConsoleColor.Yellow
				ElseIf Value = "cyan" then
					TextColor = ConsoleColor.Cyan
				Else
					TextColor = Value
				End If
			Else
				Return "Error: (0) Var not found."
			End If
		Catch
			Return "Error: (" & Err.Number & ") " & Err.Description
		End Try
		Return Var & " is set to " & Value
	End Function
End Module
