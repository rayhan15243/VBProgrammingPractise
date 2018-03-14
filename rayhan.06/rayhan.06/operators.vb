Module Module1

    Sub Main()
        ' conditional opearators
        ' <> is not equal to

        'Dim isInKingdergarten As Boolean = Nothing
        'Dim canDrink As Boolean = Nothing
        'Dim isSeniorCitizen As Boolean = Nothing
        'Console.WriteLine(" What is your age ?")
        'Dim age As Integer = Console.ReadLine()
        'Dim outComeKindergarten As String = Nothing
        'Dim outComeCitizen As String = Nothing
        'Dim outComeDrink As String = Nothing
        'If age <> 5 Then
        '    isInKingdergarten = False
        '    outComeKindergarten = "You aren't in Kindergarten"
        'Else
        '    isInKingdergarten = True
        '    outComeKindergarten = "You are in Kindergarten"
        'End If
        'If age >= 65 Then
        '    isSeniorCitizen = True
        '    outComeCitizen = " You are a citizen"
        'Else
        '    isSeniorCitizen = False
        '    outComeCitizen = " You aren't a citizen"
        'End If
        'If age >= 21 Then
        '    canDrink = True
        '    outComeDrink = " You can drink "
        'Else
        '    canDrink = False
        '    outComeDrink = " You cannot drink"
        'End If
        'Console.WriteLine(outComeDrink & " " & outComeKindergarten & " " & outComeCitizen)
        'Console.ReadLine()

        ' Logical opeartors 
        ' and && 
        '' or ||

        Dim userName As String = Nothing
        Dim password As String = Nothing

        Console.WriteLine("What is your name ?")
        userName = Console.ReadLine()
        Console.WriteLine(" What is your password ?")
        password = Console.ReadLine()
        If (userName = "Sam" Or userName = "Tim") And password = "thenewboston" Then
            Console.WriteLine(" Hello " & userName)
        Else
            Console.WriteLine("Access not granted")
        End If
        Console.ReadLine()
       
    End Sub

End Module
