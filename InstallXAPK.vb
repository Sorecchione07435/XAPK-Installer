Imports SharpAdbClient
Imports System.ComponentModel
Imports System.IO.Compression
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class InstallXAPK
    Dim WithEvents client As New AdbClient

    Dim XAPKFilePath As String
    Dim TempPath As String = IO.Path.GetTempPath
    Dim FileOpened As Boolean = False
    Dim InstallationBusy As Boolean = False
    Private Sub InstallXAPK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim server As New AdbServer
        server.StartServer(Application.StartupPath & "\platform-tools\adb.exe", restartServerIfNewer:=False)

        ' Ottieni una lista dei dispositivi collegati
        Dim devices = client.GetDevices()
        Dim device As DeviceData = devices(0)

        DeviceNameLbl.Text = device.Model

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Extended Android Package Kit|*.xapk"
        OFD.Title = "Open XAPK"
        If OFD.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OFD.FileName
            XAPKFilePath = OFD.FileName
            FileOpened = True
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If My.Computer.FileSystem.DirectoryExists(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath)) = True Then
            My.Computer.FileSystem.DeleteDirectory(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath), FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        MkDir(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath))
        ZipFile.ExtractToDirectory(XAPKFilePath, TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath))
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.Enabled = False
        Unpacking.Show()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Unpacking.Hide()
        Me.Enabled = True

        If (Directory.GetFiles(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath), "*.apk").Length > 1) Then
            MsgBox("I'm sorry, but XAPK files as APK bundles are not supported with this installation, the XAPK file must contain OBB files", MsgBoxStyle.Critical, "Error")
            Exit Sub
            ' 0Me.RichTextBox1.ForeColor = Color.Red
        End If

        Dim jsonManifest As String = System.IO.File.ReadAllText(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath) & "\manifest.json")

        Dim json As JObject = JObject.Parse(jsonManifest)
        Dim xapk_version As Integer = json("xapk_version")
        Dim package_name As String = json("package_name")
        Dim name As String = json("name")
        Dim version_code As String = json("version_code")
        Dim version_name As String = json("version_name")
        Dim min_sdk_version As String = json("min_sdk_version")
        Dim target_sdk_version As String = json("target_sdk_version")
        Dim total_size As Integer = json("total_size")

        ApplicationNameLbl.Text = name
        PackageNameLbl.Text = package_name

        Select Case min_sdk_version
            Case 34
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, 14)
            Case 33
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, 13)
            Case 32
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "12L")
            Case 31
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "12")
            Case 30
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, 11)
            Case 29
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, 10)
            Case 28
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, 9)
            Case 27
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "8.1")
            Case 26
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "8.0")
            Case 25
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "7.1")
            Case 24
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "7.0")
            Case 23
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, 6)
            Case 22
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "5.1")
            Case 21
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "5.0")
            Case 20
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "4.4W")
            Case 19
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "4.4")
            Case 18
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "4.3")
            Case 17
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "4.2")
            Case 16
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "4.1")
            Case 15 Or 14
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "4.0")
            Case 13
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "3.2")
            Case 12
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "3.1")
            Case 11
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "3.0")
            Case 10
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "2.3.7")
            Case 9
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "2.3.2")
            Case 8
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "2.2")
            Case 7
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "2.1")
            Case 6
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "2.0.1")
            Case 5
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "2.0")
            Case 4
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "1.6")
            Case 3
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "1.5")
            Case 2
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "1.1")
            Case 1
                AndroidMinimumVersionLbl.Text = String.Format(AndroidMinimumVersionLbl.Text, "1.0")
        End Select

        ApplicationTotalSizeLbl.Show()

        ApplicationVersionLbl.Text = version_name

        Dim SizeinMegabytes As Double = Math.Round(total_size / 1048576, 2)

        ApplicationTotalSizeLbl.Text = SizeinMegabytes & " MB"
        PictureBox1.Image = New Bitmap(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath) & "\icon.png")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FileOpened = True Then
            PictureBox1.Image = Nothing
            Me.Refresh()
            Me.Focus()
            Try
                My.Computer.FileSystem.DeleteDirectory(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath), FileIO.DeleteDirectoryOption.DeleteAllContents)
                End
            Catch ex As Exception
                End
            End Try
        Else
            End
        End If
    End Sub

    Private Sub InstallXAPK_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If InstallationBusy = True Then
            MsgBox("An application is installing, please wait for the installation to finish", MsgBoxStyle.Critical, "Application Busy")
            e.Cancel = True
        End If
        If FileOpened = True Then
            PictureBox1.Image = Nothing
            Me.Refresh()
            Me.Focus()
            Try
                My.Computer.FileSystem.DeleteDirectory(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath), FileIO.DeleteDirectoryOption.DeleteAllContents)
                End
            Catch ex As Exception
                End
            End Try
        Else
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InstallationBusy = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        LblWarning.Show()

        ProgressBar1.Value = 30
        LblStatus.Text = "Installing APK on device..."
        BackgroundWorker2.RunWorkerAsync()

    End Sub

    Function adb(ByVal Arguments As String) As String
        Try

            Dim My_Process As New Process()
            Dim My_Process_Info As New ProcessStartInfo()

            My_Process_Info.FileName = "adb.exe" ' Process filename
            My_Process_Info.Arguments = Arguments ' Process arguments
            My_Process_Info.WorkingDirectory = Application.StartupPath & "\platform-tools"
            My_Process_Info.CreateNoWindow = True  ' Show or hide the process Window
            My_Process_Info.UseShellExecute = False ' Don't use system shell to execute the process
            My_Process_Info.RedirectStandardOutput = True  '  Redirect (1) Output
            My_Process_Info.RedirectStandardError = True  ' Redirect non (1) Output

            My_Process.EnableRaisingEvents = True ' Raise events
            My_Process.StartInfo = My_Process_Info
            My_Process.Start() ' Run the process NOW

            Dim Process_ErrorOutput As String = My_Process.StandardOutput.ReadToEnd() ' Stores the Error Output (If any)
            Dim Process_StandardOutput As String = My_Process.StandardOutput.ReadToEnd() ' Stores the Standard Output (If any)

            ' Return output by priority
            If Process_ErrorOutput IsNot Nothing Then Return Process_ErrorOutput ' Returns the ErrorOutput (if any)
            If Process_StandardOutput IsNot Nothing Then Return Process_StandardOutput ' Returns the StandardOutput (if any)

        Catch ex As Exception
            Return ex.Message
        End Try

        Return "OK"

    End Function

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim jsonManifest As String = System.IO.File.ReadAllText(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath) & "\manifest.json")

        Dim json As JObject = JObject.Parse(jsonManifest)
        Dim package_name As String = json("package_name")

        Dim apkFilePath As String = TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath) & "\" & package_name & ".apk"
        adb("install """ & apkFilePath & """")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        ProgressBar1.Value = 60
        LblStatus.Text = "Copying OBB Expansions Files..."
        BackgroundWorker3.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Dim jsonManifest As String = System.IO.File.ReadAllText(TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath) & "\manifest.json")

        Dim json As JObject = JObject.Parse(jsonManifest)
        Dim package_name As String = json("package_name")

        adb("push """ & TempPath & "\" & IO.Path.GetFileNameWithoutExtension(XAPKFilePath) & "\Android\obb\" & package_name & """" & " /storage/emulated/0/Android/obb/" & package_name)
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        InstallationBusy = False
        LblWarning.Hide()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        LblStatus.Text = "Done!"
        ProgressBar1.Value = 100
        MsgBox("Application Installed Successfully!")
        ProgressBar1.Value = 0
    End Sub
End Class