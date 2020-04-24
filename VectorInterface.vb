Public Interface VectorInterface(Of T)
    Function size() As Integer
    Function isEmpty() As Boolean
    Function elementAtRank(k As Integer) As T
    Function insertElement(el As T) As DLNode(Of T)
End Interface
