Public Class FCFS
    Private Sub btnFCFS_Click(sender As Object, e As EventArgs) Handles btnFCFS.Click
        TransferAndUpdateLabels()
        Arrival()
    End Sub

    Private Sub TransferAndUpdateLabels()
        Dim labelValues As System.Windows.Forms.Label() = {Label1, Label2, Label3, Label4, Label5}
        UpdateLabelsFromDataGridView(labelValues, 1)
        UpdateSumLabels(labelValues)
    End Sub

    Private Sub UpdateLabelsFromDataGridView(ByVal labels As System.Windows.Forms.Label(), ByVal columnIndex As Integer)
        Dim rowCount As Integer = DataGridView1.Rows.Count

        For i As Integer = 0 To labels.Length - 1
            If i < rowCount Then
                Dim cellValue As String = DataGridView1.Rows(i).Cells(columnIndex).Value?.ToString()
                labels(i).Text = cellValue
            Else
                labels(i).Text = String.Empty
            End If
        Next
    End Sub

    Private Sub UpdateSumLabels(ByVal labels As System.Windows.Forms.Label())
        Dim labelValues As Integer() = {0, 0, 0, 0, 0}

        For i As Integer = 0 To labels.Length - 1
            If Integer.TryParse(labels(i).Text, labelValues(i)) Then
                If i > 0 Then
                    labelValues(i) += labelValues(i - 1)
                End If
                labels(i).Text = labelValues(i).ToString()
            Else
                labels(i).Text = "Invalid input"
            End If
        Next
    End Sub

    Private Sub Arrival()
        Dim arrivalLabels As System.Windows.Forms.Label() = {Label10, Label11, Label12, Label13, Label14}
        UpdateLabelsFromDataGridView(arrivalLabels, 2)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PM1()
        PM2()
        NP1()
        NP2()
    End Sub

    Private Sub PM1()
        Dim labels As System.Windows.Forms.Label() = {Label6, Label1, Label2, Label3, Label4}
        Dim otherLabels As System.Windows.Forms.Label() = {Label6, Label10, Label11, Label12, Label13}
        Dim rtbText As String = "Preemptive AWT" & Environment.NewLine
        Dim sum As Double = 0
        Dim countValid As Integer = 0

        For i As Integer = 0 To labels.Length - 1
            Dim value As Double
            Dim otherValue As Double

            If Double.TryParse(labels(i).Text, value) AndAlso Double.TryParse(otherLabels(i).Text, otherValue) Then
                Dim result As Double = value - otherValue
                sum += result
                countValid += 1
            End If
        Next

        rtbText &= $"Total Sum:{vbTab}{vbTab}{sum}{Environment.NewLine}"

        If countValid > 0 Then
            Dim average As Double = sum / countValid
            rtbText &= $"Answer:{vbTab}{vbTab}{average}{Environment.NewLine}{Environment.NewLine}"
        End If

        rtboutput.AppendText(rtbText)
    End Sub


    Private Sub PM2()
        rtboutput.AppendText($"Preemptive ATAT{Environment.NewLine}")
        Dim labels As System.Windows.Forms.Label() = {Label1, Label2, Label3, Label4, Label5}
        Dim otherLabels As System.Windows.Forms.Label() = {Nothing, Label11, Label12, Label13, Label14}
        Dim sum As Double = 0
        Dim countValid As Integer = 0

        For i As Integer = 0 To labels.Length - 1
            Dim value As Double
            Dim otherValue As Double

            If i = 0 Then
                value = 0
            Else
                Double.TryParse(labels(i).Text, value)
            End If

            If i > 0 AndAlso Double.TryParse(otherLabels(i).Text, otherValue) Then
                Dim result As Double = value - otherValue
                sum += result
                countValid += 1
            End If
        Next

        rtboutput.AppendText($"Total Sum:{vbTab}{vbTab}{sum}{Environment.NewLine}")

        If countValid > 0 Then
            Dim average As Double = sum / countValid
            rtboutput.AppendText($"Answer:{vbTab}{vbTab}{average}{Environment.NewLine}{Environment.NewLine}")
        End If
    End Sub


    Private Sub NP1()
        rtboutput.AppendText($"Non Preemptive AWT{Environment.NewLine}")
        Dim labels As System.Windows.Forms.Label() = {Label6, Label1, Label2, Label3, Label4}
        Dim sum As Double = 0
        Dim countValid As Integer = 0

        For i As Integer = 0 To labels.Length - 1
            Dim value As Double

            If Double.TryParse(labels(i).Text, value) Then
                Dim result As Double = value - 0
                sum += result
                countValid += 1
            Else
                rtboutput.AppendText($"Invalid input for Result {i + 1}{Environment.NewLine}")
            End If
        Next

        rtboutput.AppendText($"Total Sum:{vbTab}{vbTab}{sum}{Environment.NewLine}")

        If countValid > 0 Then
            Dim average As Double = sum / countValid
            rtboutput.AppendText($"Answer:{vbTab}{vbTab}{average}{Environment.NewLine}{Environment.NewLine}")
        End If
    End Sub


    Private Sub NP2()
        rtboutput.AppendText($"Non Preemptive ATAT{Environment.NewLine}")
        Dim labels As System.Windows.Forms.Label() = {Label1, Label2, Label3, Label4, Label5}
        Dim sum As Double = 0
        Dim countValid As Integer = 0

        For i As Integer = 0 To labels.Length - 1
            Dim value As Double

            If Double.TryParse(labels(i).Text, value) Then
                Dim result As Double = value - 0
                sum += result
                countValid += 1
            Else
                rtboutput.AppendText($"Invalid input for Result {i + 1}{Environment.NewLine}")
            End If
        Next

        rtboutput.AppendText($"Total Sum:{vbTab}{vbTab}{sum}{Environment.NewLine}")

        If countValid > 0 Then
            Dim average As Double = sum / countValid
            rtboutput.AppendText($"Answer:{vbTab}{vbTab}{average}{Environment.NewLine}{Environment.NewLine}")
        End If
    End Sub



End Class