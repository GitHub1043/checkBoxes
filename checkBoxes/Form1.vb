Public Class Form1

    Private Sub btnEat_Click(sender As Object, e As EventArgs) Handles btnEat.Click

        Dim intCount As Integer = 0
        'GUD
        If (chkPancakes.Checked = True) Then
            intCount = intCount + 1
        End If
        If (chkRice.Checked = True) Then
            intCount = intCount + 1
        End If
        If (chkBatteries.Checked = True) Then
            intCount = intCount + 1
        End If
        MessageBox.Show("Options: " & intCount)

        If Not (chkBatteries.Checked = True) Then
            ' Not reverses true and false
            If (chkPancakes.Checked = True) And (chkRice.Checked = True) Then
                lblResult.Text = "Too Much Food"
            ElseIf (chkPancakes.Checked = True) Or (chkRice.Checked = True) Then
                lblResult.Text = "Good Breakfast"

            Else
                lblResult.Text = "Not Enough Food"
            End If
        Else
            lblResult.Text = ("Trip to the Hospital")
        End If

    End Sub
End Class
