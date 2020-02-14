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
        Me.SaveTxt = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.SaveXml = New System.Windows.Forms.Button()
        Me.SaveJson = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SaveTxt
        '
        Me.SaveTxt.BackColor = System.Drawing.Color.Yellow
        Me.SaveTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveTxt.Location = New System.Drawing.Point(177, 179)
        Me.SaveTxt.Name = "SaveTxt"
        Me.SaveTxt.Size = New System.Drawing.Size(153, 48)
        Me.SaveTxt.TabIndex = 0
        Me.SaveTxt.Text = "Save as Text File"
        Me.SaveTxt.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Status.Location = New System.Drawing.Point(64, 256)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(59, 37)
        Me.Status.TabIndex = 3
        Me.Status.Text = "Hi!"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(105, 45)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(360, 20)
        Me.TextName.TabIndex = 4
        '
        'TextAge
        '
        Me.TextAge.Location = New System.Drawing.Point(105, 84)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(83, 20)
        Me.TextAge.TabIndex = 5
        '
        'TextAddress
        '
        Me.TextAddress.Location = New System.Drawing.Point(105, 123)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(645, 20)
        Me.TextAddress.TabIndex = 6
        '
        'SaveXml
        '
        Me.SaveXml.BackColor = System.Drawing.Color.Yellow
        Me.SaveXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveXml.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveXml.Location = New System.Drawing.Point(336, 179)
        Me.SaveXml.Name = "SaveXml"
        Me.SaveXml.Size = New System.Drawing.Size(153, 48)
        Me.SaveXml.TabIndex = 7
        Me.SaveXml.Text = "Save as XML File"
        Me.SaveXml.UseVisualStyleBackColor = False
        '
        'SaveJson
        '
        Me.SaveJson.BackColor = System.Drawing.Color.Yellow
        Me.SaveJson.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveJson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveJson.Location = New System.Drawing.Point(495, 179)
        Me.SaveJson.Name = "SaveJson"
        Me.SaveJson.Size = New System.Drawing.Size(153, 48)
        Me.SaveJson.TabIndex = 8
        Me.SaveJson.Text = "Save as Json File"
        Me.SaveJson.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(54, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(68, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(41, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 323)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveJson)
        Me.Controls.Add(Me.SaveXml)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.SaveTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveTxt As Button
    Friend WithEvents Status As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextAge As TextBox
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents SaveXml As Button
    Friend WithEvents SaveJson As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
