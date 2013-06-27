Imports System
Imports System.IO
Module Test
  Sub Main
	Try
  	Dim Knife as string = "<Name> Knife <Damage> 2 <Desc> A pointy metal tool."
	Dim Note as string = "<Name> Note <Say> Welcome to Quite Tiny Text Commands! <Desc> A paper with writing on it."
	Dim LockedBox as string = "<Name> LockedBox <Unlock> EvilKey <Desc> A magic locked box."
	Dim UnlockedBox as string = "<Name> UnlockedBox <Open> Magicball <Desc> An open box with a round object inside."
	Dim MagicBall as string = "<Name> MagicBall <Desc> A magic ball, I think this is important."
	Dim EvilKey as string = "<Name> EvilKey <Desc> This must open something magical."
	Dim Sword as string = "<Name> Sword <Damage> 4 <Desc> Oh they are in for it now!"
	Dim ChainMail as string = "<Name> ChainMail <Def> 2 <Desc> Metal chain that can protect you."
	Dim Match as string = "<Name> Match<Light> 1 <Desc> Allows you to see in the dark. You only have one."
	Dim Hands as string = "<Name> Hands <Damage> 1 <Desc> Your dirty hands."
	Dim MagicWand as string = "<Name> MagicWand <Damage> -1 <Desc> You found it; the wand to rule them all."
	Dim HealthPotion as string = "<Name> HealthPotion <Heals> 4 <Desc> Red liquid that heals you."
	Dim Gems as string = "<Name> Gems <Desc> Assorted gems"
	Dim Key1 as string = "<Name> Key1 <Desc> Opens something locked; maybe a door."
	Dim Key2 as string = "<Name> Key2 <Desc> Opens some locked door."
	Dim Key3 as string = "<Name> Key3 <Desc> Opens a locked door."
	Dim Key4 as string = "<Name> Key4 <Desc> A key that has 'TRAP' engraved on it."
	Dim Rope as string = "<Name> Rope <Desc> Used to climb."
	Dim GnuHorn as string = "<Name> GnuHorn <Desc> A horn of the holy animal. I bet you spit on puppies too."
	Dim Book1 as string = "<Name> Book1 <Say> S.I.C.P. <Desc> A book with a Geany and a lady on it"
	Dim Book2 as string = "<Name> Book2 <Say> A 'covered work' means either the unmodified Program or a work based on the Program. <Desc> Titled GNU GPL"
	'Writing to File
	File.AppendAllText("Variables.txt", "#Items" & VbNewLine & Knife & VbNewLine & Note & VbNewLine & LockedBox & VbNewLine & UnlockedBox & VbNewLine & MagicBall & VbNewLine & EvilKey & VbNewLine & Sword & VbNewLine & ChainMail & VbNewLine)
	File.AppendAllText("Variables.txt", Match & VbNewLine & Hands & VbNewLine & MagicWand & VbNewLine & HealthPotion & VbNewLine & Gems & VbNewLine & Key1 & VbNewLine & Key3 & VbNewLine & Key4  & VbNewLine & Rope & VbNewLine & GnuHorn & VbNewLine & Book1 & VbNewLine & Book2 & VbNewLine & VbNewLine)
	Dim LockedDoor1 as string = "<Name> LockedDoor1 <key> 1 <Desc> This door seems to be locked."
	Dim LockedDoor2 as string = "<Name> LockedDoor2 <key> 2 <Desc> This door seems to be locked."
	Dim LockedDoor3 as string = "<Name> LockedDoor3 <key> 3 <Desc> This door seems to be locked."
	Dim OpenWindow as string = "<Name> OpenWindow <Action> Enter <Desc> An open window."
	Dim Window as string = "<Name> Window <Desc> A boarded up window."
	Dim Door as string = "<Name> Door <Action> Enter <Desc> An unlocked door."
	Dim TrapDoor as string = "<Name> TrapDoor <Action> Enter <Desc> An unlocked trap door."
	Dim LockedTrapDoor as string = "<Name> LockedTrapDoor <key> 4 <Desc> A locked trap door."
	Dim Skull as string = "<Name> Skull <Desc> Eww, I am not touching that!"
	Dim Skeleton as string = "<Name> Skeleton <Desc> He looks hungry."
	Dim Rocks as string = "<Name> Rocks <Desc> Some rocks. The look too heavy to pick up."
	Dim Ash as string = "<Name> Ash <Desc> Some smelly black powder."
	File.AppendAllText("Variables.txt", "#Objects" & VbNewLine & LockedDoor1 & VbNewLine & LockedDoor2 & VbNewLine & LockedDoor3 & VbNewLine & OpenWindow & VbNewLine & Window & VbNewLine & Door & VbNewLine & TrapDoor & VbNewLine & LockedTrapDoor & VbNewLine & Skull & VbNewLine & Skeleton & VbNewLine & Rocks & VbNewLine & Ash & VbNewLine & VbNewLine)
	Dim Theif as string = "<Name> Theif <Attack> 2 <Health> 4 <Desc> A man with a black mask and a hunger for valuables."
	Dim Goblin as string = "<Name> Goblin <Attack> 1 <Health> 2 <Desc> A little green man."
	Dim Guard as string = "<Name> Guard <Attack> 3 <Health> 6 <Desc> A big person in heavy armor."
	Dim Boss as string = "<Name> Boss <Attack> 3 <Health> 12 <Desc> A huge man with gray hair and circular glasses. I'd run if I were you..."
	Dim Rat as string = "<Name> Rat <Attack> 0.5 <Health> 1 <Desc> An over grown sick grey rat."
	Dim Beast as string = "<Name> Beast <Attack> 3 <Health> 1 <Desc> A crazy dog-like animal."
	File.AppendAllText("Variables.txt", "#NPC" & VbNewLine & "#Enemy" & VbNewLine & Theif & VbNewLine & Goblin & VbNewLine & Guard & VbNewLine & Boss & VbNewLine & Rat & VbNewLine & Beast & VbNewLine & VbNewLine)
	Dim Gnu as string = "<Name> Gnu <Attack> -1 <Health> 100 <Desc> A beautiful and worshiped animal."
	Dim Fox as string = "<Name> Fox <Attack> 2 <Health> 1 <Desc> A small orange animal."
	Dim SleepingGuard as string = "<Name> SleepingGuard <Attack> 3 <Health> 6 <Desc> A big sleeping person in heavy armor."
	Dim Savage as string = "<Name> Savage <Attack> 1 <Health> 1 <Desc> A sickly man."
	File.AppendAllText("Variables.txt", "#Peaceful" & VbNewLine & Gnu & VbNewLine & Fox & VbNewLine & SleepingGuard & VbNewLine & Savage & VbNewLine & VbNewLine)
	Dim WiseMan as string = "<Name> WiseMan <Say> They say that evil is the key to locked magic. <Desc> A tall man with a long white beard and a blue robe with haskell writing on it."
	Dim Dog as string = "<Name> Dog <Say> Woof Woof Woof! <Desc> Who let the dogs out?"
	Dim Monk as string = "<Name> Monk <Say> Praise all that is free, all that is RMS! <Desc> A bald man with a neck beard with what seems to be the letters FSF on his head."
	Dim Trader as string = "<Name> Trader <Say> I have what you seek; just show me the gems first. <Desc> A small man in a white tunic."
	Dim MeditatingMan as string = "<Name> MeditatingMan <Say> Tule takaisin minulle Tux. Linus kaipaa sinua. <Desc> An odd man with circlular glasses."
	Dim DennisTheGhost as string = "<Name> DennisTheGhost <Say> Noooooo one remembers meeee! They all cry for steveee. <Desc> An old man with a grey goatie."
	Dim RMS as string = "<Name> RMS <Say> Thank you. You have stoped the evil and freed the people. <Desc> A slightly large looking hippy."
	File.AppendAllText("Variables.txt", "#Friends" & VbNewLine & WiseMan & VbNewLine & Dog & VbNewLine & Monk & VbNewLine & Trader & VbNewLine & MeditatingMan & VbNewLine & DennisTheGhost & VbNewLine & RMS & VbNewLine & VbNewLine)
	Dim Player as string = "<Name> Player <Attack> 1 <Health> 5"
	File.AppendAllText("Variables.txt", "#Player" & VbNewLine & Player & VbNewLine)
	File.AppendAllText("Inventory.txt", "#Player Inventory" & VbNewLine)
	Console.WriteLine("Files created.")
	Catch
	Console.WriteLine("Error (" & Err.Number & ") " & Err.Description)
	End Try
  End Sub
End Module
