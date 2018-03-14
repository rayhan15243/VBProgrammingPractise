Module Module1

    Sub Main()
        ' if statement

        'Console.WriteLine(" What is your name ?")
        'Dim userName As String = Console.ReadLine()
        'Console.WriteLine("What is your password?")
        'Dim password As String = Console.ReadLine()
        'Console.WriteLine()
        'If userName = "Sam" Then
        '    Console.WriteLine("Welcome Sam")
        'End If
        'If password = "thenewboston" Then
        '    Console.WriteLine(" You have entered the correct password ! ")
        'End If
        'Console.ReadLine()

        ' else if and else statement

        'Console.WriteLine("What is your name?")
        'Dim userName As String = Console.ReadLine()
        'Console.WriteLine(" What is your password? ")
        'Dim password As String = Console.ReadLine()
        'If userName = "Sam" Then
        '    Console.WriteLine("Welcome Sam")
        'ElseIf userName = "Tim" Then
        '    Console.WriteLine("Welcome Tim")
        'Else
        '    Console.WriteLine(" You are not a valid user!")
        'End If
        'If password = "thenewboston" Then
        '    Console.WriteLine("Congrats " & userName & " You have been granted access ")
        'End If
        'Console.ReadLine()

        'Nested if statements

        Dim Age As Integer = Nothing
        Dim hasInsurance As Boolean = Nothing
        Console.WriteLine("What is your age? ")
        Age = Console.ReadLine()
        Console.WriteLine("Do you have insurance? true/false")
        hasInsurance = Console.ReadLine()
        If Age = 16 Then
            If hasInsurance = True Then
                Console.WriteLine(" You can drive legally")
            Else
                Console.WriteLine("You can drive... but don't get pulled over or you are screwed")
            End If
        Else
            Console.WriteLine(" You cannot drive ")
        End If
        Console.ReadLine()
    End Sub

End Module
