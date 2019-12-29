<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page_Initial
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Initiative", "0", "0", "0", "0", "0"}, 21)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Prospection", "0", "0", "0", "0", "0"}, 22)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Points d'action (PA)", "0", "0", "0", "0", "0"}, 6)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Points de mouvement (PM)", "0", "0", "0", "0", "0"}, 8)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Force", "0", "0", "0", "0", "0"}, 1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Vitalité", "0", "0", "0", "0", "0"}, 23)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sagesse", "0", "0", "0", "0", "0"}, 20)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Chance", "0", "0", "0", "0", "0"}, 4)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Agilité", "0", "0", "0", "0", "0"}, 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Intelligence", "0", "0", "0", "0", "0"}, 2)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Portée (PO)", "0", "0", "0", "0", "0"}, 5)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Maximum de créatures invocables", "0", "0", "0", "0", "0"}, 24)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux dégâts", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux dégâts physique", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus de maîtrise d'arme", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux dommages (%)", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux soins", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux pièges", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux pièges (%)", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Renvoi de dommages", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux coups critiques", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux échecs critiques", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Esquive PA", "0", "0", "0", "0", "0"}, 6)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Esquive PM", "0", "0", "0", "0", "0"}, 8)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (Fixe - PVM)", "0", "0", "0", "0", "0"}, 13)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (% - PVM)", "0", "0", "0", "0", "0"}, 13)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (Fixe - PVP)", "0", "0", "0", "0", "0"}, 18)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (% - PVP)", "0", "0", "0", "0", "0"}, 18)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (Fixe - PVM)", "0", "0", "0", "0", "0"}, 10)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (% - PVM)", "0", "0", "0", "0", "0"}, 10)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (Fixe - PVP)", "0", "0", "0", "0", "0"}, 19)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (% - PVP)", "0", "0", "0", "0", "0"}, 19)
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (Fixe - PVM)", "0", "0", "0", "0", "0"}, 12)
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (% - PVM)", "0", "0", "0", "0", "0"}, 12)
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (Fixe - PVP)", "0", "0", "0", "0", "0"}, 16)
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (% - PVP)", "0", "0", "0", "0", "0"}, 16)
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (Fixe - PVM)", "0", "0", "0", "0", "0"}, 9)
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (% - PVM)", "0", "0", "0", "0", "0"}, 9)
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (Fixe - PVP)", "0", "0", "0", "0", "0"}, 15)
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (% - PVP)", "0", "0", "0", "0", "0"}, 15)
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (Fixe - PVM)", "0", "0", "0", "0", "0"}, 11)
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (% - PVM)", "0", "0", "0", "0", "0"}, 11)
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (Fixe - PVP)", "0", "0", "0", "0", "0"}, 17)
        Dim ListViewItem44 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (% - PVP)", "0", "0", "0", "0", "0"}, 17)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_Initial))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Tchat = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_Abonnement_Dofus = New Linabot.RedemptionLabel()
        Me.RedemptionLabel2 = New Linabot.RedemptionLabel()
        Me.Label_Kamas = New Linabot.RedemptionLabel()
        Me.ProgressBar_Vitalité = New Linabot.RedemptionProgressBar()
        Me.ProgressBar_Energie = New Linabot.RedemptionProgressBar()
        Me.ProgressBar_Pods = New Linabot.RedemptionProgressBar()
        Me.ProgressBar_Expérience = New Linabot.RedemptionProgressBar()
        Me.Label_Niveau = New Linabot.RedemptionLabel()
        Me.Label_Statut = New Linabot.RedemptionLabel()
        Me.Toggle_Connexion = New Linabot.RedemptionToggle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Canal_Groupe_2 = New Linabot.RedemptionCheckBox()
        Me.CheckBox_Canal_Communs_1 = New Linabot.RedemptionCheckBox()
        Me.CheckBox_Canal_Commerce_6 = New Linabot.RedemptionCheckBox()
        Me.CheckBox_Canal_Alignement_4 = New Linabot.RedemptionCheckBox()
        Me.CheckBox_Canal_Recrutement_5 = New Linabot.RedemptionCheckBox()
        Me.CheckBox_Canal_Guilde_3 = New Linabot.RedemptionCheckBox()
        Me.CheckBox_Canal_Information_0 = New Linabot.RedemptionCheckBox()
        Me.RedemptionTextBox1 = New Linabot.RedemptionTextBox()
        Me.RichTextBox_Tchat = New System.Windows.Forms.RichTextBox()
        Me.TabPage_Caractéristique = New System.Windows.Forms.TabPage()
        Me.Label_Caractéristique_Capital = New Linabot.RedemptionLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView_Caractéristique = New System.Windows.Forms.ListView()
        Me.Caractéristique_Caractéristique = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Base = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Equipement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Dons = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Boost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList_Caractéristique = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage_Sort = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_Sort_Capital = New Linabot.RedemptionLabel()
        Me.TabPage_Inventaire = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView_Inventaire_Affiche_Caractéristique = New System.Windows.Forms.ListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label_Inventaire_Affiche_Level = New Linabot.RedemptionLabel()
        Me.Label_Inventaire_Affiche_Nom = New Linabot.RedemptionLabel()
        Me.FlowLayoutPanel_Inventaire = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.RichTextBox_Socket = New System.Windows.Forms.RichTextBox()
        Me.ImageList_Initial = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button_Option_Tchat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Dofus_5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Dofus_6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Dofus_3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Dofus_4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Cape = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Familier = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Anneaux_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_CaC = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Coiffe = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ceinture = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Bottes = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Dofus_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Dofus_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Anneaux_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Bouclier = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Amulette = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Inventaire_Affiche_Caractéristique = New System.Windows.Forms.PictureBox()
        Me.Button_Inventaire_Supprimer = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Tchat.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_Caractéristique.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage_Sort.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage_Inventaire.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Dofus_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Dofus_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Dofus_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Dofus_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Cape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Familier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Anneaux_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_CaC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Coiffe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ceinture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Bottes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Dofus_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Dofus_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Anneaux_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Bouclier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Amulette, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Inventaire_Affiche_Caractéristique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Tchat)
        Me.TabControl1.Controls.Add(Me.TabPage_Caractéristique)
        Me.TabControl1.Controls.Add(Me.TabPage_Sort)
        Me.TabControl1.Controls.Add(Me.TabPage_Inventaire)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Controls.Add(Me.TabPage13)
        Me.TabControl1.ImageList = Me.ImageList_Initial
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1330, 683)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Tchat
        '
        Me.TabPage_Tchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage_Tchat.Controls.Add(Me.GroupBox2)
        Me.TabPage_Tchat.Controls.Add(Me.Button_Option_Tchat)
        Me.TabPage_Tchat.Controls.Add(Me.GroupBox1)
        Me.TabPage_Tchat.ImageIndex = 5
        Me.TabPage_Tchat.Location = New System.Drawing.Point(4, 47)
        Me.TabPage_Tchat.Name = "TabPage_Tchat"
        Me.TabPage_Tchat.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Tchat.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage_Tchat.TabIndex = 0
        Me.TabPage_Tchat.Text = "Tchat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox12)
        Me.GroupBox2.Controls.Add(Me.Label_Abonnement_Dofus)
        Me.GroupBox2.Controls.Add(Me.PictureBox11)
        Me.GroupBox2.Controls.Add(Me.RedemptionLabel2)
        Me.GroupBox2.Controls.Add(Me.PictureBox10)
        Me.GroupBox2.Controls.Add(Me.Label_Kamas)
        Me.GroupBox2.Controls.Add(Me.PictureBox9)
        Me.GroupBox2.Controls.Add(Me.PictureBox8)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.ProgressBar_Vitalité)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.ProgressBar_Energie)
        Me.GroupBox2.Controls.Add(Me.ProgressBar_Pods)
        Me.GroupBox2.Controls.Add(Me.ProgressBar_Expérience)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.Label_Niveau)
        Me.GroupBox2.Controls.Add(Me.Label_Statut)
        Me.GroupBox2.Controls.Add(Me.Toggle_Connexion)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(686, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(630, 327)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Label_Abonnement_Dofus
        '
        Me.Label_Abonnement_Dofus.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_Abonnement_Dofus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Abonnement_Dofus.ForeColor = System.Drawing.Color.White
        Me.Label_Abonnement_Dofus.Location = New System.Drawing.Point(72, 130)
        Me.Label_Abonnement_Dofus.Name = "Label_Abonnement_Dofus"
        Me.Label_Abonnement_Dofus.Size = New System.Drawing.Size(246, 31)
        Me.Label_Abonnement_Dofus.TabIndex = 22
        Me.Label_Abonnement_Dofus.Text = "Abonné jusqu'au : "
        '
        'RedemptionLabel2
        '
        Me.RedemptionLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RedemptionLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionLabel2.ForeColor = System.Drawing.Color.White
        Me.RedemptionLabel2.Location = New System.Drawing.Point(72, 191)
        Me.RedemptionLabel2.Name = "RedemptionLabel2"
        Me.RedemptionLabel2.Size = New System.Drawing.Size(246, 23)
        Me.RedemptionLabel2.TabIndex = 20
        Me.RedemptionLabel2.Text = "Niveaux : 0"
        '
        'Label_Kamas
        '
        Me.Label_Kamas.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_Kamas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Kamas.ForeColor = System.Drawing.Color.White
        Me.Label_Kamas.Location = New System.Drawing.Point(72, 93)
        Me.Label_Kamas.Name = "Label_Kamas"
        Me.Label_Kamas.Size = New System.Drawing.Size(246, 31)
        Me.Label_Kamas.TabIndex = 18
        Me.Label_Kamas.Text = "Kamas : 0"
        '
        'ProgressBar_Vitalité
        '
        Me.ProgressBar_Vitalité.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_Vitalité.Location = New System.Drawing.Point(369, 19)
        Me.ProgressBar_Vitalité.Maximum = 100
        Me.ProgressBar_Vitalité.Name = "ProgressBar_Vitalité"
        Me.ProgressBar_Vitalité.Size = New System.Drawing.Size(255, 31)
        Me.ProgressBar_Vitalité.TabIndex = 10
        Me.ProgressBar_Vitalité.Text = "RedemptionProgressBar1"
        Me.ProgressBar_Vitalité.Value = 0
        '
        'ProgressBar_Energie
        '
        Me.ProgressBar_Energie.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_Energie.Location = New System.Drawing.Point(369, 130)
        Me.ProgressBar_Energie.Maximum = 100
        Me.ProgressBar_Energie.Name = "ProgressBar_Energie"
        Me.ProgressBar_Energie.Size = New System.Drawing.Size(255, 31)
        Me.ProgressBar_Energie.TabIndex = 13
        Me.ProgressBar_Energie.Text = "RedemptionProgressBar4"
        Me.ProgressBar_Energie.Value = 0
        '
        'ProgressBar_Pods
        '
        Me.ProgressBar_Pods.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_Pods.Location = New System.Drawing.Point(369, 93)
        Me.ProgressBar_Pods.Maximum = 100
        Me.ProgressBar_Pods.Name = "ProgressBar_Pods"
        Me.ProgressBar_Pods.Size = New System.Drawing.Size(255, 31)
        Me.ProgressBar_Pods.TabIndex = 12
        Me.ProgressBar_Pods.Text = "RedemptionProgressBar3"
        Me.ProgressBar_Pods.Value = 0
        '
        'ProgressBar_Expérience
        '
        Me.ProgressBar_Expérience.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_Expérience.Location = New System.Drawing.Point(369, 56)
        Me.ProgressBar_Expérience.Maximum = 100
        Me.ProgressBar_Expérience.Name = "ProgressBar_Expérience"
        Me.ProgressBar_Expérience.Size = New System.Drawing.Size(255, 31)
        Me.ProgressBar_Expérience.TabIndex = 11
        Me.ProgressBar_Expérience.Text = "RedemptionProgressBar2"
        Me.ProgressBar_Expérience.Value = 0
        '
        'Label_Niveau
        '
        Me.Label_Niveau.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_Niveau.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Niveau.ForeColor = System.Drawing.Color.White
        Me.Label_Niveau.Location = New System.Drawing.Point(72, 56)
        Me.Label_Niveau.Name = "Label_Niveau"
        Me.Label_Niveau.Size = New System.Drawing.Size(246, 31)
        Me.Label_Niveau.TabIndex = 8
        Me.Label_Niveau.Text = "Niveaux : 0"
        '
        'Label_Statut
        '
        Me.Label_Statut.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_Statut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Statut.ForeColor = System.Drawing.Color.Red
        Me.Label_Statut.Location = New System.Drawing.Point(72, 19)
        Me.Label_Statut.Name = "Label_Statut"
        Me.Label_Statut.Size = New System.Drawing.Size(246, 31)
        Me.Label_Statut.TabIndex = 7
        Me.Label_Statut.Text = "Déconnecté"
        '
        'Toggle_Connexion
        '
        Me.Toggle_Connexion.BackColor = System.Drawing.Color.Transparent
        Me.Toggle_Connexion.Checked = False
        Me.Toggle_Connexion.ForeColor = System.Drawing.Color.White
        Me.Toggle_Connexion.Location = New System.Drawing.Point(6, 21)
        Me.Toggle_Connexion.Name = "Toggle_Connexion"
        Me.Toggle_Connexion.Size = New System.Drawing.Size(60, 26)
        Me.Toggle_Connexion.TabIndex = 6
        Me.Toggle_Connexion.Text = "RedemptionToggle1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Groupe_2)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Communs_1)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Commerce_6)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Alignement_4)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Recrutement_5)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Guilde_3)
        Me.GroupBox1.Controls.Add(Me.CheckBox_Canal_Information_0)
        Me.GroupBox1.Controls.Add(Me.RedemptionTextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.RichTextBox_Tchat)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 620)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'CheckBox_Canal_Groupe_2
        '
        Me.CheckBox_Canal_Groupe_2.BackColor = System.Drawing.Color.Aqua
        Me.CheckBox_Canal_Groupe_2.Checked = False
        Me.CheckBox_Canal_Groupe_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Groupe_2.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Groupe_2.Location = New System.Drawing.Point(519, 557)
        Me.CheckBox_Canal_Groupe_2.Name = "CheckBox_Canal_Groupe_2"
        Me.CheckBox_Canal_Groupe_2.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Groupe_2.TabIndex = 11
        '
        'CheckBox_Canal_Communs_1
        '
        Me.CheckBox_Canal_Communs_1.BackColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Communs_1.Checked = False
        Me.CheckBox_Canal_Communs_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Communs_1.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Communs_1.Location = New System.Drawing.Point(488, 557)
        Me.CheckBox_Canal_Communs_1.Name = "CheckBox_Canal_Communs_1"
        Me.CheckBox_Canal_Communs_1.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Communs_1.TabIndex = 10
        '
        'CheckBox_Canal_Commerce_6
        '
        Me.CheckBox_Canal_Commerce_6.BackColor = System.Drawing.Color.Sienna
        Me.CheckBox_Canal_Commerce_6.Checked = False
        Me.CheckBox_Canal_Commerce_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Commerce_6.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Commerce_6.Location = New System.Drawing.Point(643, 557)
        Me.CheckBox_Canal_Commerce_6.Name = "CheckBox_Canal_Commerce_6"
        Me.CheckBox_Canal_Commerce_6.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Commerce_6.TabIndex = 9
        '
        'CheckBox_Canal_Alignement_4
        '
        Me.CheckBox_Canal_Alignement_4.BackColor = System.Drawing.Color.Orange
        Me.CheckBox_Canal_Alignement_4.Checked = False
        Me.CheckBox_Canal_Alignement_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Alignement_4.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Alignement_4.Location = New System.Drawing.Point(581, 557)
        Me.CheckBox_Canal_Alignement_4.Name = "CheckBox_Canal_Alignement_4"
        Me.CheckBox_Canal_Alignement_4.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Alignement_4.TabIndex = 8
        '
        'CheckBox_Canal_Recrutement_5
        '
        Me.CheckBox_Canal_Recrutement_5.BackColor = System.Drawing.Color.Silver
        Me.CheckBox_Canal_Recrutement_5.Checked = False
        Me.CheckBox_Canal_Recrutement_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Recrutement_5.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Recrutement_5.Location = New System.Drawing.Point(612, 557)
        Me.CheckBox_Canal_Recrutement_5.Name = "CheckBox_Canal_Recrutement_5"
        Me.CheckBox_Canal_Recrutement_5.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Recrutement_5.TabIndex = 7
        '
        'CheckBox_Canal_Guilde_3
        '
        Me.CheckBox_Canal_Guilde_3.BackColor = System.Drawing.Color.DarkViolet
        Me.CheckBox_Canal_Guilde_3.Checked = False
        Me.CheckBox_Canal_Guilde_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Guilde_3.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Guilde_3.Location = New System.Drawing.Point(550, 557)
        Me.CheckBox_Canal_Guilde_3.Name = "CheckBox_Canal_Guilde_3"
        Me.CheckBox_Canal_Guilde_3.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Guilde_3.TabIndex = 6
        '
        'CheckBox_Canal_Information_0
        '
        Me.CheckBox_Canal_Information_0.BackColor = System.Drawing.Color.Lime
        Me.CheckBox_Canal_Information_0.Checked = False
        Me.CheckBox_Canal_Information_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Canal_Information_0.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Information_0.Location = New System.Drawing.Point(457, 557)
        Me.CheckBox_Canal_Information_0.Name = "CheckBox_Canal_Information_0"
        Me.CheckBox_Canal_Information_0.Size = New System.Drawing.Size(25, 19)
        Me.CheckBox_Canal_Information_0.TabIndex = 5
        '
        'RedemptionTextBox1
        '
        Me.RedemptionTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTextBox1.ForeColor = System.Drawing.Color.White
        Me.RedemptionTextBox1.Location = New System.Drawing.Point(48, 586)
        Me.RedemptionTextBox1.MaxLength = 32767
        Me.RedemptionTextBox1.MultiLine = False
        Me.RedemptionTextBox1.Name = "RedemptionTextBox1"
        Me.RedemptionTextBox1.Size = New System.Drawing.Size(589, 28)
        Me.RedemptionTextBox1.TabIndex = 4
        Me.RedemptionTextBox1.Text = "RedemptionTextBox1"
        Me.RedemptionTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RedemptionTextBox1.UseSystemPasswordChar = False
        '
        'RichTextBox_Tchat
        '
        Me.RichTextBox_Tchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RichTextBox_Tchat.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox_Tchat.Name = "RichTextBox_Tchat"
        Me.RichTextBox_Tchat.Size = New System.Drawing.Size(662, 532)
        Me.RichTextBox_Tchat.TabIndex = 1
        Me.RichTextBox_Tchat.Text = ""
        '
        'TabPage_Caractéristique
        '
        Me.TabPage_Caractéristique.AutoScroll = True
        Me.TabPage_Caractéristique.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage_Caractéristique.Controls.Add(Me.PictureBox13)
        Me.TabPage_Caractéristique.Controls.Add(Me.Label_Caractéristique_Capital)
        Me.TabPage_Caractéristique.Controls.Add(Me.Panel1)
        Me.TabPage_Caractéristique.ImageIndex = 2
        Me.TabPage_Caractéristique.Location = New System.Drawing.Point(4, 47)
        Me.TabPage_Caractéristique.Name = "TabPage_Caractéristique"
        Me.TabPage_Caractéristique.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Caractéristique.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage_Caractéristique.TabIndex = 1
        Me.TabPage_Caractéristique.Text = "Caractéristique"
        '
        'Label_Caractéristique_Capital
        '
        Me.Label_Caractéristique_Capital.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_Caractéristique_Capital.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Caractéristique_Capital.ForeColor = System.Drawing.Color.White
        Me.Label_Caractéristique_Capital.Location = New System.Drawing.Point(504, 9)
        Me.Label_Caractéristique_Capital.Name = "Label_Caractéristique_Capital"
        Me.Label_Caractéristique_Capital.Size = New System.Drawing.Size(75, 23)
        Me.Label_Caractéristique_Capital.TabIndex = 339
        Me.Label_Caractéristique_Capital.Text = "Capital : 0"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ListView_Caractéristique)
        Me.Panel1.Location = New System.Drawing.Point(870, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 620)
        Me.Panel1.TabIndex = 338
        '
        'ListView_Caractéristique
        '
        Me.ListView_Caractéristique.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ListView_Caractéristique.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Caractéristique_Caractéristique, Me.Caractéristique_Base, Me.Caractéristique_Equipement, Me.Caractéristique_Dons, Me.Caractéristique_Boost, Me.Caractéristique_Total})
        Me.ListView_Caractéristique.ForeColor = System.Drawing.Color.White
        Me.ListView_Caractéristique.FullRowSelect = True
        Me.ListView_Caractéristique.GridLines = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        ListViewItem15.StateImageIndex = 0
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.StateImageIndex = 0
        ListViewItem21.StateImageIndex = 0
        ListViewItem22.StateImageIndex = 0
        ListViewItem23.StateImageIndex = 0
        ListViewItem24.StateImageIndex = 0
        ListViewItem25.StateImageIndex = 0
        ListViewItem26.StateImageIndex = 0
        ListViewItem27.StateImageIndex = 0
        ListViewItem28.StateImageIndex = 0
        ListViewItem29.StateImageIndex = 0
        ListViewItem30.StateImageIndex = 0
        ListViewItem31.StateImageIndex = 0
        ListViewItem32.StateImageIndex = 0
        ListViewItem33.StateImageIndex = 0
        ListViewItem34.StateImageIndex = 0
        ListViewItem35.StateImageIndex = 0
        ListViewItem36.StateImageIndex = 0
        ListViewItem37.StateImageIndex = 0
        ListViewItem38.StateImageIndex = 0
        ListViewItem39.StateImageIndex = 0
        ListViewItem40.StateImageIndex = 0
        ListViewItem41.StateImageIndex = 0
        ListViewItem42.StateImageIndex = 0
        ListViewItem43.StateImageIndex = 0
        ListViewItem44.StateImageIndex = 0
        Me.ListView_Caractéristique.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42, ListViewItem43, ListViewItem44})
        Me.ListView_Caractéristique.Location = New System.Drawing.Point(3, 3)
        Me.ListView_Caractéristique.Name = "ListView_Caractéristique"
        Me.ListView_Caractéristique.Size = New System.Drawing.Size(425, 1172)
        Me.ListView_Caractéristique.SmallImageList = Me.ImageList_Caractéristique
        Me.ListView_Caractéristique.TabIndex = 337
        Me.ListView_Caractéristique.UseCompatibleStateImageBehavior = False
        Me.ListView_Caractéristique.View = System.Windows.Forms.View.Details
        '
        'Caractéristique_Caractéristique
        '
        Me.Caractéristique_Caractéristique.Text = "Caractéristique"
        Me.Caractéristique_Caractéristique.Width = 193
        '
        'Caractéristique_Base
        '
        Me.Caractéristique_Base.Text = "Base"
        Me.Caractéristique_Base.Width = 42
        '
        'Caractéristique_Equipement
        '
        Me.Caractéristique_Equipement.Text = "Equipement"
        Me.Caractéristique_Equipement.Width = 68
        '
        'Caractéristique_Dons
        '
        Me.Caractéristique_Dons.Text = "Dons"
        Me.Caractéristique_Dons.Width = 37
        '
        'Caractéristique_Boost
        '
        Me.Caractéristique_Boost.Text = "Boost"
        Me.Caractéristique_Boost.Width = 39
        '
        'Caractéristique_Total
        '
        Me.Caractéristique_Total.Text = "Total"
        Me.Caractéristique_Total.Width = 41
        '
        'ImageList_Caractéristique
        '
        Me.ImageList_Caractéristique.ImageStream = CType(resources.GetObject("ImageList_Caractéristique.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Caractéristique.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Caractéristique.Images.SetKeyName(0, "Agilité.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(1, "Force.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(2, "Intelligence.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(3, "Neutre.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(4, "Chance.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(5, "PO.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(6, "PA.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(7, "1153.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(8, "PM.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(9, "1157.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(10, "1159.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(11, "1161.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(12, "1163.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(13, "1165.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(14, "1582.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(15, "2172.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(16, "2174.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(17, "2176.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(18, "2178.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(19, "2180.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(20, "2182.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(21, "2184.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(22, "2186.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(23, "2188.png")
        Me.ImageList_Caractéristique.Images.SetKeyName(24, "invocation.png")
        '
        'TabPage_Sort
        '
        Me.TabPage_Sort.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage_Sort.Controls.Add(Me.Panel2)
        Me.TabPage_Sort.ImageIndex = 3
        Me.TabPage_Sort.Location = New System.Drawing.Point(4, 47)
        Me.TabPage_Sort.Name = "TabPage_Sort"
        Me.TabPage_Sort.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Sort.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage_Sort.TabIndex = 2
        Me.TabPage_Sort.Text = "Sort"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.PictureBox14)
        Me.Panel2.Controls.Add(Me.Label_Sort_Capital)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1316, 626)
        Me.Panel2.TabIndex = 0
        '
        'Label_Sort_Capital
        '
        Me.Label_Sort_Capital.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_Sort_Capital.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Sort_Capital.ForeColor = System.Drawing.Color.White
        Me.Label_Sort_Capital.Location = New System.Drawing.Point(78, 3)
        Me.Label_Sort_Capital.Name = "Label_Sort_Capital"
        Me.Label_Sort_Capital.Size = New System.Drawing.Size(75, 23)
        Me.Label_Sort_Capital.TabIndex = 341
        Me.Label_Sort_Capital.Text = "Capital : 0"
        '
        'TabPage_Inventaire
        '
        Me.TabPage_Inventaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage_Inventaire.Controls.Add(Me.Button_Inventaire_Supprimer)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Dofus_5)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Dofus_6)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Dofus_3)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Dofus_4)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Cape)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Familier)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Anneaux_2)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_CaC)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Coiffe)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Ceinture)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Bottes)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Dofus_1)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Dofus_2)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Anneaux_1)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Bouclier)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox_Amulette)
        Me.TabPage_Inventaire.Controls.Add(Me.PictureBox1)
        Me.TabPage_Inventaire.Controls.Add(Me.GroupBox3)
        Me.TabPage_Inventaire.Controls.Add(Me.FlowLayoutPanel_Inventaire)
        Me.TabPage_Inventaire.ImageIndex = 1
        Me.TabPage_Inventaire.Location = New System.Drawing.Point(4, 47)
        Me.TabPage_Inventaire.Name = "TabPage_Inventaire"
        Me.TabPage_Inventaire.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Inventaire.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage_Inventaire.TabIndex = 3
        Me.TabPage_Inventaire.Text = "Inventaire"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl2)
        Me.GroupBox3.Controls.Add(Me.Label_Inventaire_Affiche_Level)
        Me.GroupBox3.Controls.Add(Me.Label_Inventaire_Affiche_Nom)
        Me.GroupBox3.Controls.Add(Me.PictureBox_Inventaire_Affiche_Caractéristique)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(442, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(524, 408)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Affiche Item"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(160, 48)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(348, 354)
        Me.TabControl2.TabIndex = 342
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ListView_Inventaire_Affiche_Caractéristique)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(340, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Effets"
        '
        'ListView_Inventaire_Affiche_Caractéristique
        '
        Me.ListView_Inventaire_Affiche_Caractéristique.BackColor = System.Drawing.Color.Silver
        Me.ListView_Inventaire_Affiche_Caractéristique.FullRowSelect = True
        Me.ListView_Inventaire_Affiche_Caractéristique.GridLines = True
        Me.ListView_Inventaire_Affiche_Caractéristique.Location = New System.Drawing.Point(6, 6)
        Me.ListView_Inventaire_Affiche_Caractéristique.Name = "ListView_Inventaire_Affiche_Caractéristique"
        Me.ListView_Inventaire_Affiche_Caractéristique.Size = New System.Drawing.Size(328, 316)
        Me.ListView_Inventaire_Affiche_Caractéristique.SmallImageList = Me.ImageList_Caractéristique
        Me.ListView_Inventaire_Affiche_Caractéristique.TabIndex = 0
        Me.ListView_Inventaire_Affiche_Caractéristique.UseCompatibleStateImageBehavior = False
        Me.ListView_Inventaire_Affiche_Caractéristique.View = System.Windows.Forms.View.List
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(340, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Conditions"
        '
        'Label_Inventaire_Affiche_Level
        '
        Me.Label_Inventaire_Affiche_Level.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label_Inventaire_Affiche_Level.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Inventaire_Affiche_Level.ForeColor = System.Drawing.Color.White
        Me.Label_Inventaire_Affiche_Level.Location = New System.Drawing.Point(444, 19)
        Me.Label_Inventaire_Affiche_Level.Name = "Label_Inventaire_Affiche_Level"
        Me.Label_Inventaire_Affiche_Level.Size = New System.Drawing.Size(64, 23)
        Me.Label_Inventaire_Affiche_Level.TabIndex = 341
        Me.Label_Inventaire_Affiche_Level.Text = "Niv.0"
        '
        'Label_Inventaire_Affiche_Nom
        '
        Me.Label_Inventaire_Affiche_Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label_Inventaire_Affiche_Nom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Inventaire_Affiche_Nom.ForeColor = System.Drawing.Color.White
        Me.Label_Inventaire_Affiche_Nom.Location = New System.Drawing.Point(16, 19)
        Me.Label_Inventaire_Affiche_Nom.Name = "Label_Inventaire_Affiche_Nom"
        Me.Label_Inventaire_Affiche_Nom.Size = New System.Drawing.Size(422, 23)
        Me.Label_Inventaire_Affiche_Nom.TabIndex = 340
        Me.Label_Inventaire_Affiche_Nom.Text = "Nom de l'item"
        '
        'FlowLayoutPanel_Inventaire
        '
        Me.FlowLayoutPanel_Inventaire.AutoScroll = True
        Me.FlowLayoutPanel_Inventaire.BackColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel_Inventaire.Location = New System.Drawing.Point(972, 6)
        Me.FlowLayoutPanel_Inventaire.Name = "FlowLayoutPanel_Inventaire"
        Me.FlowLayoutPanel_Inventaire.Size = New System.Drawing.Size(344, 557)
        Me.FlowLayoutPanel_Inventaire.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(4, 47)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(4, 47)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage7.Location = New System.Drawing.Point(4, 47)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage8.Location = New System.Drawing.Point(4, 47)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "TabPage8"
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage9.Location = New System.Drawing.Point(4, 47)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "TabPage9"
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage10.Location = New System.Drawing.Point(4, 47)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "TabPage10"
        '
        'TabPage11
        '
        Me.TabPage11.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage11.Location = New System.Drawing.Point(4, 47)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "TabPage11"
        '
        'TabPage12
        '
        Me.TabPage12.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage12.Location = New System.Drawing.Point(4, 47)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage12.TabIndex = 11
        Me.TabPage12.Text = "TabPage12"
        '
        'TabPage13
        '
        Me.TabPage13.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage13.Controls.Add(Me.RichTextBox_Socket)
        Me.TabPage13.Location = New System.Drawing.Point(4, 47)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(1322, 632)
        Me.TabPage13.TabIndex = 12
        Me.TabPage13.Text = "TabPage13"
        '
        'RichTextBox_Socket
        '
        Me.RichTextBox_Socket.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RichTextBox_Socket.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox_Socket.Name = "RichTextBox_Socket"
        Me.RichTextBox_Socket.Size = New System.Drawing.Size(662, 532)
        Me.RichTextBox_Socket.TabIndex = 2
        Me.RichTextBox_Socket.Text = ""
        '
        'ImageList_Initial
        '
        Me.ImageList_Initial.ImageStream = CType(resources.GetObject("ImageList_Initial.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Initial.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Initial.Images.SetKeyName(0, "848.png")
        Me.ImageList_Initial.Images.SetKeyName(1, "1292.png")
        Me.ImageList_Initial.Images.SetKeyName(2, "1294.png")
        Me.ImageList_Initial.Images.SetKeyName(3, "1296.png")
        Me.ImageList_Initial.Images.SetKeyName(4, "2200.png")
        Me.ImageList_Initial.Images.SetKeyName(5, "580b585b2edbce24c47b23eb.png")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 60000
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 100
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.Linabot.My.Resources.Resources.Logo_Dofus
        Me.PictureBox12.Location = New System.Drawing.Point(6, 130)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(60, 31)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 23
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Linabot.My.Resources.Resources.Muscles_icon
        Me.PictureBox11.Location = New System.Drawing.Point(6, 191)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(60, 23)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 21
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.Linabot.My.Resources.Resources._652
        Me.PictureBox10.Location = New System.Drawing.Point(6, 93)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(60, 31)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 19
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(324, 130)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 17
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Linabot.My.Resources.Resources._1292
        Me.PictureBox8.Location = New System.Drawing.Point(324, 93)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 16
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Linabot.My.Resources.Resources.téléchargement
        Me.PictureBox7.Location = New System.Drawing.Point(324, 56)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Linabot.My.Resources.Resources._7__2_
        Me.PictureBox6.Location = New System.Drawing.Point(324, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(39, 31)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Linabot.My.Resources.Resources.Muscles_icon
        Me.PictureBox5.Location = New System.Drawing.Point(6, 56)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 31)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Button_Option_Tchat
        '
        Me.Button_Option_Tchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button_Option_Tchat.BackgroundImage = Global.Linabot.My.Resources.Resources._Option
        Me.Button_Option_Tchat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Option_Tchat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Option_Tchat.ImageIndex = 1
        Me.Button_Option_Tchat.Location = New System.Drawing.Point(686, 587)
        Me.Button_Option_Tchat.Name = "Button_Option_Tchat"
        Me.Button_Option_Tchat.Size = New System.Drawing.Size(47, 39)
        Me.Button_Option_Tchat.TabIndex = 5
        Me.Button_Option_Tchat.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Linabot.My.Resources.Resources.moins
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(643, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 557)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(35, 557)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 586)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.Linabot.My.Resources.Resources.Muscles_icon
        Me.PictureBox13.Location = New System.Drawing.Point(438, 9)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(60, 23)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 340
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.Linabot.My.Resources.Resources.Muscles_icon
        Me.PictureBox14.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(60, 23)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 342
        Me.PictureBox14.TabStop = False
        '
        'PictureBox_Dofus_5
        '
        Me.PictureBox_Dofus_5.Image = CType(resources.GetObject("PictureBox_Dofus_5.Image"), System.Drawing.Image)
        Me.PictureBox_Dofus_5.Location = New System.Drawing.Point(298, 351)
        Me.PictureBox_Dofus_5.Name = "PictureBox_Dofus_5"
        Me.PictureBox_Dofus_5.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Dofus_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Dofus_5.TabIndex = 353
        Me.PictureBox_Dofus_5.TabStop = False
        '
        'PictureBox_Dofus_6
        '
        Me.PictureBox_Dofus_6.Image = CType(resources.GetObject("PictureBox_Dofus_6.Image"), System.Drawing.Image)
        Me.PictureBox_Dofus_6.Location = New System.Drawing.Point(370, 351)
        Me.PictureBox_Dofus_6.Name = "PictureBox_Dofus_6"
        Me.PictureBox_Dofus_6.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Dofus_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Dofus_6.TabIndex = 352
        Me.PictureBox_Dofus_6.TabStop = False
        '
        'PictureBox_Dofus_3
        '
        Me.PictureBox_Dofus_3.Image = CType(resources.GetObject("PictureBox_Dofus_3.Image"), System.Drawing.Image)
        Me.PictureBox_Dofus_3.Location = New System.Drawing.Point(154, 351)
        Me.PictureBox_Dofus_3.Name = "PictureBox_Dofus_3"
        Me.PictureBox_Dofus_3.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Dofus_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Dofus_3.TabIndex = 351
        Me.PictureBox_Dofus_3.TabStop = False
        '
        'PictureBox_Dofus_4
        '
        Me.PictureBox_Dofus_4.Image = CType(resources.GetObject("PictureBox_Dofus_4.Image"), System.Drawing.Image)
        Me.PictureBox_Dofus_4.Location = New System.Drawing.Point(226, 351)
        Me.PictureBox_Dofus_4.Name = "PictureBox_Dofus_4"
        Me.PictureBox_Dofus_4.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Dofus_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Dofus_4.TabIndex = 350
        Me.PictureBox_Dofus_4.TabStop = False
        '
        'PictureBox_Cape
        '
        Me.PictureBox_Cape.Image = CType(resources.GetObject("PictureBox_Cape.Image"), System.Drawing.Image)
        Me.PictureBox_Cape.Location = New System.Drawing.Point(370, 213)
        Me.PictureBox_Cape.Name = "PictureBox_Cape"
        Me.PictureBox_Cape.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Cape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Cape.TabIndex = 349
        Me.PictureBox_Cape.TabStop = False
        '
        'PictureBox_Familier
        '
        Me.PictureBox_Familier.Image = CType(resources.GetObject("PictureBox_Familier.Image"), System.Drawing.Image)
        Me.PictureBox_Familier.Location = New System.Drawing.Point(370, 282)
        Me.PictureBox_Familier.Name = "PictureBox_Familier"
        Me.PictureBox_Familier.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Familier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Familier.TabIndex = 348
        Me.PictureBox_Familier.TabStop = False
        '
        'PictureBox_Anneaux_2
        '
        Me.PictureBox_Anneaux_2.Image = CType(resources.GetObject("PictureBox_Anneaux_2.Image"), System.Drawing.Image)
        Me.PictureBox_Anneaux_2.Location = New System.Drawing.Point(370, 144)
        Me.PictureBox_Anneaux_2.Name = "PictureBox_Anneaux_2"
        Me.PictureBox_Anneaux_2.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Anneaux_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Anneaux_2.TabIndex = 347
        Me.PictureBox_Anneaux_2.TabStop = False
        '
        'PictureBox_CaC
        '
        Me.PictureBox_CaC.Image = CType(resources.GetObject("PictureBox_CaC.Image"), System.Drawing.Image)
        Me.PictureBox_CaC.Location = New System.Drawing.Point(370, 75)
        Me.PictureBox_CaC.Name = "PictureBox_CaC"
        Me.PictureBox_CaC.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_CaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_CaC.TabIndex = 346
        Me.PictureBox_CaC.TabStop = False
        '
        'PictureBox_Coiffe
        '
        Me.PictureBox_Coiffe.Image = CType(resources.GetObject("PictureBox_Coiffe.Image"), System.Drawing.Image)
        Me.PictureBox_Coiffe.Location = New System.Drawing.Point(370, 6)
        Me.PictureBox_Coiffe.Name = "PictureBox_Coiffe"
        Me.PictureBox_Coiffe.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Coiffe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Coiffe.TabIndex = 345
        Me.PictureBox_Coiffe.TabStop = False
        '
        'PictureBox_Ceinture
        '
        Me.PictureBox_Ceinture.Image = CType(resources.GetObject("PictureBox_Ceinture.Image"), System.Drawing.Image)
        Me.PictureBox_Ceinture.Location = New System.Drawing.Point(10, 213)
        Me.PictureBox_Ceinture.Name = "PictureBox_Ceinture"
        Me.PictureBox_Ceinture.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Ceinture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Ceinture.TabIndex = 344
        Me.PictureBox_Ceinture.TabStop = False
        '
        'PictureBox_Bottes
        '
        Me.PictureBox_Bottes.Image = CType(resources.GetObject("PictureBox_Bottes.Image"), System.Drawing.Image)
        Me.PictureBox_Bottes.Location = New System.Drawing.Point(10, 282)
        Me.PictureBox_Bottes.Name = "PictureBox_Bottes"
        Me.PictureBox_Bottes.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Bottes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Bottes.TabIndex = 343
        Me.PictureBox_Bottes.TabStop = False
        '
        'PictureBox_Dofus_1
        '
        Me.PictureBox_Dofus_1.Image = CType(resources.GetObject("PictureBox_Dofus_1.Image"), System.Drawing.Image)
        Me.PictureBox_Dofus_1.Location = New System.Drawing.Point(10, 351)
        Me.PictureBox_Dofus_1.Name = "PictureBox_Dofus_1"
        Me.PictureBox_Dofus_1.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Dofus_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Dofus_1.TabIndex = 342
        Me.PictureBox_Dofus_1.TabStop = False
        '
        'PictureBox_Dofus_2
        '
        Me.PictureBox_Dofus_2.Image = CType(resources.GetObject("PictureBox_Dofus_2.Image"), System.Drawing.Image)
        Me.PictureBox_Dofus_2.Location = New System.Drawing.Point(82, 351)
        Me.PictureBox_Dofus_2.Name = "PictureBox_Dofus_2"
        Me.PictureBox_Dofus_2.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Dofus_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Dofus_2.TabIndex = 341
        Me.PictureBox_Dofus_2.TabStop = False
        '
        'PictureBox_Anneaux_1
        '
        Me.PictureBox_Anneaux_1.Image = CType(resources.GetObject("PictureBox_Anneaux_1.Image"), System.Drawing.Image)
        Me.PictureBox_Anneaux_1.Location = New System.Drawing.Point(10, 144)
        Me.PictureBox_Anneaux_1.Name = "PictureBox_Anneaux_1"
        Me.PictureBox_Anneaux_1.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Anneaux_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Anneaux_1.TabIndex = 340
        Me.PictureBox_Anneaux_1.TabStop = False
        '
        'PictureBox_Bouclier
        '
        Me.PictureBox_Bouclier.Image = CType(resources.GetObject("PictureBox_Bouclier.Image"), System.Drawing.Image)
        Me.PictureBox_Bouclier.Location = New System.Drawing.Point(10, 75)
        Me.PictureBox_Bouclier.Name = "PictureBox_Bouclier"
        Me.PictureBox_Bouclier.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Bouclier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Bouclier.TabIndex = 339
        Me.PictureBox_Bouclier.TabStop = False
        '
        'PictureBox_Amulette
        '
        Me.PictureBox_Amulette.Image = CType(resources.GetObject("PictureBox_Amulette.Image"), System.Drawing.Image)
        Me.PictureBox_Amulette.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox_Amulette.Name = "PictureBox_Amulette"
        Me.PictureBox_Amulette.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox_Amulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Amulette.TabIndex = 338
        Me.PictureBox_Amulette.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 339)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 337
        Me.PictureBox1.TabStop = False
        '
        'PictureBox_Inventaire_Affiche_Caractéristique
        '
        Me.PictureBox_Inventaire_Affiche_Caractéristique.Image = CType(resources.GetObject("PictureBox_Inventaire_Affiche_Caractéristique.Image"), System.Drawing.Image)
        Me.PictureBox_Inventaire_Affiche_Caractéristique.Location = New System.Drawing.Point(16, 48)
        Me.PictureBox_Inventaire_Affiche_Caractéristique.Name = "PictureBox_Inventaire_Affiche_Caractéristique"
        Me.PictureBox_Inventaire_Affiche_Caractéristique.Size = New System.Drawing.Size(138, 132)
        Me.PictureBox_Inventaire_Affiche_Caractéristique.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Inventaire_Affiche_Caractéristique.TabIndex = 339
        Me.PictureBox_Inventaire_Affiche_Caractéristique.TabStop = False
        '
        'Button_Inventaire_Supprimer
        '
        Me.Button_Inventaire_Supprimer.BackgroundImage = Global.Linabot.My.Resources.Resources.Poubelle
        Me.Button_Inventaire_Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Inventaire_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Inventaire_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Inventaire_Supprimer.ForeColor = System.Drawing.Color.White
        Me.Button_Inventaire_Supprimer.Location = New System.Drawing.Point(1263, 569)
        Me.Button_Inventaire_Supprimer.Name = "Button_Inventaire_Supprimer"
        Me.Button_Inventaire_Supprimer.Size = New System.Drawing.Size(53, 57)
        Me.Button_Inventaire_Supprimer.TabIndex = 355
        Me.Button_Inventaire_Supprimer.UseVisualStyleBackColor = True
        '
        'Page_Initial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Page_Initial"
        Me.Size = New System.Drawing.Size(1330, 691)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Tchat.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage_Caractéristique.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabPage_Sort.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabPage_Inventaire.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Dofus_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Dofus_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Dofus_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Dofus_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Cape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Familier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Anneaux_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_CaC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Coiffe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ceinture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Bottes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Dofus_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Dofus_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Anneaux_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Bouclier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Amulette, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Inventaire_Affiche_Caractéristique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_Tchat As TabPage
    Friend WithEvents TabPage_Caractéristique As TabPage
    Friend WithEvents TabPage_Sort As TabPage
    Friend WithEvents TabPage_Inventaire As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents ImageList_Initial As ImageList
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RedemptionTextBox1 As RedemptionTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RichTextBox_Tchat As RichTextBox
    Friend WithEvents CheckBox_Canal_Groupe_2 As RedemptionCheckBox
    Friend WithEvents CheckBox_Canal_Communs_1 As RedemptionCheckBox
    Friend WithEvents CheckBox_Canal_Commerce_6 As RedemptionCheckBox
    Friend WithEvents CheckBox_Canal_Alignement_4 As RedemptionCheckBox
    Friend WithEvents CheckBox_Canal_Recrutement_5 As RedemptionCheckBox
    Friend WithEvents CheckBox_Canal_Guilde_3 As RedemptionCheckBox
    Friend WithEvents CheckBox_Canal_Information_0 As RedemptionCheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_Option_Tchat As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label_Statut As RedemptionLabel
    Friend WithEvents Toggle_Connexion As RedemptionToggle
    Friend WithEvents RichTextBox_Socket As RichTextBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ListView_Caractéristique As ListView
    Friend WithEvents Caractéristique_Caractéristique As ColumnHeader
    Friend WithEvents Caractéristique_Base As ColumnHeader
    Friend WithEvents Caractéristique_Equipement As ColumnHeader
    Friend WithEvents Caractéristique_Dons As ColumnHeader
    Friend WithEvents Caractéristique_Boost As ColumnHeader
    Friend WithEvents Caractéristique_Total As ColumnHeader
    Friend WithEvents ImageList_Caractéristique As ImageList
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Label_Niveau As RedemptionLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ProgressBar_Energie As RedemptionProgressBar
    Friend WithEvents ProgressBar_Pods As RedemptionProgressBar
    Friend WithEvents ProgressBar_Expérience As RedemptionProgressBar
    Friend WithEvents ProgressBar_Vitalité As RedemptionProgressBar
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label_Abonnement_Dofus As RedemptionLabel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents RedemptionLabel2 As RedemptionLabel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label_Kamas As RedemptionLabel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label_Caractéristique_Capital As RedemptionLabel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label_Sort_Capital As RedemptionLabel
    Friend WithEvents FlowLayoutPanel_Inventaire As FlowLayoutPanel
    Friend WithEvents PictureBox_Dofus_5 As PictureBox
    Friend WithEvents PictureBox_Dofus_6 As PictureBox
    Friend WithEvents PictureBox_Dofus_3 As PictureBox
    Friend WithEvents PictureBox_Dofus_4 As PictureBox
    Friend WithEvents PictureBox_Cape As PictureBox
    Friend WithEvents PictureBox_Familier As PictureBox
    Friend WithEvents PictureBox_Anneaux_2 As PictureBox
    Friend WithEvents PictureBox_CaC As PictureBox
    Friend WithEvents PictureBox_Coiffe As PictureBox
    Friend WithEvents PictureBox_Ceinture As PictureBox
    Friend WithEvents PictureBox_Bottes As PictureBox
    Friend WithEvents PictureBox_Dofus_1 As PictureBox
    Friend WithEvents PictureBox_Dofus_2 As PictureBox
    Friend WithEvents PictureBox_Anneaux_1 As PictureBox
    Friend WithEvents PictureBox_Bouclier As PictureBox
    Friend WithEvents PictureBox_Amulette As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListView_Inventaire_Affiche_Caractéristique As ListView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label_Inventaire_Affiche_Level As RedemptionLabel
    Friend WithEvents Label_Inventaire_Affiche_Nom As RedemptionLabel
    Friend WithEvents PictureBox_Inventaire_Affiche_Caractéristique As PictureBox
    Friend WithEvents Button_Inventaire_Supprimer As Button
End Class
