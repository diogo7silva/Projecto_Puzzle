Module Module1
    Sub cblev1(ByRef button1 As Button, ByRef Button2 As Button)
        If Button2.Text = "" Then
            Button2.Text = button1.Text
            Button2.BackgroundImage = button1.BackgroundImage
            button1.Text = ""
            button1.BackgroundImage = Nothing
        End If
    End Sub
End Module