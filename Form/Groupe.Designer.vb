<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Groupe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Groupe))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1286, 624)
        Me.TabControl1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "10.png")
        Me.ImageList1.Images.SetKeyName(1, "11.png")
        Me.ImageList1.Images.SetKeyName(2, "20.png")
        Me.ImageList1.Images.SetKeyName(3, "21.png")
        Me.ImageList1.Images.SetKeyName(4, "30.png")
        Me.ImageList1.Images.SetKeyName(5, "31.png")
        Me.ImageList1.Images.SetKeyName(6, "40.png")
        Me.ImageList1.Images.SetKeyName(7, "41.png")
        Me.ImageList1.Images.SetKeyName(8, "50.png")
        Me.ImageList1.Images.SetKeyName(9, "51.png")
        Me.ImageList1.Images.SetKeyName(10, "60.png")
        Me.ImageList1.Images.SetKeyName(11, "61.png")
        Me.ImageList1.Images.SetKeyName(12, "70.png")
        Me.ImageList1.Images.SetKeyName(13, "71.png")
        Me.ImageList1.Images.SetKeyName(14, "80.png")
        Me.ImageList1.Images.SetKeyName(15, "81.png")
        Me.ImageList1.Images.SetKeyName(16, "90.png")
        Me.ImageList1.Images.SetKeyName(17, "91.png")
        Me.ImageList1.Images.SetKeyName(18, "100.png")
        Me.ImageList1.Images.SetKeyName(19, "101.png")
        Me.ImageList1.Images.SetKeyName(20, "110.png")
        Me.ImageList1.Images.SetKeyName(21, "111.png")
        Me.ImageList1.Images.SetKeyName(22, "120.png")
        Me.ImageList1.Images.SetKeyName(23, "121.png")
        '
        'Groupe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1310, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Groupe"
        Me.Text = "Groupe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ImageList1 As ImageList
End Class
