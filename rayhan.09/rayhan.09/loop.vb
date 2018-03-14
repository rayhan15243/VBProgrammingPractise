Module Module1

    Sub Main()
        'for next loop

        'Dim int1 As Integer
        'For int1 = 1 To 50
        '    Console.WriteLine("int1 is equal to: " & int1)
        'Next
        'Console.ReadLine()

        ' step operator 
        'Console.WriteLine("Normal for loop")
        'For num1 = 1 To 20
        '    Console.WriteLine(num1)
        'Next
        'Console.WriteLine()
        'Console.WriteLine("Step by 5")
        'For num1 = 1 To 20 Step 5
        '    Console.WriteLine(num1)
        'Next
        'Console.WriteLine()
        'Console.WriteLine(" strp by -4")
        'For num1 = 20 To 1 Step -4
        '    Console.WriteLine(num1)
        'Next
        'Console.ReadLine()

        ' exiting for loop

        'Console.WriteLine("Normal For Loop")
        'For num1 = 1 To 30 Step 4
        '    Console.WriteLine(num1)
        'Next
        'Console.WriteLine()
        'Console.WriteLine("For loop that exits before it's finished")
        'For num1 = 1 To 30
        '    Console.WriteLine(num1)
        '    If num1 > 23 Then
        '        Exit For
        '    End If
        'Next
        'Console.ReadLine()

        'continue for

        'Console.WriteLine("Normal For Loop")
        'For num1 = 1 To 15
        '    Console.WriteLine(num1)
        'Next
        'Console.WriteLine()
        'Console.WriteLine("Continue Statement")
        'For num1 = 1 To 15
        '    If num1 = 5 Or num1 = 8 Or num1 = 12 Then Continue For

        '    Console.WriteLine(num1)
        'Next
        'Console.ReadLine()

        ' do until loop

        'Dim num1 As Integer = 0
        'Do Until num1 = 10
        '    Console.WriteLine(num1)
        '    num1 += 1
        'Loop
        'Console.ReadLine()

        ' do while loop

        'Dim num1 As Integer = 0
        'Do While num1 <= 15
        '    num1 += 1
        '    Console.WriteLine(num1)
        'Loop
        'Console.ReadLine()

        'Exit do loops

        'Dim num1 As Integer
        ''Do Until num1 = 10
        'Do While num1 <= 10
        '    If num1 > 5 Then Exit Do
        '    Console.WriteLine(num1)
        '    num1 += 2
        'Loop
        'Console.ReadLine()

        'Console.WriteLine("Normal Do Until Loop")
        'Dim num1 As Integer = 0
        'Do Until num1 = 5
        '    num1 += 1
        '    Console.WriteLine(num1)
        'Loop
        'Console.WriteLine()
        'Console.WriteLine("Do until Variant")
        'num1 = 10
        'Do
        '    Console.WriteLine(num1)

        'Loop While num1 < 10
        'Console.ReadLine()

        ' nested loops

        'For num1 = 1 To 10
        '    For num2 = 1 To 10
        '        Console.Write(num2)
        '    Next
        '    Console.WriteLine()
        'Next
        'Console.ReadLine()

        'infinte loop

        Dim num1 As Integer = 10
        Do
            Console.WriteLine("Rayhan")
            'Loop While True
        Loop While num1 > 5
    End Sub


End Module
