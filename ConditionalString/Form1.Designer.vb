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
        Me.txtNome1 = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVerificaNum = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNome1
        '
        Me.txtNome1.Location = New System.Drawing.Point(96, 21)
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Size = New System.Drawing.Size(100, 20)
        Me.txtNome1.TabIndex = 0
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(34, 73)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(162, 23)
        Me.btnVerificar.TabIndex = 2
        Me.btnVerificar.Text = "Verificar Nome"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome 2"
        '
        'txtNome2
        '
        Me.txtNome2.Location = New System.Drawing.Point(96, 47)
        Me.txtNome2.Name = "txtNome2"
        Me.txtNome2.Size = New System.Drawing.Size(100, 20)
        Me.txtNome2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Numero 2"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(96, 141)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Numero 1"
        '
        'btnVerificaNum
        '
        Me.btnVerificaNum.Location = New System.Drawing.Point(34, 167)
        Me.btnVerificaNum.Name = "btnVerificaNum"
        Me.btnVerificaNum.Size = New System.Drawing.Size(162, 23)
        Me.btnVerificaNum.TabIndex = 8
        Me.btnVerificaNum.Text = "Verificar Número"
        Me.btnVerificaNum.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(96, 115)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 205)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnVerificaNum)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtNome1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNome1 As TextBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnVerificaNum As Button
    Friend WithEvents txtNum1 As TextBox
End Class
