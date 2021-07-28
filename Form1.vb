Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim fence As New Rectangle

        Dim dblCostPerFoot As Double
        Dim dblPerimeter As Double
        Dim dblTotalCost As Double

        Double.TryParse(txtLength.Text.ToString, fence.Length)
        Double.TryParse(txtWidth.Text.ToString, fence.Width)
        Double.TryParse(txtCostPerFoot.Text.ToString, dblCostPerFoot)

        dblPerimeter = fence.GetPerimeter

        dblTotalCost = dblCostPerFoot * dblPerimeter

        lblTotalCost.Text = dblTotalCost.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        lblTotalCost.Text = ""
    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        lblTotalCost.Text = ""
    End Sub

    Private Sub txtCostPerFoot_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerFoot.TextChanged
        lblTotalCost.Text = ""
    End Sub
End Class
