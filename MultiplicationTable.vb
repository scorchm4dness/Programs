'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      Dim number, termination, product, i As Integer
      Dim goOn As String = "Y"
      While goOn = "Y"
      
      Console.Write("Input a number: ")
      number = Convert.ToInt32(Console.ReadLine)
      
      Console.Write("Input termination number: ")
      termination = Convert.ToInt32(Console.ReadLine)

      For i = 1 To termination
      product = number * i
     
      Console.WriteLine(number & " * " & i & " = " & product)
      
      Next 
        Console.Write("Do you want to input another number? [Y/N]: ")     
        goOn = console.readline.ToUpper
      
      End While
        Console.WriteLine("Thank you!")
        Console.ReadKey()
    End Sub
  End Module
End Namespace