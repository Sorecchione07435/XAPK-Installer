<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeviceConnection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeviceConnection))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RAMLbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CPUNameLbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AndroidVersionLbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DeviceRecognized = New System.Windows.Forms.Panel()
        Me.InternalMemoryLbl = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeviceNameLbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeviceNotRecognizedError = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeviceRecognized.SuspendLayout()
        Me.DeviceNotRecognizedError.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Olive
        Me.Label15.Location = New System.Drawing.Point(13, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(332, 21)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "It looks like your device is working properly!"
        '
        'RAMLbl
        '
        Me.RAMLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMLbl.Location = New System.Drawing.Point(63, 150)
        Me.RAMLbl.Name = "RAMLbl"
        Me.RAMLbl.Size = New System.Drawing.Size(193, 21)
        Me.RAMLbl.TabIndex = 11
        Me.RAMLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "RAM:"
        '
        'CPUNameLbl
        '
        Me.CPUNameLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUNameLbl.Location = New System.Drawing.Point(60, 113)
        Me.CPUNameLbl.Name = "CPUNameLbl"
        Me.CPUNameLbl.Size = New System.Drawing.Size(305, 21)
        Me.CPUNameLbl.TabIndex = 5
        Me.CPUNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "CPU: "
        '
        'AndroidVersionLbl
        '
        Me.AndroidVersionLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AndroidVersionLbl.Location = New System.Drawing.Point(137, 79)
        Me.AndroidVersionLbl.Name = "AndroidVersionLbl"
        Me.AndroidVersionLbl.Size = New System.Drawing.Size(308, 21)
        Me.AndroidVersionLbl.TabIndex = 3
        Me.AndroidVersionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Android Version:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Device Name:"
        '
        'DeviceRecognized
        '
        Me.DeviceRecognized.Controls.Add(Me.Label2)
        Me.DeviceRecognized.Controls.Add(Me.Label1)
        Me.DeviceRecognized.Controls.Add(Me.InternalMemoryLbl)
        Me.DeviceRecognized.Controls.Add(Me.Label16)
        Me.DeviceRecognized.Controls.Add(Me.Label15)
        Me.DeviceRecognized.Controls.Add(Me.RAMLbl)
        Me.DeviceRecognized.Controls.Add(Me.Label14)
        Me.DeviceRecognized.Controls.Add(Me.CPUNameLbl)
        Me.DeviceRecognized.Controls.Add(Me.Button1)
        Me.DeviceRecognized.Controls.Add(Me.Label13)
        Me.DeviceRecognized.Controls.Add(Me.AndroidVersionLbl)
        Me.DeviceRecognized.Controls.Add(Me.Label12)
        Me.DeviceRecognized.Controls.Add(Me.DeviceNameLbl)
        Me.DeviceRecognized.Controls.Add(Me.Label11)
        Me.DeviceRecognized.Location = New System.Drawing.Point(205, 203)
        Me.DeviceRecognized.Name = "DeviceRecognized"
        Me.DeviceRecognized.Size = New System.Drawing.Size(549, 350)
        Me.DeviceRecognized.TabIndex = 14
        Me.DeviceRecognized.Visible = False
        '
        'InternalMemoryLbl
        '
        Me.InternalMemoryLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InternalMemoryLbl.Location = New System.Drawing.Point(140, 187)
        Me.InternalMemoryLbl.Name = "InternalMemoryLbl"
        Me.InternalMemoryLbl.Size = New System.Drawing.Size(230, 21)
        Me.InternalMemoryLbl.TabIndex = 18
        Me.InternalMemoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 20)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Internal Memory:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(435, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 25)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DeviceNameLbl
        '
        Me.DeviceNameLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceNameLbl.Location = New System.Drawing.Point(120, 46)
        Me.DeviceNameLbl.Name = "DeviceNameLbl"
        Me.DeviceNameLbl.Size = New System.Drawing.Size(257, 21)
        Me.DeviceNameLbl.TabIndex = 1
        Me.DeviceNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(358, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Please check that these errors do not occur and try again"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(11, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(500, 54)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "3) USB Debugging is not enabled or ADB drivers are not installed or not working p" &
    "roperly"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(11, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(315, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "2) No device has been connected to the computer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(11, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "1) The device is too slow"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(11, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(500, 46)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Unfortunately it was not possible to find or detect a device on the computer, thi" &
    "s may have occurred for several reasons:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "There was a problem detecting a device!"
        '
        'DeviceNotRecognizedError
        '
        Me.DeviceNotRecognizedError.Controls.Add(Me.Label10)
        Me.DeviceNotRecognizedError.Controls.Add(Me.Label9)
        Me.DeviceNotRecognizedError.Controls.Add(Me.Label8)
        Me.DeviceNotRecognizedError.Controls.Add(Me.Label7)
        Me.DeviceNotRecognizedError.Controls.Add(Me.Label6)
        Me.DeviceNotRecognizedError.Controls.Add(Me.Label5)
        Me.DeviceNotRecognizedError.Location = New System.Drawing.Point(205, 205)
        Me.DeviceNotRecognizedError.Name = "DeviceNotRecognizedError"
        Me.DeviceNotRecognizedError.Size = New System.Drawing.Size(550, 348)
        Me.DeviceNotRecognizedError.TabIndex = 16
        Me.DeviceNotRecognizedError.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Please connect your device..."
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(632, 579)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Restart"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(209, 579)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "About"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Plum
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(164, 33)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(491, 3)
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.XAPK_Installer.My.Resources.Resources.loading
        Me.PictureBox2.Location = New System.Drawing.Point(456, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.XAPK_Installer.My.Resources.Resources._20130711035156_60427
        Me.PictureBox7.Location = New System.Drawing.Point(269, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(412, 144)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(-1, 200)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(200, 415)
        Me.PictureBox9.TabIndex = 22
        Me.PictureBox9.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 43)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "After the next window it is not recommended to disconnect the device even if you " &
    "are not installing an application to avoid having flaws"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Warning!"
        '
        'DeviceConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 614)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DeviceRecognized)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DeviceNotRecognizedError)
        Me.Controls.Add(Me.PictureBox9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DeviceConnection"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XAPK Installer"
        Me.DeviceRecognized.ResumeLayout(False)
        Me.DeviceRecognized.PerformLayout()
        Me.DeviceNotRecognizedError.ResumeLayout(False)
        Me.DeviceNotRecognizedError.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents RAMLbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CPUNameLbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents AndroidVersionLbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DeviceRecognized As Panel
    Friend WithEvents DeviceNameLbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DeviceNotRecognizedError As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents InternalMemoryLbl As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
