Public Class SJF
    Private Sub btnFCFS_Click(sender As Object, e As EventArgs) Handles btnFCFS.Click
        TransferDataAndSort()
    End Sub

    Private Sub TransferDataAndSort()
        Dim numberPairs As New List(Of Tuple(Of Integer, Integer))()
        Dim processJobPairs As New List(Of Tuple(Of Integer, Integer))()
        TransferAndSortNumbers(numberPairs, DataGridView1, "textBox", "label")
        UpdateLabelsBasedOnSort(numberPairs)
        ProcessAndDisplayBurstTime(processJobPairs, DataGridView1, "label")
    End Sub

    Private Sub TransferAndSortNumbers(ByRef numberPairs As List(Of Tuple(Of Integer, Integer)), ByVal dataGridView As DataGridView, ByVal textBoxPrefix As String, ByVal labelPrefix As String)
        For Each row As DataGridViewRow In dataGridView.Rows
            If Not row.IsNewRow Then
                Dim number As Integer
                If Integer.TryParse(row.Cells(1).Value?.ToString(), number) Then
                    numberPairs.Add(New Tuple(Of Integer, Integer)(number, row.Index))
                End If
            End If
        Next

        numberPairs.Sort(Function(x, y) x.Item1.CompareTo(y.Item1))

        For i As Integer = 0 To numberPairs.Count - 1
            Dim originalRowIndex As Integer = numberPairs(i).Item2
            Dim valueInColumn0 As Integer = Integer.Parse(dataGridView.Rows(originalRowIndex).Cells(0).Value?.ToString())

            If TypeOf Controls($"{textBoxPrefix}{i + 1}") Is System.Windows.Forms.TextBox Then
                Dim textBox As System.Windows.Forms.TextBox = DirectCast(Controls($"{textBoxPrefix}{i + 1}"), System.Windows.Forms.TextBox)
                textBox.Text = valueInColumn0.ToString()
            End If
        Next
    End Sub

    Private Sub UpdateLabelsBasedOnSort(ByVal sortedNumberPairs As List(Of Tuple(Of Integer, Integer)))
        For i As Integer = 0 To sortedNumberPairs.Count - 1
            Dim sortedValue As Integer = sortedNumberPairs(i).Item1

            If TypeOf Controls($"label{i + 1}") Is System.Windows.Forms.Label Then
                Dim label As System.Windows.Forms.Label = DirectCast(Controls($"label{i + 1}"), System.Windows.Forms.Label)
                label.Text = sortedValue.ToString()
            End If
        Next

        UpdatedList(sortedNumberPairs)
    End Sub

    Private Sub UpdatedList(ByVal sortedNumberPairs As List(Of Tuple(Of Integer, Integer)))
        Dim sum As Integer = 0
        For i As Integer = 0 To Math.Min(sortedNumberPairs.Count, 5) - 1
            sum += sortedNumberPairs(i).Item1
            If TypeOf Controls($"Label{i + 1}") Is System.Windows.Forms.Label Then
                Dim label As System.Windows.Forms.Label = DirectCast(Controls($"Label{i + 1}"), System.Windows.Forms.Label)
                label.Text = sum.ToString()
            End If
        Next
    End Sub

    Private Sub ProcessAndDisplayBurstTime(ByRef processJobPairs As List(Of Tuple(Of Integer, Integer)), ByVal dataGridView As DataGridView, ByVal labelPrefix As String)
        For Each row As DataGridViewRow In dataGridView.Rows
            If Not row.IsNewRow Then
                Dim number As Integer
                If Integer.TryParse(row.Cells(1).Value?.ToString(), number) Then
                    processJobPairs.Add(New Tuple(Of Integer, Integer)(number, row.Index))
                End If
            End If
        Next

        processJobPairs.Sort(Function(x, y) x.Item1.CompareTo(y.Item1))

        For i As Integer = 0 To processJobPairs.Count - 1
            Dim originalRowIndex As Integer = processJobPairs(i).Item2
            Dim valueInColumn2 As Integer = Integer.Parse(dataGridView.Rows(originalRowIndex).Cells(2).Value?.ToString())

            If TypeOf Controls($"{labelPrefix}{i + 10}") Is System.Windows.Forms.Label Then
                Dim label As System.Windows.Forms.Label = DirectCast(Controls($"{labelPrefix}{i + 10}"), System.Windows.Forms.Label)
                label.Text = valueInColumn2.ToString()
            End If
        Next
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
                value = 0 ' For the first value, assuming a default of 0
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