'Xavier Hoskins
'RCET 0265
'Fall 2022
'Fortune Cookie
'https://www.github.com/hoskxavi/FortuneCookie

Option Explicit On
Option Strict On
Imports System

Module Fortune
    Sub Main()

        Dim fortune As Integer

        Console.Write("Welcome to your fortune cookie! Press enter to recieve a fortune:")
        Console.ReadLine()
        fortune = RandomNumber() 'call the RNG funtion to generate a random number

        'Case select to choose the fortune based on the RNG value
        Select Case fortune
            Case 1
                Console.WriteLine("To truly find yourself, you should play hide and seek alone.")
            Case 2
                Console.WriteLine("Success lies in the hands of those who want it.")
            Case 3
                Console.WriteLine("The early bird gets the worm, but the second mouse gets the cheese.")
            Case 4
                Console.WriteLine("Here is my wisdom: If the ball is too big for your mouth, it's not yours.")
        End Select

    End Sub

    Function RandomNumber() As Integer 'funcion to generate a random number from 1 to 4
        Randomize()
        Dim number As Integer = CInt(Int((4 * Rnd()) + 1))
        Return (number)
    End Function

End Module
