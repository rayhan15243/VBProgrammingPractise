Module Module1

    Sub Main()
        Dim userName As String = Nothing
        Dim userAge As Integer = Nothing
        Dim userSalary As Double = Nothing

        Console.WriteLine(" What is your name? ")
        userName = Console.ReadLine()
        Console.WriteLine(" What is your age? ")
        userAge = Console.ReadLine()
        Console.WriteLine(" What is your salary? ")
        userSalary = Console.ReadLine()
        Console.WriteLine()
        Console.Write(" Your name is: " & userName)
        Console.Write("  Your age is:  " & userAge)
        Console.Write("   Your salary  is:   " & userSalary)
        Console.WriteLine()
        Console.ReadLine()
    End Sub

End Module
