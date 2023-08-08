Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Namespace ASiiMO_BatchCompiler
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openbatfile As OpenFileDialog = New OpenFileDialog()
            openbatfile.FileName = ""
            openbatfile.Filter = "Batch file (*.bat)|*.bat"



            'DialogResult result_bat = openFileDialog1.ShowDialog();
            If openbatfile.ShowDialog() = DialogResult.OK Then
                If Not Equals(Path.GetExtension(openbatfile.FileName), ".bat") Then
                    MessageBox.Show("Thats not a batch file!")
                Else
                    label1.Text = openbatfile.FileName

                    'Getting the BAT file information
                    Dim batname = Path.GetFileNameWithoutExtension(openbatfile.FileName)
                    Dim batlength As Long = New FileInfo(openbatfile.FileName).Length

                    'Setting the information labels to visible
                    label5.Visible = True
                    label7.Visible = True

                    'Changing labels to the BAT file information
                    label5.Text = batname
                    label7.Text = (batlength.ToString() & " bytes")

                    button6.Enabled = True

                End If

            End If
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim savefile As SaveFileDialog = New SaveFileDialog()
            savefile.FileName = "yourbatchfile.exe"
            savefile.Filter = "Executables (*.exe)|*.exe"

            If savefile.ShowDialog() = DialogResult.OK Then
                Dim pathtoexe = savefile.FileName
                textBox1.Text = pathtoexe
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openfile As OpenFileDialog = New OpenFileDialog()
            openfile.Filter = "Icons (*.ico)|*.ico|All files (*.*)|*.*"

            If openfile.ShowDialog() = DialogResult.OK Then
                Dim pathtoico = openfile.FileName
                textBox2.Text = pathtoico
            End If
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Equals(label1.Text, String.Empty) AndAlso Not Equals(textBox1.Text, String.Empty) Then
                Dim b2eargs = "/bat " & """" & label1.Text & """" & " /exe " & """" & textBox1.Text & """" & If(checkBox1.Checked, " /x64", Nothing) & If(checkBox2.Checked, " /invisible", Nothing) & If(checkBox3.Checked, " /uac-admin", Nothing) & If(checkBox4.Checked, " /uac-user", Nothing) & If(checkBox5.Checked, " /upx", Nothing) & If(checkBox2.Checked, " /invisible", Nothing) & If(checkBox6.Checked, " /icon " & """" & textBox2.Text & """", Nothing)

                ' /bat [filename] || /exe [filename] || /invisible /x64 /uac-admin /uac-user /upx ||

                Console.WriteLine("b2e.exe" & " " & b2eargs)
                Process.Start("b2e.exe", " " & b2eargs)
                Thread.Sleep(3000)
                MessageBox.Show("Done!")

                label11.Visible = True
                label9.Visible = True
                button4.Visible = True

                Dim exename = Path.GetFileNameWithoutExtension(textBox1.Text)
                Dim exelength As Long = New FileInfo(textBox1.Text).Length

                label11.Text = exename
                label9.Text = (exelength.ToString() & " bytes")
            Else
                MessageBox.Show("Please add a .bat file and choose the output file.")
            End If

        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start(textBox1.Text)
        End Sub

        Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start("https://github.com/asimo1/bat2executable")
        End Sub

        Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs)
            label1.Visible = True
        End Sub
    End Class
End Namespace
