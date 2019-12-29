<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ajouter_Un_Compte
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajouter_Un_Compte))
        Me.TextBox_Nom_De_Compte = New System.Windows.Forms.TextBox()
        Me.Label_Création_Statut = New System.Windows.Forms.Label()
        Me.PictureBox_Personnage = New System.Windows.Forms.PictureBox()
        Me.TextBox_Mot_De_Passe = New System.Windows.Forms.TextBox()
        Me.TextBox_Nom_Du_Personnage = New System.Windows.Forms.TextBox()
        Me.Button_Ajouter_Le_Compte = New Linabot.RedemptionButton()
        Me.ComboBox_Choix_Personnage = New Linabot.RedemptionComboBox()
        Me.ComboBox_Choix_Serveur = New Linabot.RedemptionComboBox()
        Me.ComboBox_Choix_Sexe = New Linabot.RedemptionComboBox()
        CType(Me.PictureBox_Personnage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Nom_De_Compte
        '
        Me.TextBox_Nom_De_Compte.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox_Nom_De_Compte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nom_De_Compte.ForeColor = System.Drawing.Color.White
        Me.TextBox_Nom_De_Compte.Location = New System.Drawing.Point(12, 12)
        Me.TextBox_Nom_De_Compte.Multiline = True
        Me.TextBox_Nom_De_Compte.Name = "TextBox_Nom_De_Compte"
        Me.TextBox_Nom_De_Compte.Size = New System.Drawing.Size(189, 30)
        Me.TextBox_Nom_De_Compte.TabIndex = 0
        Me.TextBox_Nom_De_Compte.Text = "Nom de compte"
        Me.TextBox_Nom_De_Compte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Création_Statut
        '
        Me.Label_Création_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Création_Statut.Location = New System.Drawing.Point(207, 215)
        Me.Label_Création_Statut.Name = "Label_Création_Statut"
        Me.Label_Création_Statut.Size = New System.Drawing.Size(226, 21)
        Me.Label_Création_Statut.TabIndex = 18
        Me.Label_Création_Statut.Text = "Création du compte : Inconnu"
        Me.Label_Création_Statut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_Personnage
        '
        Me.PictureBox_Personnage.Location = New System.Drawing.Point(207, 12)
        Me.PictureBox_Personnage.Name = "PictureBox_Personnage"
        Me.PictureBox_Personnage.Size = New System.Drawing.Size(226, 186)
        Me.PictureBox_Personnage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Personnage.TabIndex = 17
        Me.PictureBox_Personnage.TabStop = False
        '
        'TextBox_Mot_De_Passe
        '
        Me.TextBox_Mot_De_Passe.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox_Mot_De_Passe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Mot_De_Passe.ForeColor = System.Drawing.Color.White
        Me.TextBox_Mot_De_Passe.Location = New System.Drawing.Point(12, 48)
        Me.TextBox_Mot_De_Passe.Multiline = True
        Me.TextBox_Mot_De_Passe.Name = "TextBox_Mot_De_Passe"
        Me.TextBox_Mot_De_Passe.Size = New System.Drawing.Size(189, 30)
        Me.TextBox_Mot_De_Passe.TabIndex = 19
        Me.TextBox_Mot_De_Passe.Text = "Mot de passe"
        Me.TextBox_Mot_De_Passe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Nom_Du_Personnage
        '
        Me.TextBox_Nom_Du_Personnage.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox_Nom_Du_Personnage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nom_Du_Personnage.ForeColor = System.Drawing.Color.White
        Me.TextBox_Nom_Du_Personnage.Location = New System.Drawing.Point(12, 84)
        Me.TextBox_Nom_Du_Personnage.Multiline = True
        Me.TextBox_Nom_Du_Personnage.Name = "TextBox_Nom_Du_Personnage"
        Me.TextBox_Nom_Du_Personnage.Size = New System.Drawing.Size(189, 30)
        Me.TextBox_Nom_Du_Personnage.TabIndex = 20
        Me.TextBox_Nom_Du_Personnage.Text = "Nom du personnage"
        Me.TextBox_Nom_Du_Personnage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_Ajouter_Le_Compte
        '
        Me.Button_Ajouter_Le_Compte.BackColor = System.Drawing.Color.Transparent
        Me.Button_Ajouter_Le_Compte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button_Ajouter_Le_Compte.Location = New System.Drawing.Point(12, 210)
        Me.Button_Ajouter_Le_Compte.Name = "Button_Ajouter_Le_Compte"
        Me.Button_Ajouter_Le_Compte.Size = New System.Drawing.Size(189, 26)
        Me.Button_Ajouter_Le_Compte.TabIndex = 6
        Me.Button_Ajouter_Le_Compte.Text = "Ajouter le compte"
        Me.Button_Ajouter_Le_Compte.TextAlign = Linabot.RedemptionButton.HorizontalAlignment.Center
        '
        'ComboBox_Choix_Personnage
        '
        Me.ComboBox_Choix_Personnage.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox_Choix_Personnage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Choix_Personnage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Choix_Personnage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_Choix_Personnage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ComboBox_Choix_Personnage.FormattingEnabled = True
        Me.ComboBox_Choix_Personnage.ItemHeight = 18
        Me.ComboBox_Choix_Personnage.Location = New System.Drawing.Point(12, 120)
        Me.ComboBox_Choix_Personnage.Name = "ComboBox_Choix_Personnage"
        Me.ComboBox_Choix_Personnage.Size = New System.Drawing.Size(189, 24)
        Me.ComboBox_Choix_Personnage.TabIndex = 3
        '
        'ComboBox_Choix_Serveur
        '
        Me.ComboBox_Choix_Serveur.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox_Choix_Serveur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Choix_Serveur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Choix_Serveur.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_Choix_Serveur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ComboBox_Choix_Serveur.FormattingEnabled = True
        Me.ComboBox_Choix_Serveur.ItemHeight = 18
        Me.ComboBox_Choix_Serveur.Location = New System.Drawing.Point(12, 180)
        Me.ComboBox_Choix_Serveur.Name = "ComboBox_Choix_Serveur"
        Me.ComboBox_Choix_Serveur.Size = New System.Drawing.Size(189, 24)
        Me.ComboBox_Choix_Serveur.TabIndex = 21
        '
        'ComboBox_Choix_Sexe
        '
        Me.ComboBox_Choix_Sexe.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox_Choix_Sexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_Choix_Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Choix_Sexe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ComboBox_Choix_Sexe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ComboBox_Choix_Sexe.FormattingEnabled = True
        Me.ComboBox_Choix_Sexe.ItemHeight = 18
        Me.ComboBox_Choix_Sexe.Location = New System.Drawing.Point(12, 150)
        Me.ComboBox_Choix_Sexe.Name = "ComboBox_Choix_Sexe"
        Me.ComboBox_Choix_Sexe.Size = New System.Drawing.Size(189, 24)
        Me.ComboBox_Choix_Sexe.TabIndex = 22
        '
        'Ajouter_Un_Compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(445, 248)
        Me.Controls.Add(Me.TextBox_Nom_De_Compte)
        Me.Controls.Add(Me.ComboBox_Choix_Sexe)
        Me.Controls.Add(Me.ComboBox_Choix_Personnage)
        Me.Controls.Add(Me.Label_Création_Statut)
        Me.Controls.Add(Me.ComboBox_Choix_Serveur)
        Me.Controls.Add(Me.TextBox_Mot_De_Passe)
        Me.Controls.Add(Me.Button_Ajouter_Le_Compte)
        Me.Controls.Add(Me.PictureBox_Personnage)
        Me.Controls.Add(Me.TextBox_Nom_Du_Personnage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ajouter_Un_Compte"
        Me.Text = "Ajouter un compte"
        CType(Me.PictureBox_Personnage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Nom_De_Compte As TextBox
    Friend WithEvents ComboBox_Choix_Personnage As RedemptionComboBox
    Friend WithEvents Button_Ajouter_Le_Compte As RedemptionButton
    Friend WithEvents Label_Création_Statut As Label
    Friend WithEvents PictureBox_Personnage As PictureBox
    Friend WithEvents TextBox_Mot_De_Passe As TextBox
    Friend WithEvents TextBox_Nom_Du_Personnage As TextBox
    Friend WithEvents ComboBox_Choix_Serveur As RedemptionComboBox
    Friend WithEvents ComboBox_Choix_Sexe As RedemptionComboBox
End Class
