Module ej23
    Dim a As Int32
    Dim b As Int32
    Dim c As Int32
    Dim d As Int32
    Dim e As Int32


    Sub main()

        Console.WriteLine("ingrese el primer valor: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el segundo valor: ")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el tercer valor: ")
        c = Console.ReadLine()
        Console.WriteLine("ingrese el cuarto valor: ")
        d = Console.ReadLine()
        Console.WriteLine("ingrese el quinto valor: ")
        e = Console.ReadLine()


        If (a > b And a > c And a > d And a > e) Then
            Console.WriteLine("el primer valor es el mayor")
        ElseIf (b > a And b > c And b > d And b > e) Then
            Console.WriteLine("el segundo valor es el mayor")
        ElseIf (c > a And c > b And c > d And c > e) Then
            Console.WriteLine("el tercer valor es el mayor")
        ElseIf (d > a And d > b And d > c And d > e) Then
            Console.WriteLine("el cuarto valor es el mayor")
        Else
            Console.WriteLine("el quinto valor es el mayor")

        End If
    End Sub
End Module
