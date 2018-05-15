Module ej22
    Dim a As Int32
    Dim b As Int32
    Dim c As Int32
    Sub main()

        Console.WriteLine("Ingrese el primer valor: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor: ")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer valor: ")
        c = Console.ReadLine()


        If (a < b And a < c) Then
            Console.WriteLine("El menor valor ingresado es " & a)
        ElseIf (b < a And b < c) Then
            Console.WriteLine("El menor valor ingresado es " & b)
        Else
            Console.WriteLine("El menor valor ingresado es " & c)
        End If




    End Sub



End Module
