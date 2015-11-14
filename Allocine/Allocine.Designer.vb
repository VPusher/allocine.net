<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Allocine
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
        Me.BtSend = New System.Windows.Forms.Button()
        Me.TxtUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblRealisateur = New System.Windows.Forms.Label()
        Me.LblGenre1 = New System.Windows.Forms.Label()
        Me.LblGenre2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtResponse = New System.Windows.Forms.TextBox()
        Me.TxtSynopsis = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.TxtActeurs = New System.Windows.Forms.TextBox()
        Me.TxtTitre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelWebLink = New System.Windows.Forms.LinkLabel()
        Me.PictureStar1 = New System.Windows.Forms.PictureBox()
        Me.PictureStar2 = New System.Windows.Forms.PictureBox()
        Me.PictureStar3 = New System.Windows.Forms.PictureBox()
        Me.PictureStar4 = New System.Windows.Forms.PictureBox()
        Me.PictureStar5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtSend
        '
        Me.BtSend.Location = New System.Drawing.Point(155, 29)
        Me.BtSend.Name = "BtSend"
        Me.BtSend.Size = New System.Drawing.Size(41, 23)
        Me.BtSend.TabIndex = 0
        Me.BtSend.Text = "Go !"
        Me.BtSend.UseVisualStyleBackColor = True
        '
        'TxtUrl
        '
        Me.TxtUrl.Location = New System.Drawing.Point(6, 17)
        Me.TxtUrl.Name = "TxtUrl"
        Me.TxtUrl.Size = New System.Drawing.Size(135, 20)
        Me.TxtUrl.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Date de sortie :"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(278, 80)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(0, 13)
        Me.LblDate.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Réalisateur :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Genre 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Genre 2 :"
        '
        'LblRealisateur
        '
        Me.LblRealisateur.AutoSize = True
        Me.LblRealisateur.Location = New System.Drawing.Point(278, 113)
        Me.LblRealisateur.Name = "LblRealisateur"
        Me.LblRealisateur.Size = New System.Drawing.Size(0, 13)
        Me.LblRealisateur.TabIndex = 12
        '
        'LblGenre1
        '
        Me.LblGenre1.AutoSize = True
        Me.LblGenre1.Location = New System.Drawing.Point(278, 146)
        Me.LblGenre1.Name = "LblGenre1"
        Me.LblGenre1.Size = New System.Drawing.Size(0, 13)
        Me.LblGenre1.TabIndex = 13
        '
        'LblGenre2
        '
        Me.LblGenre2.AutoSize = True
        Me.LblGenre2.Location = New System.Drawing.Point(278, 180)
        Me.LblGenre2.Name = "LblGenre2"
        Me.LblGenre2.Size = New System.Drawing.Size(0, 13)
        Me.LblGenre2.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Acteurs :"
        '
        'TxtResponse
        '
        Me.TxtResponse.Location = New System.Drawing.Point(6, 19)
        Me.TxtResponse.Multiline = True
        Me.TxtResponse.Name = "TxtResponse"
        Me.TxtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtResponse.Size = New System.Drawing.Size(365, 404)
        Me.TxtResponse.TabIndex = 3
        '
        'TxtSynopsis
        '
        Me.TxtSynopsis.Location = New System.Drawing.Point(6, 19)
        Me.TxtSynopsis.Multiline = True
        Me.TxtSynopsis.Name = "TxtSynopsis"
        Me.TxtSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtSynopsis.Size = New System.Drawing.Size(416, 129)
        Me.TxtSynopsis.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSynopsis)
        Me.GroupBox2.Location = New System.Drawing.Point(210, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 157)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Synopsis :"
        '
        'Picture
        '
        Me.Picture.Location = New System.Drawing.Point(12, 19)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(165, 212)
        Me.Picture.TabIndex = 19
        Me.Picture.TabStop = False
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.HorizontalScrollbar = True
        Me.ListBox.Location = New System.Drawing.Point(7, 21)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(182, 342)
        Me.ListBox.TabIndex = 20
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.StatusProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 449)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1049, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(21, 17)
        Me.StatusLabel.Text = "OK"
        '
        'StatusProgressBar
        '
        Me.StatusProgressBar.Name = "StatusProgressBar"
        Me.StatusProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.StatusProgressBar.Visible = False
        '
        'TxtActeurs
        '
        Me.TxtActeurs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtActeurs.Location = New System.Drawing.Point(491, 220)
        Me.TxtActeurs.Multiline = True
        Me.TxtActeurs.Name = "TxtActeurs"
        Me.TxtActeurs.ReadOnly = True
        Me.TxtActeurs.Size = New System.Drawing.Size(141, 55)
        Me.TxtActeurs.TabIndex = 22
        '
        'TxtTitre
        '
        Me.TxtTitre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitre.Location = New System.Drawing.Point(410, 33)
        Me.TxtTitre.Multiline = True
        Me.TxtTitre.Name = "TxtTitre"
        Me.TxtTitre.ReadOnly = True
        Me.TxtTitre.Size = New System.Drawing.Size(86, 56)
        Me.TxtTitre.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelWebLink)
        Me.GroupBox1.Controls.Add(Me.PictureStar1)
        Me.GroupBox1.Controls.Add(Me.PictureStar2)
        Me.GroupBox1.Controls.Add(Me.PictureStar3)
        Me.GroupBox1.Controls.Add(Me.PictureStar4)
        Me.GroupBox1.Controls.Add(Me.PictureStar5)
        Me.GroupBox1.Controls.Add(Me.Picture)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblGenre2)
        Me.GroupBox1.Controls.Add(Me.LblGenre1)
        Me.GroupBox1.Controls.Add(Me.LblRealisateur)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LblDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 269)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiche détaillée :"
        '
        'LabelWebLink
        '
        Me.LabelWebLink.AutoSize = True
        Me.LabelWebLink.Location = New System.Drawing.Point(287, 27)
        Me.LabelWebLink.Name = "LabelWebLink"
        Me.LabelWebLink.Size = New System.Drawing.Size(73, 13)
        Me.LabelWebLink.TabIndex = 29
        Me.LabelWebLink.TabStop = True
        Me.LabelWebLink.Text = "Fiche Allociné"
        '
        'PictureStar1
        '
        Me.PictureStar1.Location = New System.Drawing.Point(17, 237)
        Me.PictureStar1.Name = "PictureStar1"
        Me.PictureStar1.Size = New System.Drawing.Size(26, 26)
        Me.PictureStar1.TabIndex = 24
        Me.PictureStar1.TabStop = False
        '
        'PictureStar2
        '
        Me.PictureStar2.Location = New System.Drawing.Point(47, 237)
        Me.PictureStar2.Name = "PictureStar2"
        Me.PictureStar2.Size = New System.Drawing.Size(26, 26)
        Me.PictureStar2.TabIndex = 23
        Me.PictureStar2.TabStop = False
        '
        'PictureStar3
        '
        Me.PictureStar3.Location = New System.Drawing.Point(79, 237)
        Me.PictureStar3.Name = "PictureStar3"
        Me.PictureStar3.Size = New System.Drawing.Size(26, 26)
        Me.PictureStar3.TabIndex = 22
        Me.PictureStar3.TabStop = False
        '
        'PictureStar4
        '
        Me.PictureStar4.Location = New System.Drawing.Point(111, 237)
        Me.PictureStar4.Name = "PictureStar4"
        Me.PictureStar4.Size = New System.Drawing.Size(26, 26)
        Me.PictureStar4.TabIndex = 21
        Me.PictureStar4.TabStop = False
        '
        'PictureStar5
        '
        Me.PictureStar5.Location = New System.Drawing.Point(143, 237)
        Me.PictureStar5.Name = "PictureStar5"
        Me.PictureStar5.Size = New System.Drawing.Size(26, 26)
        Me.PictureStar5.TabIndex = 20
        Me.PictureStar5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtUrl)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 54)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBox)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(196, 372)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Liste de films : "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtResponse)
        Me.GroupBox5.Location = New System.Drawing.Point(644, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(377, 432)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Xml :"
        '
        'Allocine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 471)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TxtTitre)
        Me.Controls.Add(Me.TxtActeurs)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtSend)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Allocine"
        Me.Text = "App Allocine"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureStar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtSend As System.Windows.Forms.Button
    Friend WithEvents TxtUrl As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblRealisateur As System.Windows.Forms.Label
    Friend WithEvents LblGenre1 As System.Windows.Forms.Label
    Friend WithEvents LblGenre2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtResponse As System.Windows.Forms.TextBox
    Friend WithEvents TxtSynopsis As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TxtActeurs As System.Windows.Forms.TextBox
    Friend WithEvents TxtTitre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureStar1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureStar2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureStar3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureStar4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureStar5 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelWebLink As System.Windows.Forms.LinkLabel

End Class
