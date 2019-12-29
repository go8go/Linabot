<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionDesComptesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesComptesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1315, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionDesComptesToolStripMenuItem
        '
        Me.GestionDesComptesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnCompteToolStripMenuItem, Me.ChargerUnCompteToolStripMenuItem, Me.SupprimerUnCompteToolStripMenuItem})
        Me.GestionDesComptesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GestionDesComptesToolStripMenuItem.Image = Global.Linabot.My.Resources.Resources.user_group_8
        Me.GestionDesComptesToolStripMenuItem.Name = "GestionDesComptesToolStripMenuItem"
        Me.GestionDesComptesToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.GestionDesComptesToolStripMenuItem.Text = "Gestion des comptes"
        '
        'AjouterUnCompteToolStripMenuItem
        '
        Me.AjouterUnCompteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AjouterUnCompteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AjouterUnCompteToolStripMenuItem.Image = Global.Linabot.My.Resources.Resources.plus
        Me.AjouterUnCompteToolStripMenuItem.Name = "AjouterUnCompteToolStripMenuItem"
        Me.AjouterUnCompteToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AjouterUnCompteToolStripMenuItem.Text = "Ajouter un compte"
        '
        'ChargerUnCompteToolStripMenuItem
        '
        Me.ChargerUnCompteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ChargerUnCompteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ChargerUnCompteToolStripMenuItem.Image = Global.Linabot.My.Resources.Resources.user_group_8
        Me.ChargerUnCompteToolStripMenuItem.Name = "ChargerUnCompteToolStripMenuItem"
        Me.ChargerUnCompteToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ChargerUnCompteToolStripMenuItem.Text = "Charger un compte"
        '
        'SupprimerUnCompteToolStripMenuItem
        '
        Me.SupprimerUnCompteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SupprimerUnCompteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SupprimerUnCompteToolStripMenuItem.Image = Global.Linabot.My.Resources.Resources.moins
        Me.SupprimerUnCompteToolStripMenuItem.Name = "SupprimerUnCompteToolStripMenuItem"
        Me.SupprimerUnCompteToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SupprimerUnCompteToolStripMenuItem.Text = "Supprimer un compte"
        '
        'Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 650)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Panel"
        Me.Text = "Linabot - Panel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionDesComptesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterUnCompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChargerUnCompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerUnCompteToolStripMenuItem As ToolStripMenuItem
End Class
