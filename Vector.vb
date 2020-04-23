Public Class Vector(Of T)
    Implements VectorInterface(Of T)

    Dim head As DLNode(Of T)
    Dim counter As Integer

    Public Function isEmpty() As Boolean Implements VectorInterface(Of T).isEmpty
        Return (counter = 0)
    End Function

    Public Function elementAtRank(k As Integer) As T Implements VectorInterface(Of T).elementAtRank
        If (isEmpty()) Then
            Console.WriteLine("Vector is Empty. From elementAtRank")
            '            Console.Out.("Vector.elementAtRank() was caled while Vector was empty")
            Throw New Exception("No elements in vector")
        ElseIf (k >= size() Or k < 0) Then
            Console.WriteLine("K is not a valid Index")
            Throw New Exception("Index out of bounds")
        Else
            Dim cursor As New DLNode(Of T)
            cursor = head

            For i As Integer = 0 To k
                cursor = cursor.getNext()
            Next

            Return cursor.getElement()

        End If
        Throw New NotImplementedException()

    End Function

    Public Function insertElementAt(k As Integer, el As T) As DLNode(Of T) Implements VectorInterface(Of T).insertElementAt
        Dim temp As New DLNode(Of T)
        temp.setElement(el)

        If Not (validIndex(k)) Then
            Throw New IndexOutOfRangeException("CkeckIndex detected a invalid index")
        Else
            If (size() = 0) Then
                head = New DLNode(Of T)
                head.setNext(temp)
            Else
                Dim cursor = New DLNode(Of T)
                cursor = head

                For i As Integer = 0 To size() - 1
                    cursor = cursor.getNext()
                Next
                cursor.setNext(temp)
            End If
            counter += 1
        End If

    End Function

    Public Function size() As Integer Implements VectorInterface(Of T).size
        Return counter
    End Function

    Private Function validIndex(k As Integer) As Boolean
        If (k - 1 >= 0) And (k - 1 < size()) Then
            Return True
        Else
            Return False
        End If
    End Function



End Class
