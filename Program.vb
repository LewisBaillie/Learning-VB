Imports System

Module Program
    Public Num1 As Integer
    Public Num2 As Integer
    Public Answer As Integer

    Sub Main(args As String())
        Console.Write("Please enter your name: ")
        Dim name = Console.ReadLine()
        Dim selection As Integer
        Console.WriteLine($"Hello {name}, Would you like the date and time or to add 2 numbers? (1 for D/T, 2 for Addition)")
        selection = Console.ReadLine()

        If selection = 1 Then
            Dim currentDate = DateTime.Now
            Console.WriteLine($"{name}, it is currently {currentDate:d} at {currentDate:t}")
            Console.Write("Press any key to continue...")
        ElseIf selection = 2 Then
            Console.WriteLine("Please input your first number: ")
            Num1 = Console.ReadLine()
            Console.WriteLine("Please input your second number: ")
            Num2 = Console.ReadLine()

            Answer = Num1 + Num2

            Console.WriteLine($"{name}, the sum of those two numbers is: {Answer}")
            Console.Write("Press any key to continue...")
        End If

        Console.ReadKey(True)
    End Sub
End Module