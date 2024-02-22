<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstallXAPK
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallXAPK))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ApplicationTotalSizeLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ApplicationVersionLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AndroidMinimumVersionLbl = New System.Windows.Forms.Label()
        Me.PackageNameLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ApplicationNameLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DeviceNameLbl = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.LblWarning = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select XAPK File:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(347, 56)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(568, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(924, 54)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ApplicationTotalSizeLbl)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ApplicationVersionLbl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.AndroidMinimumVersionLbl)
        Me.GroupBox1.Controls.Add(Me.PackageNameLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ApplicationNameLbl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(796, 212)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "XAPK Informations"
        '
        'ApplicationTotalSizeLbl
        '
        Me.ApplicationTotalSizeLbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTotalSizeLbl.Location = New System.Drawing.Point(128, 160)
        Me.ApplicationTotalSizeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ApplicationTotalSizeLbl.Name = "ApplicationTotalSizeLbl"
        Me.ApplicationTotalSizeLbl.Size = New System.Drawing.Size(208, 16)
        Me.ApplicationTotalSizeLbl.TabIndex = 9
        Me.ApplicationTotalSizeLbl.Text = "{0} MB"
        Me.ApplicationTotalSizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ApplicationTotalSizeLbl.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Application Size:"
        '
        'ApplicationVersionLbl
        '
        Me.ApplicationVersionLbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationVersionLbl.Location = New System.Drawing.Point(140, 140)
        Me.ApplicationVersionLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ApplicationVersionLbl.Name = "ApplicationVersionLbl"
        Me.ApplicationVersionLbl.Size = New System.Drawing.Size(156, 16)
        Me.ApplicationVersionLbl.TabIndex = 7
        Me.ApplicationVersionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Application Version: "
        '
        'AndroidMinimumVersionLbl
        '
        Me.AndroidMinimumVersionLbl.AutoSize = True
        Me.AndroidMinimumVersionLbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AndroidMinimumVersionLbl.Location = New System.Drawing.Point(125, 79)
        Me.AndroidMinimumVersionLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AndroidMinimumVersionLbl.Name = "AndroidMinimumVersionLbl"
        Me.AndroidMinimumVersionLbl.Size = New System.Drawing.Size(149, 14)
        Me.AndroidMinimumVersionLbl.TabIndex = 5
        Me.AndroidMinimumVersionLbl.Text = "Requires Android {0}+"
        '
        'PackageNameLbl
        '
        Me.PackageNameLbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PackageNameLbl.Location = New System.Drawing.Point(232, 50)
        Me.PackageNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PackageNameLbl.Name = "PackageNameLbl"
        Me.PackageNameLbl.Size = New System.Drawing.Size(437, 16)
        Me.PackageNameLbl.TabIndex = 4
        Me.PackageNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Package Name:"
        '
        'ApplicationNameLbl
        '
        Me.ApplicationNameLbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationNameLbl.Location = New System.Drawing.Point(244, 34)
        Me.ApplicationNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ApplicationNameLbl.Name = "ApplicationNameLbl"
        Me.ApplicationNameLbl.Size = New System.Drawing.Size(437, 16)
        Me.ApplicationNameLbl.TabIndex = 2
        Me.ApplicationNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Application Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(20, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblStatus)
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(222, 330)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(795, 100)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Installation Progress"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(68, 30)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(26, 16)
        Me.LblStatus.TabIndex = 2
        Me.LblStatus.Text = "      "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(756, 18)
        Me.ProgressBar1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Status: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 588)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Device Connected: "
        '
        'DeviceNameLbl
        '
        Me.DeviceNameLbl.AutoSize = True
        Me.DeviceNameLbl.Location = New System.Drawing.Point(347, 588)
        Me.DeviceNameLbl.Name = "DeviceNameLbl"
        Me.DeviceNameLbl.Size = New System.Drawing.Size(49, 16)
        Me.DeviceNameLbl.TabIndex = 0
        Me.DeviceNameLbl.Text = "Label9"
        '
        'BackgroundWorker1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 424)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(0, 199)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(200, 415)
        Me.PictureBox9.TabIndex = 24
        Me.PictureBox9.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(219, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Install Application"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(913, 436)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BackgroundWorker2
        '
        '
        'BackgroundWorker3
        '
        '
        'LblWarning
        '
        Me.LblWarning.AutoSize = True
        Me.LblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarning.ForeColor = System.Drawing.Color.Red
        Me.LblWarning.Location = New System.Drawing.Point(219, 486)
        Me.LblWarning.Name = "LblWarning"
        Me.LblWarning.Size = New System.Drawing.Size(764, 13)
        Me.LblWarning.TabIndex = 28
        Me.LblWarning.Text = "WARNING: Do not disconnect your device while installing the application, this may" &
    " make your device unstable and corrupt your data!"
        Me.LblWarning.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Plum
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(189, 33)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(491, 3)
        Me.PictureBox8.TabIndex = 30
        Me.PictureBox8.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Select the XAPK file to Install..."
        '
        'InstallXAPK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1029, 613)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblWarning)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DeviceNameLbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "InstallXAPK"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XAPK Installer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ApplicationTotalSizeLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ApplicationVersionLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AndroidMinimumVersionLbl As Label
    Friend WithEvents PackageNameLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ApplicationNameLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DeviceNameLbl As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LblStatus As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblWarning As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label6 As Label
End Class
