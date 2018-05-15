Module ej21


    Sub Main()
        Dim a As Int32
        Dim b As Int32

        Console.WriteLine("ingrese el primer valor: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor: ")
        b = Console.ReadLine()


        If (a = b) Then
            Console.WriteLine("Los numeros ingresados son iguales.")

        ElseIf (a > b) Then

            Console.WriteLine("El numero " & a & " es mayor al numero " & b)


        Else
            Console.WriteLine("El numero " & a & " es menor al numero " & b)

        End If
    End Sub

End Module
