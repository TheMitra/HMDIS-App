# HMDIS
 How Much Do I Spend
 
 Author note: 
 I am a beginner programmer and still learning. This is a project 
 I've started to keep myself motivated and ongoing. This project 
 will be written in C#.

{SWE} Beskrivning: Ett program där du kan lägga in olika subjekt, 
exempelvis Spel och sedan lägga in hur mycket tid eller 
pengar man spenderat på det. Eventuellt att man kan kategorisera,
att man har en mapp kallad Spel i och sedan olika spel i den så 
man kan få en sammanställning av allihopa. 

{ENG} Description: A program where you can add different things,
for an example Games, and then add how much time or money you have
spent on it. Eventually you can sort different things
in categories. As of having a folder called Games and then 
have different games in it so you can gather all information
at one place. 

Design: The design should be smooth and easy to use. I will use the design editor
that Visual Studio provides: Forms. 
The user should easily navigate between tabs or forms to see their data and edit it. You should be
able to find your data in a List Box that changes data in in with the help of a
Combo Box. The Combo Box should include: All data and also all the categories to switch
between. 

Code plan: 

----------------------------------------Done so far----------------------------------------

+ Create classes: [Category][Subject][Time][Money][Control]

		[Category]
	+ Add variables to Category: A list that holds all the Subjects in the category.

		[Subject]
	+ Add variables to Subject: A Time variable and a Money variable, a string that 
	holds the subject name and another variable which holds a category if any. 
	+ Create constructor for Subject.

		[Time]
	+ Add variables to Time: Integers that holds hours and minutes. 
	+ Create constructor for Time.

		[Money]
	+ Add variables to Money: Integer that holds variable money in SEK. 

- Design form
	+ Add list for Subjects in Categories.
	+ Add dropdpwn box for Categories.
	+ Add "About" button. 
	+ Add "Show" button.
	+ Add display label for "Time".
	+ Add display label for "Selected".
	+ Add display label for "Money".
	+ Add display label for "Category".