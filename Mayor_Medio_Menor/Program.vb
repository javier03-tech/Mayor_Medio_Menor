Module MainModule
    Sub Main()
        ' Datos de entrada
        Console.Write("Ingrese el primer número: ")
        Dim num1 As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        Dim num2 As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el tercer número: ")
        Dim num3 As Integer = Integer.Parse(Console.ReadLine())

        ' Encontrar el mayor, medio y menor
        Dim mayor As Integer = Math.Max(num1, Math.Max(num2, num3))
        Dim menor As Integer = Math.Min(num1, Math.Min(num2, num3))
        Dim medio As Integer = (num1 + num2 + num3) - mayor - menor

        ' Mostrar resultados
        Console.WriteLine("Mayor: " & mayor)
        Console.WriteLine("Medio: " & medio)
        Console.WriteLine("Menor: " & menor)

        ' Datos del desarrollador
        Console.WriteLine("Desarrollado por: Javier Alexander Naranjo Moz, NM0463012022")

        Console.ReadLine() ' Esperar a que el usuario presione Enter
    End Sub
End Module
