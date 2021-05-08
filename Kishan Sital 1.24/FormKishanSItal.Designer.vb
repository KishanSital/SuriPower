<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKishanSital
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKishanSital))
        Me.lblbegin = New System.Windows.Forms.Label()
        Me.txtBegin = New System.Windows.Forms.TextBox()
        Me.lblEindStand = New System.Windows.Forms.Label()
        Me.txtEind = New System.Windows.Forms.TextBox()
        Me.Fase = New System.Windows.Forms.Label()
        Me.lblVerbruik = New System.Windows.Forms.Label()
        Me.lblRekening = New System.Windows.Forms.Label()
        Me.lblFasebedrag = New System.Windows.Forms.Label()
        Me.lblTotaal = New System.Windows.Forms.Label()
        Me.btninfo = New System.Windows.Forms.Button()
        Me.lblnaam = New System.Windows.Forms.Label()
        Me.btnBerekenen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCalculator = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSluiten = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblVerbruikValue = New System.Windows.Forms.Label()
        Me.lblRekeningValue = New System.Windows.Forms.Label()
        Me.lblFaseValue = New System.Windows.Forms.Label()
        Me.ComboboxFase = New System.Windows.Forms.ComboBox()
        Me.Labeltotaal = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbegin
        '
        Me.lblbegin.AutoSize = True
        Me.lblbegin.BackColor = System.Drawing.Color.Green
        Me.lblbegin.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbegin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblbegin.Location = New System.Drawing.Point(64, 174)
        Me.lblbegin.Name = "lblbegin"
        Me.lblbegin.Size = New System.Drawing.Size(119, 20)
        Me.lblbegin.TabIndex = 2
        Me.lblbegin.Text = "Beginstand"
        '
        'txtBegin
        '
        Me.txtBegin.BackColor = System.Drawing.Color.Cyan
        Me.txtBegin.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBegin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBegin.Location = New System.Drawing.Point(196, 171)
        Me.txtBegin.Name = "txtBegin"
        Me.txtBegin.Size = New System.Drawing.Size(135, 32)
        Me.txtBegin.TabIndex = 3
        '
        'lblEindStand
        '
        Me.lblEindStand.AutoSize = True
        Me.lblEindStand.BackColor = System.Drawing.Color.Green
        Me.lblEindStand.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEindStand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblEindStand.Location = New System.Drawing.Point(383, 174)
        Me.lblEindStand.Name = "lblEindStand"
        Me.lblEindStand.Size = New System.Drawing.Size(108, 20)
        Me.lblEindStand.TabIndex = 4
        Me.lblEindStand.Text = "Eindstand"
        '
        'txtEind
        '
        Me.txtEind.BackColor = System.Drawing.Color.Cyan
        Me.txtEind.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEind.Location = New System.Drawing.Point(516, 171)
        Me.txtEind.Name = "txtEind"
        Me.txtEind.Size = New System.Drawing.Size(134, 32)
        Me.txtEind.TabIndex = 7
        '
        'Fase
        '
        Me.Fase.AutoSize = True
        Me.Fase.BackColor = System.Drawing.Color.Green
        Me.Fase.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Fase.Location = New System.Drawing.Point(64, 218)
        Me.Fase.Name = "Fase"
        Me.Fase.Size = New System.Drawing.Size(50, 20)
        Me.Fase.TabIndex = 6
        Me.Fase.Text = "Fase"
        '
        'lblVerbruik
        '
        Me.lblVerbruik.AutoSize = True
        Me.lblVerbruik.BackColor = System.Drawing.Color.Green
        Me.lblVerbruik.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerbruik.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblVerbruik.Location = New System.Drawing.Point(317, 265)
        Me.lblVerbruik.Name = "lblVerbruik"
        Me.lblVerbruik.Size = New System.Drawing.Size(99, 20)
        Me.lblVerbruik.TabIndex = 8
        Me.lblVerbruik.Text = "Verbruik"
        '
        'lblRekening
        '
        Me.lblRekening.AutoSize = True
        Me.lblRekening.BackColor = System.Drawing.Color.Green
        Me.lblRekening.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRekening.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRekening.Location = New System.Drawing.Point(317, 308)
        Me.lblRekening.Name = "lblRekening"
        Me.lblRekening.Size = New System.Drawing.Size(97, 20)
        Me.lblRekening.TabIndex = 10
        Me.lblRekening.Text = "Rekening"
        '
        'lblFasebedrag
        '
        Me.lblFasebedrag.AutoSize = True
        Me.lblFasebedrag.BackColor = System.Drawing.Color.Green
        Me.lblFasebedrag.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFasebedrag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFasebedrag.Location = New System.Drawing.Point(317, 344)
        Me.lblFasebedrag.Name = "lblFasebedrag"
        Me.lblFasebedrag.Size = New System.Drawing.Size(124, 20)
        Me.lblFasebedrag.TabIndex = 12
        Me.lblFasebedrag.Text = "Fase bedrag"
        '
        'lblTotaal
        '
        Me.lblTotaal.AutoSize = True
        Me.lblTotaal.BackColor = System.Drawing.Color.Yellow
        Me.lblTotaal.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotaal.ForeColor = System.Drawing.Color.Black
        Me.lblTotaal.Location = New System.Drawing.Point(317, 409)
        Me.lblTotaal.Name = "lblTotaal"
        Me.lblTotaal.Size = New System.Drawing.Size(75, 20)
        Me.lblTotaal.TabIndex = 14
        Me.lblTotaal.Text = "Totaal"
        '
        'btninfo
        '
        Me.btninfo.BackColor = System.Drawing.Color.Black
        Me.btninfo.Cursor = System.Windows.Forms.Cursors.Help
        Me.btninfo.ForeColor = System.Drawing.Color.Red
        Me.btninfo.Image = CType(resources.GetObject("btninfo.Image"), System.Drawing.Image)
        Me.btninfo.Location = New System.Drawing.Point(268, 82)
        Me.btninfo.Name = "btninfo"
        Me.btninfo.Size = New System.Drawing.Size(173, 65)
        Me.btninfo.TabIndex = 16
        Me.btninfo.UseVisualStyleBackColor = False
        '
        'lblnaam
        '
        Me.lblnaam.AutoSize = True
        Me.lblnaam.BackColor = System.Drawing.Color.Transparent
        Me.lblnaam.Font = New System.Drawing.Font("Wide Latin", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnaam.ForeColor = System.Drawing.Color.Red
        Me.lblnaam.Location = New System.Drawing.Point(169, 23)
        Me.lblnaam.Name = "lblnaam"
        Me.lblnaam.Size = New System.Drawing.Size(382, 46)
        Me.lblnaam.TabIndex = 0
        Me.lblnaam.Text = "Suri Power"
        '
        'btnBerekenen
        '
        Me.btnBerekenen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBerekenen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnBerekenen.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBerekenen.ForeColor = System.Drawing.Color.Black
        Me.btnBerekenen.Location = New System.Drawing.Point(250, 469)
        Me.btnBerekenen.Name = "btnBerekenen"
        Me.btnBerekenen.Size = New System.Drawing.Size(226, 62)
        Me.btnBerekenen.TabIndex = 39
        Me.btnBerekenen.Text = "Berekenen"
        Me.btnBerekenen.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 91)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'BtnCalculator
        '
        Me.BtnCalculator.BackColor = System.Drawing.Color.Red
        Me.BtnCalculator.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnCalculator.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculator.ForeColor = System.Drawing.Color.Black
        Me.BtnCalculator.Location = New System.Drawing.Point(4, 469)
        Me.BtnCalculator.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCalculator.Name = "BtnCalculator"
        Me.BtnCalculator.Size = New System.Drawing.Size(226, 61)
        Me.BtnCalculator.TabIndex = 41
        Me.BtnCalculator.Text = "Extra calculator"
        Me.BtnCalculator.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 48)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'btnSluiten
        '
        Me.btnSluiten.BackColor = System.Drawing.Color.Red
        Me.btnSluiten.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnSluiten.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSluiten.ForeColor = System.Drawing.Color.Black
        Me.btnSluiten.Location = New System.Drawing.Point(490, 469)
        Me.btnSluiten.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSluiten.Name = "btnSluiten"
        Me.btnSluiten.Size = New System.Drawing.Size(223, 61)
        Me.btnSluiten.TabIndex = 43
        Me.btnSluiten.Text = "Sluit Programma"
        Me.btnSluiten.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(611, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(102, 91)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'lblVerbruikValue
        '
        Me.lblVerbruikValue.BackColor = System.Drawing.Color.Aqua
        Me.lblVerbruikValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVerbruikValue.Cursor = System.Windows.Forms.Cursors.No
        Me.lblVerbruikValue.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerbruikValue.ForeColor = System.Drawing.Color.Green
        Me.lblVerbruikValue.Location = New System.Drawing.Point(490, 264)
        Me.lblVerbruikValue.Name = "lblVerbruikValue"
        Me.lblVerbruikValue.Size = New System.Drawing.Size(134, 30)
        Me.lblVerbruikValue.TabIndex = 45
        '
        'lblRekeningValue
        '
        Me.lblRekeningValue.BackColor = System.Drawing.Color.Aqua
        Me.lblRekeningValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRekeningValue.Cursor = System.Windows.Forms.Cursors.No
        Me.lblRekeningValue.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRekeningValue.ForeColor = System.Drawing.Color.Green
        Me.lblRekeningValue.Location = New System.Drawing.Point(490, 303)
        Me.lblRekeningValue.Name = "lblRekeningValue"
        Me.lblRekeningValue.Size = New System.Drawing.Size(134, 30)
        Me.lblRekeningValue.TabIndex = 46
        '
        'lblFaseValue
        '
        Me.lblFaseValue.BackColor = System.Drawing.Color.Aqua
        Me.lblFaseValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFaseValue.Cursor = System.Windows.Forms.Cursors.No
        Me.lblFaseValue.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaseValue.ForeColor = System.Drawing.Color.Green
        Me.lblFaseValue.Location = New System.Drawing.Point(490, 343)
        Me.lblFaseValue.Name = "lblFaseValue"
        Me.lblFaseValue.Size = New System.Drawing.Size(134, 30)
        Me.lblFaseValue.TabIndex = 47
        '
        'ComboboxFase
        '
        Me.ComboboxFase.AllowDrop = True
        Me.ComboboxFase.BackColor = System.Drawing.Color.Aqua
        Me.ComboboxFase.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ComboboxFase.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboboxFase.ForeColor = System.Drawing.Color.Navy
        Me.ComboboxFase.FormattingEnabled = True
        Me.ComboboxFase.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboboxFase.Location = New System.Drawing.Point(196, 213)
        Me.ComboboxFase.Name = "ComboboxFase"
        Me.ComboboxFase.Size = New System.Drawing.Size(135, 33)
        Me.ComboboxFase.TabIndex = 49
        '
        'Labeltotaal
        '
        Me.Labeltotaal.BackColor = System.Drawing.Color.Aqua
        Me.Labeltotaal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labeltotaal.Cursor = System.Windows.Forms.Cursors.No
        Me.Labeltotaal.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotaal.ForeColor = System.Drawing.Color.Black
        Me.Labeltotaal.Location = New System.Drawing.Point(490, 409)
        Me.Labeltotaal.Name = "Labeltotaal"
        Me.Labeltotaal.Size = New System.Drawing.Size(134, 30)
        Me.Labeltotaal.TabIndex = 50
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(68, 289)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 51
        '
        'frmKishanSital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(721, 537)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Labeltotaal)
        Me.Controls.Add(Me.ComboboxFase)
        Me.Controls.Add(Me.lblFaseValue)
        Me.Controls.Add(Me.lblRekeningValue)
        Me.Controls.Add(Me.lblVerbruikValue)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnSluiten)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnCalculator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBerekenen)
        Me.Controls.Add(Me.btninfo)
        Me.Controls.Add(Me.lblTotaal)
        Me.Controls.Add(Me.lblFasebedrag)
        Me.Controls.Add(Me.lblRekening)
        Me.Controls.Add(Me.lblVerbruik)
        Me.Controls.Add(Me.txtEind)
        Me.Controls.Add(Me.Fase)
        Me.Controls.Add(Me.lblEindStand)
        Me.Controls.Add(Me.txtBegin)
        Me.Controls.Add(Me.lblbegin)
        Me.Controls.Add(Me.lblnaam)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKishanSital"
        Me.Text = " Kishan Sital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbegin As Label
    Friend WithEvents txtBegin As TextBox
    Friend WithEvents lblEindStand As Label
    Friend WithEvents txtEind As TextBox
    Friend WithEvents Fase As Label
    Friend WithEvents lblVerbruik As Label
    Friend WithEvents lblRekening As Label
    Friend WithEvents lblFasebedrag As Label
    Friend WithEvents lblTotaal As Label
    Friend WithEvents btninfo As Button
    Friend WithEvents lblnaam As Label
    Friend WithEvents btnBerekenen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCalculator As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSluiten As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblVerbruikValue As Label
    Friend WithEvents lblRekeningValue As Label
    Friend WithEvents lblFaseValue As Label
    Friend WithEvents ComboboxFase As ComboBox
    Friend WithEvents Labeltotaal As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
