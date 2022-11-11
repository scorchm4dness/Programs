Imports System

Module Program
    Dim choices, size, a, b, c, d, number As Integer
    Sub Main(args As String())
        run()
    End Sub
    Public Sub drawLine()
        Console.WriteLine("Enter the size of the shape. [Odd numbers only and above 3]:")
        number = Convert.ToInt32(Console.ReadLine)
        size = number Mod 2
        If size = 0 Then
            drawLine()
        ElseIf number = 3 Then
            drawLine()
        ElseIf number = 1 Then
            drawLine()
        End If
        Console.WriteLine(" ")
        For b = 1 To number
            Console.Write("*")
        Next
        Console.WriteLine(" ")

        run()
    End Sub
    Public Sub strippedLine()
        Console.WriteLine("Enter the size of the shape. [Odd numbers only and above 3]:")
        number = Convert.ToInt32(Console.ReadLine)
        size = number Mod 2
        If size = 0 Then
            strippedLine()
        ElseIf number = 3 Then
            strippedLine()
        ElseIf number = 1 Then
            strippedLine()
        End If
        Console.WriteLine(" ")
        b = 1
        While b < number
            Console.Write("_")
            Console.Write("*")
            number = number - 2
        End While
        Console.Write("_")
        Console.Write(" ")
        Console.WriteLine(" ")
        run()
    End Sub
    Public Sub drawSquare()
        Console.WriteLine("Enter the size of the shape. [Odd numbers only and above 3]:")
        number = Convert.ToInt32(Console.ReadLine)
        size = number Mod 2
        If size = 0 Then
            drawSquare()
        ElseIf number = 3 Then
            drawSquare()
        ElseIf number = 1 Then
            drawSquare()
        End If
        Console.WriteLine(" ")
        For c = 1 To number
            Console.WriteLine("")
            For b = 1 To number
                Console.Write("*")
            Next
        Next
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        run()
    End Sub
    Public Sub Parallelogram()
        Console.WriteLine("Enter the size of the shape. [Odd numbers only and above 3]:")
        number = Convert.ToInt32(Console.ReadLine)
        size = number Mod 2
        If size = 0 Then
            Parallelogram()
        ElseIf number = 3 Then
            Parallelogram()
        ElseIf number = 1 Then
            Parallelogram()
        End If
        Console.WriteLine(" ")

        For c = number To 1 Step -1

            For b = c To 1 Step -1
                Console.Write("_")
            Next
            For d = 1 To number
                Console.Write("*")
            Next
            For b = c To number Step +1
                Console.Write("_")
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine(" ")
        Console.WriteLine(" ")
        run()
    End Sub
    Public Sub Triangle()

        Console.WriteLine("Enter the size of the shape. [Odd numbers only and above 3]:")
        number = Convert.ToInt32(Console.ReadLine)
        size = number Mod 2
        If size = 0 Then
            Triangle()
        ElseIf number = 3 Then
            Triangle()
        ElseIf number = 1 Then
            Triangle()
        End If
        Console.WriteLine(" ")

        For b = number To 1 Step -1
            For c = b To 1 Step -1
                Console.Write("*")
            Next

            For d = b To number - 1 Step +1
                Console.Write("_")
            Next
            Console.WriteLine("")

        Next
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        run()
    End Sub
    Public Sub reverseTriangle()

        Console.WriteLine("Enter the size of the shape. [Odd numbers only and above 3]:")
        number = Convert.ToInt32(Console.ReadLine)
        size = number Mod 2
        If size = 0 Then
            reverseTriangle()
        ElseIf number = 3 Then
            reverseTriangle()
        ElseIf number = 1 Then
            reverseTriangle()
        End If
        Console.WriteLine(" ")

        For b = number To 1 Step -1
            For a = b To number - 1 Step +1
                Console.Write("*")
            Next
            For c = b To 1 Step -1
                Console.Write("_")
            Next
            Console.WriteLine("")
        Next
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        run()
    End Sub
    Sub run()
        Console.WriteLine("SHAPE DRAWING")
        Console.WriteLine("[1] Draw Line")
        Console.WriteLine("[2] Draw StripedLine")
        Console.WriteLine("[3] Draw Square")
        Console.WriteLine("[4] Draw Parallelogram")
        Console.WriteLine("[5] Draw Triangle")
        Console.WriteLine("[6] Draw Reverse Triangle")
        Console.WriteLine("[0] Exit")
        Console.WriteLine("Enter your choice to draw:")
        choices = Convert.ToInt32(Console.ReadLine)
        Select Case choices
            Case 1
                drawLine()
            Case 2
                strippedLine()
            Case 3
                drawSquare()
            Case 4
                Parallelogram()
            Case 5
                Triangle()
            Case 6
                reverseTriangle()
            Case 0
                End
        End Select
    End Sub

End Module