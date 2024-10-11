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
        Me.txtStartNumber = New System.Windows.Forms.TextBox()
        Me.txtEndNumber = New System.Windows.Forms.TextBox()
        Me.txtSumTotal = New System.Windows.Forms.TextBox()
        Me.btnSumNumbers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStartNumber
        '
        Me.txtStartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartNumber.Location = New System.Drawing.Point(245, 108)
        Me.txtStartNumber.Name = "txtStartNumber"
        Me.txtStartNumber.Size = New System.Drawing.Size(302, 38)
        Me.txtStartNumber.TabIndex = 0
        Me.txtStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEndNumber
        '
        Me.txtEndNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndNumber.Location = New System.Drawing.Point(245, 161)
        Me.txtEndNumber.Name = "txtEndNumber"
        Me.txtEndNumber.Size = New System.Drawing.Size(302, 38)
        Me.txtEndNumber.TabIndex = 1
        Me.txtEndNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSumTotal
        '
        Me.txtSumTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumTotal.Location = New System.Drawing.Point(245, 214)
        Me.txtSumTotal.Name = "txtSumTotal"
        Me.txtSumTotal.Size = New System.Drawing.Size(302, 38)
        Me.txtSumTotal.TabIndex = 2
        Me.txtSumTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSumNumbers
        '
        Me.btnSumNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumNumbers.Location = New System.Drawing.Point(245, 271)
        Me.btnSumNumbers.Name = "btnSumNumbers"
        Me.btnSumNumbers.Size = New System.Drawing.Size(302, 61)
        Me.btnSumNumbers.TabIndex = 3
        Me.btnSumNumbers.Text = "Calculate"
        Me.btnSumNumbers.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSumNumbers)
        Me.Controls.Add(Me.txtSumTotal)
        Me.Controls.Add(Me.txtEndNumber)
        Me.Controls.Add(Me.txtStartNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStartNumber As TextBox
    Friend WithEvents txtEndNumber As TextBox
    Friend WithEvents txtSumTotal As TextBox
    Friend WithEvents btnSumNumbers As Button
End Class
