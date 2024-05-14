Public Class Frmsort

    Dim randomnumbers(6) As Integer

    Private Sub Bn7_Click(sender As Object, e As EventArgs) Handles Bn7.Click
        ' Generate 7 random numbers between 1 to 100 (modift min and max max as needed)
        For i = 0 To 6
            randomnumbers(i) = CInt(Rnd() * 100) + 1 ' scale and offset for range 1 to 100


        Next
        'clear listbox before displaying new data
        ListBox1.Items.Clear()

        'display unsorted numbers
        ListBox1.Items.Add("unsorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomnumbers(i).ToString())


        Next
        'Bubble sort logic
        Dim swapped As Boolean = True 'flag to track if any swaps occurred
        'loop through the array for multipple passes
        Do While swapped
            swapped = False 'reset flag for each pass
            'compare adjacent elements and swap if needed
            For i = 0 To UBound(randomnumbers) - 1
                If randomnumbers(i) > randomnumbers(i + 1) Then
                    'swap elements directly (no function needed)
                    Dim temp As Integer = randomnumbers(i)
                    randomnumbers(i) = randomnumbers(i + 1)
                    randomnumbers(i + 1) = temp
                    swapped = True 'set flag if a swap happened


                End If
            Next
        Loop


        'display unsorted numbers
        ListBox1.Items.Add("")
        ListBox1.Items.Add("sorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomnumbers(i).ToString())
        Next
    End Sub

    Private Sub Bn8_Click(sender As Object, e As EventArgs) Handles Bn8.Click
        ListBox1.Items.Clear()
        'generate random numbers
        For i = 0 To 6
            randomnumbers(i) = CInt(Rnd() * 100) + 1 'scaleand offset for range 1 to 100

        Next
        'clear listbox before displaying new data
        ListBox1.Items.Add("unsorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomnumbers(i).ToString())
        Next

        'insertion sort logic 
        For i = 0 To 6 ' start from the second element ( index 1 )
            Dim key As Integer = randomnumbers(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumbers(j) > key
                randomnumbers(j + 1) = randomnumbers(j)
                j -= 1
                If j < 0 Then Exit While 'ensure j doesn't go below 0


            End While
            randomnumbers(j + 1) = key

        Next
        'display sorted numbers
        ListBox1.Items.Add("")
        ListBox1.Items.Add("sorted:")
        For i = 0 To 6
            ListBox1.Items.Add(randomnumbers(i).ToString())

        Next
    End Sub

    Private Sub Bn9_Click(sender As Object, e As EventArgs) Handles Bn9.Click
        Form.Show()
        Me.Hide()
    End Sub
End Class