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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1 = New GroupBox()
        RichTextBox1 = New RichTextBox()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(17, 28)
        RadioButton1.Margin = New Padding(3, 4, 3, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(82, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Reynosa"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(119, 29)
        RadioButton2.Margin = New Padding(3, 4, 3, 4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(99, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Matamoros"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(241, 28)
        RadioButton3.Margin = New Padding(3, 4, 3, 4)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(76, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Victoria"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(343, 66)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ciudad"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(14, 90)
        RichTextBox1.Margin = New Padding(3, 4, 3, 4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(342, 419)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(736, 28)
        AxWindowsMediaPlayer1.Margin = New Padding(3, 4, 3, 4)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(347, 492)
        AxWindowsMediaPlayer1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(374, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(347, 492)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 527)
        Controls.Add(PictureBox1)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(RichTextBox1)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As PictureBox

End Class
