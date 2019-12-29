<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supprimer_un_compte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supprimer_un_compte))
        Me.Label_Suppression_Statut = New System.Windows.Forms.Label()
        Me.ListBox_Compte = New System.Windows.Forms.ListBox()
        Me.PictureBox_Personnage = New System.Windows.Forms.PictureBox()
        Me.Button_Supprimer_Le_Compte = New Linabot.RedemptionButton()
        CType(Me.PictureBox_Personnage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Suppression_Statut
        '
        Me.Label_Suppression_Statut.AutoSize = True
        Me.Label_Suppression_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Suppression_Statut.ForeColor = System.Drawing.Color.White
        Me.Label_Suppression_Statut.Location = New System.Drawing.Point(239, 233)
        Me.Label_Suppression_Statut.Name = "Label_Suppression_Statut"
        Me.Label_Suppression_Statut.Size = New System.Drawing.Size(247, 16)
        Me.Label_Suppression_Statut.TabIndex = 25
        Me.Label_Suppression_Statut.Text = "Suppression du/des compte(s) : Inconnu"
        '
        'ListBox_Compte
        '
        Me.ListBox_Compte.BackColor = System.Drawing.Color.Silver
        Me.ListBox_Compte.ForeColor = System.Drawing.Color.Black
        Me.ListBox_Compte.FormattingEnabled = True
        Me.ListBox_Compte.Location = New System.Drawing.Point(12, 12)
        Me.ListBox_Compte.Name = "ListBox_Compte"
        Me.ListBox_Compte.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox_Compte.Size = New System.Drawing.Size(226, 212)
        Me.ListBox_Compte.TabIndex = 23
        '
        'PictureBox_Personnage
        '
        Me.PictureBox_Personnage.Location = New System.Drawing.Point(244, 12)
        Me.PictureBox_Personnage.Name = "PictureBox_Personnage"
        Me.PictureBox_Personnage.Size = New System.Drawing.Size(235, 212)
        Me.PictureBox_Personnage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Personnage.TabIndex = 22
        Me.PictureBox_Personnage.TabStop = False
        '
        'Button_Supprimer_Le_Compte
        '
        Me.Button_Supprimer_Le_Compte.BackColor = System.Drawing.Color.Transparent
        Me.Button_Supprimer_Le_Compte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Supprimer_Le_Compte.Location = New System.Drawing.Point(12, 230)
        Me.Button_Supprimer_Le_Compte.Name = "Button_Supprimer_Le_Compte"
        Me.Button_Supprimer_Le_Compte.Size = New System.Drawing.Size(221, 23)
        Me.Button_Supprimer_Le_Compte.TabIndex = 26
        Me.Button_Supprimer_Le_Compte.Text = "Supprimer le(s) compte(s)"
        Me.Button_Supprimer_Le_Compte.TextAlign = Linabot.RedemptionButton.HorizontalAlignment.Center
        '
        'Supprimer_un_compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 264)
        Me.Controls.Add(Me.Button_Supprimer_Le_Compte)
        Me.Controls.Add(Me.Label_Suppression_Statut)
        Me.Controls.Add(Me.ListBox_Compte)
        Me.Controls.Add(Me.PictureBox_Personnage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Supprimer_un_compte"
        Me.Text = "Supprimer un compte"
        CType(Me.PictureBox_Personnage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Suppression_Statut As Label
    Friend WithEvents ListBox_Compte As ListBox
    Friend WithEvents PictureBox_Personnage As PictureBox
    Friend WithEvents Button_Supprimer_Le_Compte As RedemptionButton
End Class
