Module MainModule

    Public Sub Main()
        Dim myVector As New Vector(Of Integer)

        myVector.insertElement(0)
        myVector.insertElement(1)
        myVector.insertElement(2)
        myVector.insertElement(3)

        Console.Out.WriteLine("showing the number 2: " & myVector.elementAtRank(2))

        Console.ReadLine()

    End Sub

End Module
