Public Interface VectorInterface(Of T)
    Function size() As Integer
    Function isEmpty() As Boolean
    Function elementAtRank(k As Integer) As DLNode(Of T)
    Function getElementAt(k As Integer) As DLNode(Of T)
End Interface
