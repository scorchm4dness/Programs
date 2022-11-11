'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
    Dim summation, sum As Integer
    Dim s As Integer = 1
    Console.Write("Enter a number: ")
    summation = Console.ReadLine()
    
    Console.WriteLine("The summation of {0} is: ", summation)
    While s < summation
    Console.Write(s & " + ")
    sum += s
    s += 1
    End While
    
    Console.Write("{0}", summation)
    sum = sum + summation
      
    Console.WriteLine(" = {0}", sum)
    Console.ReadKey()  
      End Sub
  End Module
End Namespace