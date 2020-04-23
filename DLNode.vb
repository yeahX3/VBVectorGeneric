Public Class DLNode(Of T)
    Public element As T
    Public nextNode As DLNode(Of T)
    Public previousNode As DLNode(Of T)

    Public Sub setElement(ByRef el As T)
        element = el
    End Sub

    Public Function getElement() As T
        Return element
    End Function


    Public Function setNext(nex As DLNode(Of T))
        nextNode = nex
    End Function

    Public Function getNext() As DLNode(Of T)
        Return nextNode
    End Function

    Public Function setPrev(pre As DLNode(Of T))
        previousNode = pre
    End Function

    Public Function getPrev() As DLNode(Of T)
        Return previousNode
    End Function

End Class