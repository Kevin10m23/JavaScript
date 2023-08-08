<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label4 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI Symbol", 27.75F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaption
        Label1.Location = New Point(240, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 50)
        Label1.TabIndex = 0
        Label1.Text = "CALCULADORA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(192, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 34)
        Label2.TabIndex = 1
        Label2.Text = "NUMERO 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SkyBlue
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(192, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 34)
        Label3.TabIndex = 2
        Label3.Text = "NUMERO 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(438, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(108, 29)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(438, 250)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(108, 29)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(162, 410)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 69)
        Button1.TabIndex = 5
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Emoji", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(284, 410)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 69)
        Button2.TabIndex = 6
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Emoji", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(423, 411)
        Button3.Name = "Button3"
        Button3.Size = New Size(92, 69)
        Button3.TabIndex = 7
        Button3.Text = "*"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Emoji", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(567, 410)
        Button4.Name = "Button4"
        Button4.Size = New Size(92, 69)
        Button4.TabIndex = 8
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.SkyBlue
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(192, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 34)
        Label4.TabIndex = 9
        Label4.Text = "RESULTADO"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(438, 335)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(108, 29)
        TextBox3.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(800, 510)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
