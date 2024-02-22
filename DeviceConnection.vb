Imports System.Collections.Generic
Imports System.Text
Imports System.Threading.Tasks
Imports SharpAdbClient
Public Class DeviceConnection
    Dim Time As New ProgressBar

    Dim WithEvents client As New AdbClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\platform-tools\adb.exe") = False Then
            MsgBox("The ADB executable was not found, the application will close immediately", MsgBoxStyle.Critical, "Critical Error")
            End
        End If

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Increment(1)

        If Time.Value = 100 Then
            Dim server As New AdbServer

            server.StartServer(Application.StartupPath & "\platform-tools\adb.exe", restartServerIfNewer:=False)

            Dim devices = client.GetDevices()
            If devices IsNot Nothing AndAlso devices.Count > 0 Then

                Try
                    Dim device As DeviceData = devices(0)

                    Dim receiverCPUName As New ConsoleOutputReceiver()
                    Dim receiverAndroidVersion As New ConsoleOutputReceiver()
                    Dim receiverTotalMemory As New ConsoleOutputReceiver()
                    Dim receiverStorageFreeMemory As New ConsoleOutputReceiver()
                    Dim receiverStorageTotalMemory As New ConsoleOutputReceiver()

                    client.ExecuteRemoteCommand("getprop ro.build.version.release", device, receiverAndroidVersion)
                    client.ExecuteRemoteCommand("cat /proc/cpuinfo", device, receiverCPUName)
                    client.ExecuteRemoteCommand("cat /proc/meminfo", device, receiverTotalMemory)

                    Dim output As String = receiverTotalMemory.ToString()
                    Dim ramInfo As String = GetRAMInfo(output)

                    '0'9client.ExecuteRemoteCommand($"getprop", device, New ConsoleOutputReceiver())
                    '   ì device.
                    PictureBox2.Image = New Bitmap(My.Resources._50px_Gtk_ok_svg)
                    DeviceNameLbl.Text = device.Model
                    If receiverAndroidVersion.ToString.Contains("14") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString
                    ElseIf receiverAndroidVersion.ToString.Contains("13") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString
                    ElseIf receiverAndroidVersion.ToString.Contains("12") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString
                    ElseIf receiverAndroidVersion.ToString.Contains("11") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString
                    ElseIf receiverAndroidVersion.ToString.Contains("10") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString
                    ElseIf receiverAndroidVersion.ToString.Contains("9") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Pie"
                    ElseIf receiverAndroidVersion.ToString.Contains("8") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Oreo"
                    ElseIf receiverAndroidVersion.ToString.Contains("7") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Nougat"
                    ElseIf receiverAndroidVersion.ToString.Contains("6") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Marshmallow"
                    ElseIf receiverAndroidVersion.ToString.Contains("5") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Lollipop"
                    ElseIf receiverAndroidVersion.ToString.Contains("4.4") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Kitkat"
                    ElseIf receiverAndroidVersion.ToString.Contains("4.1") = True Or receiverAndroidVersion.ToString.Contains("4.2") = True Or receiverAndroidVersion.ToString.Contains("4.3") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Jellybean"
                    ElseIf receiverAndroidVersion.ToString.Contains("4.0") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Ice Cream Sandwich"
                    ElseIf receiverAndroidVersion.ToString.Contains("3") = True Then
                        AndroidVersionLbl.Text = "Android " & receiverAndroidVersion.ToString & " Honeycomb"
                    End If

                    CPUNameLbl.Text = GetProcessorName(receiverCPUName.ToString)
                    RAMLbl.Text = ramInfo & " MB"

                    client.ExecuteRemoteCommand("df /storage/emulated/0", device, receiverStorageFreeMemory)
                    client.ExecuteRemoteCommand("df /storage/emulated/0", device, receiverStorageTotalMemory)

                    Dim lines As String() = receiverStorageFreeMemory.ToString.Split(ControlChars.Lf)
                    Dim availableSpace As String = receiverStorageFreeMemory.ToString

                    For Each line As String In lines
                        If line.Contains("/storage/emulated/0") Then
                            Dim parts As String() = line.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                            If parts.Length >= 5 Then
                                availableSpace = parts(3)
                                Exit For
                            End If
                        End If
                    Next

                    Dim lines2 As String() = receiverStorageTotalMemory.ToString.Split(ControlChars.Lf)
                    For Each line As String In lines
                        If line.Contains("/storage/emulated/0") Then
                            ' Trova la riga che contiene "/storage/emulated/0"
                            Dim parts As String() = line.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                            If parts.Length >= 5 Then
                                ' Estrai la memoria totale dalla riga
                                Dim totalSpace As String = parts(1)
                                ' Stampa la memoria totale
                                'Console.WriteLine("Memoria totale: " & totalSpace)
                                InternalMemoryLbl.Text = availableSpace & "B of free space on " & totalSpace & "B"
                                Exit For
                            End If
                        End If
                    Next

                    If InternalMemoryLbl.Text = "" Then
                        InternalMemoryLbl.Text = "Error"
                        InternalMemoryLbl.ForeColor = Color.Red

                    End If

                    DeviceRecognized.Show()
                    Button1.Show()
                    Label3.Text = "Connected with " & device.Model
                    Timer1.Stop()
                Catch ex As Exception
                    PictureBox2.Image = New Bitmap(My.Resources.photo)
                    DeviceNotRecognizedError.Show()
                    Label3.Text = "Sorry, something went wrong."
                    Label3.ForeColor = Color.Red

                    Button2.Show()
                    Timer1.Stop()
                    Exit Sub
                End Try


            Else
                PictureBox2.Image = New Bitmap(My.Resources.photo)
                DeviceNotRecognizedError.Show()
                Label3.Text = "Sorry, something went wrong."
                Label3.ForeColor = Color.Red

                Button2.Show()
                Timer1.Stop()
            End If
        End If



    End Sub
    Private Function GetProcessorName(cpuinfo As String) As String
        Dim lines = cpuinfo.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        For Each line In lines
            If line.StartsWith("Processor") Then
                ' Estrai il nome del processore e rimuovi eventuali spazi iniziali e finali
                Return line.Split(":")(1).Trim()
            End If
        Next

        ' Se non viene trovato il nome del processore, restituisci una stringa vuota
        Return "Error!"
    End Function

    Private Function GetAndroidVersion(output As String) As String
        ' Dividi il risultato per righe
        Dim lines = output.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        ' Cerca la riga che contiene la versione Android
        For Each line In lines
            If line.StartsWith("[ro.build.version.release]") Then
                ' Estrai la versione Android dalla riga
                Return line.Split("["c)(1).Trim()
            End If
        Next

        ' Se non viene trovata la versione Android, restituisci una stringa vuota
        Return "Error"
    End Function

    Private Function GetRAMInfo(meminfo As String) As Integer
        ' Dividi il risultato per righe
        Dim lines = meminfo.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        ' Cerca la riga che contiene la quantità di RAM disponibile
        For Each line In lines
            If line.StartsWith("MemTotal") Then
                ' Estrai la quantità di RAM
                Dim ramString = line.Split(":")(1).Trim() ' Estrai la parte numerica della stringa
                Dim ramKB As Integer

                ' Rimuovi tutti i caratteri non numerici
                ramString = New String(ramString.Where(Function(c) Char.IsDigit(c)).ToArray())

                ' Converti la stringa risultante in un intero
                If Integer.TryParse(ramString, ramKB) Then
                    ' Restituisci la quantità di RAM in kilobytes
                    Return Math.Round(ramKB / 1024)
                Else
                    ' Se la conversione non riesce, restituisci 0 o gestisci l'errore in base alla tua logica
                    Return 0 
                End If
            End If
        Next

        Return 0 
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim devices = client.GetDevices()
        Try
            Dim device As DeviceData = devices(0)
            If Not devices IsNot Nothing AndAlso devices.Count > 0 Then
                MsgBox("The device has been disconnected!")
                Application.Restart()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Application.Restart()
        End Try

        InstallXAPK.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(My.Application.Info.AssemblyName & vbCrLf & My.Application.Info.Version.ToString & vbCrLf & My.Application.Info.Copyright)
    End Sub
End Class
