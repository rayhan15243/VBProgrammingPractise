Module Module1

    Sub Main()
        'This line writes the text hello world to the console 
        'Console.WriteLine("Hello World!")
        ' This line pauses 
        'Console.ReadLine()

        ' Variable declaration 

        'Dim myNum As Integer = 5
        ' myNum = 5
        'Console.WriteLine(myNum)
        'Console.ReadLine()

        'Dim myString As String = "hello the new boston fans"
        'Console.WriteLine(myString)
        'Console.ReadLine()

        'Dim myChar As Char = "a"
        'Console.WriteLine(myChar)
        'Console.ReadLine()

        'Dim myDouble As Double = 5.3433
        'Console.WriteLine(myDouble)
        'Console.ReadLine()

        'Dim myBol As Boolean = True
        'Console.WriteLine(myBol)
        'Console.ReadLine()

        'Dim myNum As Integer = 5
        'Console.WriteLine(myNum.ToString())
        'Console.ReadLine()




        'Declare variables
        Dim num1, num2, result, selection As Integer

        'Input
        Console.WriteLine("**************")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Subtraction")
        Console.WriteLine("3. Multiplication")
        Console.WriteLine("4. Division")
        Console.WriteLine("5. Exit")
        Console.WriteLine()
        Console.WriteLine("Choose a menu item by number")
        selection = Console.ReadLine()
        Console.WriteLine("Please enter the first number")
        num1 = Console.ReadLine()
        Console.WriteLine("Please enter the second number")
        num2 = Console.ReadLine()

        If selection = 1 Then
            result = num1 + num2
            Console.WriteLine("The sum of num1 and num2 is: " & result)
        ElseIf selection = 2 Then
            result = num1 - num2
            Console.WriteLine("Num1 subtract num2 is: " & result)
        ElseIf selection = 3 Then
            result = num1 * num2
            Console.WriteLine("The product of num1 and num2 is: " & result)
        ElseIf selection = 4 Then
            result = num1 / num2
            Console.WriteLine("Num1 divided by num2 is: " & result)
        Else
            Console.ReadLine()
        End If






        Console.Readline()



    End Sub

End Module
