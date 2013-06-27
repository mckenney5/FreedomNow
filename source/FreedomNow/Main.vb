Imports System
Imports System.IO
Imports System.Reflection
Imports System.Resources
Class Main
Public Readonly Title as string = "FreedomNow"
Public Readonly Ver as string = "0.1 Alpha"
Public OS as string = Nothing
'Dim Nigg as Stream = Assembly.GetExecutingAssembly.GetMainifestResourceStream("FreedomNow.Variables.txt")
'Dim oStream As System.IO.Stream
'Dim oAssembly As System.Reflection.Assembly = Me.GetType.Assembly.GetEntryAssembly()
'Dim my_namespace As String = oAssembly.GetName().Name.ToString()
'Public GameVars() as string = File.ReadAllLines("Variables.txt") 'Loads Game Vairiables
'Public PlayerInv as string = File.ReadAllText("Inventory.txt") 'Loads Player's Inventory
Public LocationNorth as integer = 0 'Where you are in the world
Public LocationWest as integer = 0
Public LocationEast as integer = 0
Public LocationSouth as integer = 0
'For Easier Programming
Dim N as integer = LocationNorth 'FIXME
Dim W as integer = LocationWest
Dim E as integer = LocationEast
Dim S as integer = LocationSouth

	Public Function Cmd(ByVal command as string) as string
		command = command.tolower 'makes everything lowercase
		return SearchForItem(command)
		If command = "play first intro"then
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
	
	Public Function RandomEvent() As System.Random 'for future use
		Dim ran as new Random
		ran.next(0, 10)
		Return ran
	End Function
	
	Private Function PickUp(ByVal Item as string) As String
		If Item.StartsWith("#") Then
			Return "No such item."
		End If
		
		If N = 0 andalso W = 0 andalso E = 0 andalso S = 0 then
			If Item = "note" andalso PlayerInv.Contains(Item) = False then
				Return Add(Item)
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
	'Declaration
	Public Function Remove (startIndex As Integer, count As Integer) As String
		'Usage
		Dim instance As String
		Dim startIndex As Integer
		Dim count As Integer
		Dim returnValue As String
		Return returnValue = instance.Remove(startIndex, count)
	End Function
	
	Public Function SearchForItem(ByVal Item As String) As String
	    GetInv("FreedomNow.Variables.txt")
	End Function
End Class