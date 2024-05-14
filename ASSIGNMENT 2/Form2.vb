Imports System.IO
Public Class Frmsearch
    Dim r As StreamReader

    Private Sub Bn3_Click(sender As Object, e As EventArgs) Handles Bn3.Click
        LISTBOX1.Items.Clear()
        r = New IO.StreamReader("D:\Sem2\New folder (2)\ASSIGNMENT 2\data.txt")
        While (r.Peek > -1)
            LISTBOX1.Items.Add(r.ReadLine)

        End While

        r.Close()


    End Sub



    Private Sub Bn5_Click(sender As Object, e As EventArgs) Handles Bn5.Click
        Dim target As String = LISTBOX1.Text 'change this to the string you want to search from
        'perform the linear search and display the resut
        Dim index As Integer = linearsearch(target)
        If index >= 0 Then
            'item found, do something with it
            MessageBox.Show("item found using linear search at : " & index)
        Else
            MessageBox.Show("item not found using linear search")

        End If


    End Sub


    Public Function linearsearch(ByVal target As String) As Integer
        For i As Integer = 0 To LISTBOX1.Items.Count - 1
            If LISTBOX1.Items(i) = target Then
                'item found, return to index
                Return i
            End If
        Next
        'item not found
        Return -1
    End Function
    Public Sub binarysearch(ByVal target As String)
        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = LISTBOX1.Items.Count - 1

        While lowerbound <= upperbound
            Dim middle As Integer = (lowerbound + upperbound) \ 2
            Dim currentitem As String = LISTBOX1.Items(middle)
            If currentitem = target Then
                'item found, do something with it
                MessageBox.Show("item found using binary search : " & currentitem)
                Exit Sub
            ElseIf currentitem < target Then
                lowerbound = middle + 1
            Else upperbound = middle - 1
            End If

        End While
        'item not found
        MessageBox.Show("item not found : " & target)
    End Sub

    Private Sub Frmsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LISTBOX1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTBOX1.SelectedIndexChanged

    End Sub

    Private Sub Bn6_Click(sender As Object, e As EventArgs) Handles Bn6.Click
        Dim data As List(Of String) = LISTBOX1.Items.Cast(Of String)().ToList()
        data.Sort()
        LISTBOX1.Items.Clear()
        LISTBOX1.Items.AddRange(data.ToArray())
        binarysearch(LISTBOX1.Text)

    End Sub
End Class