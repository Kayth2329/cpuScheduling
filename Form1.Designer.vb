<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFCFS = New System.Windows.Forms.Button()
        Me.btnSJF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU Scheduling"
        '
        'btnFCFS
        '
        Me.btnFCFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFCFS.Font = New System.Drawing.Font("Felix Titling", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFCFS.Location = New System.Drawing.Point(190, 122)
        Me.btnFCFS.Name = "btnFCFS"
        Me.btnFCFS.Size = New System.Drawing.Size(220, 89)
        Me.btnFCFS.TabIndex = 1
        Me.btnFCFS.Text = "First Come First Serve"
        Me.btnFCFS.UseVisualStyleBackColor = True
        '
        'btnSJF
        '
        Me.btnSJF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSJF.Font = New System.Drawing.Font("Felix Titling", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSJF.Location = New System.Drawing.Point(190, 233)
        Me.btnSJF.Name = "btnSJF"
        Me.btnSJF.Size = New System.Drawing.Size(220, 89)
        Me.btnSJF.TabIndex = 2
        Me.btnSJF.Text = "Shortest Job First"
        Me.btnSJF.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(605, 355)
        Me.Controls.Add(Me.btnSJF)
        Me.Controls.Add(Me.btnFCFS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CPU Schduling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnFCFS As Button
    Friend WithEvents btnSJF As Button
End Class
