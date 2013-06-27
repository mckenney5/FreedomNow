Imports System

Class GameCore
Public Readonly Title as string = "FreedomNow"
Public Readonly Ver as string = "0.1 Alpha"
Public OS as string = Nothing
Public GameVars() as string 'Loads Game Vairiables
Public PlayerInv as string 'Loads Player's Inventory
Public LocationNorth as integer = 0 'Where you are in the world
Public LocationWest as integer = 0
Public LocationEast as integer = 0
Public LocationSouth as integer = 0
'For Easier Programming
Dim N as integer = LocationNorth
Dim W as integer = LocationWest
Dim E as integer = LocationEast
Dim S as integer = LocationSouth

	Public Function Cmd(ByVal command as string) as string
		command = command.tolower 'makes everything lowercase
		If command = "play first intro" then
			'Return Intro stuff
			Return "You awake with the smell of burning wood and the sound of running animals." & VbNewLine & "You see a note on the ground infront of you."
		
		ElseIf command.startswith("pick up") = true then
			PickUp(command.Remove(0, 8))
			Return "You picked it up."
		
		ElseIf command = "help" then
			'Return help
			Return "Foobar"
		
		ElseIf command = "quit" or command = "exit"
			Environment.Exit(0)
			Return "Foobar"
		
		Else
			Return "What?"
		End If
	End Function
	
	Public Function RandomEvent() As System.Random 'for future use (random events like a theif apearing)
		Dim ran as new Random
		ran.next(0, 10) 'random number between 0 and 10
		Return ran
	End Function
	
	Private Function PickUp(ByVal Item as string) As String
		If Item.StartsWith("#") Then 'stops game from loading comments
			Return "No such item."
		End If
		
		If N = 0 andalso W = 0 andalso E = 0 andalso S = 0 then
			If Item = "note" andalso PlayerInv.Contains(Item) = False then
				Return Add(Item)
			End If
		End If
	End Function
	
	Private Function Add(ByVal Item as string) As Boolean
		Try
			'File.AppendAllText(PlayerInv, Item & VbNewLine)
			Return True
		Catch
			Return False
		End Try
	End Function

	Public Function Remove (startIndex As Integer, count As Integer) As String
		'Usage
		Dim instance As String
		Dim startIndex As Integer
		Dim count As Integer
		Dim returnValue As String
		Return returnValue = instance.Remove(startIndex, count)
	End Function
	
	Public Function SearchForItem(ByVal Item As String) As String
		'Future Use
	End Function
	
	Public Function SyncLocation() As Boolean 'Syncs the location vars
		LocationNorth = N
		LocationWest = W
		LocationEast = E
		LocationSouth = S
		Return True
	End Function
	
	Public Function MovePlayer(ByVal Direction as string) as Boolean 'Moves Playre
		If Direction = "north" then
			N += 1
			S -= 1
		ElseIf Direction = "south" then
			S += 1
			N -= 1
		ElseIf Direction = "west" then
			W += 1
			E -= 1
		ElseIf Direction = "east" then
			E += 1
			W -= 1
		End IF
		SyncLocation()
		Return True
	End Function
End Class