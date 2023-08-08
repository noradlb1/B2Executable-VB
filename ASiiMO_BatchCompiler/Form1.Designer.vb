Imports System

Namespace ASiiMO_BatchCompiler
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            textBox2 = New Windows.Forms.TextBox()
            checkBox1 = New Windows.Forms.CheckBox()
            checkBox2 = New Windows.Forms.CheckBox()
            checkBox3 = New Windows.Forms.CheckBox()
            checkBox4 = New Windows.Forms.CheckBox()
            checkBox5 = New Windows.Forms.CheckBox()
            button3 = New Windows.Forms.Button()
            groupBox1 = New Windows.Forms.GroupBox()
            checkBox6 = New Windows.Forms.CheckBox()
            groupBox2 = New Windows.Forms.GroupBox()
            label7 = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            label8 = New Windows.Forms.Label()
            groupBox3 = New Windows.Forms.GroupBox()
            button4 = New Windows.Forms.Button()
            label9 = New Windows.Forms.Label()
            label11 = New Windows.Forms.Label()
            label12 = New Windows.Forms.Label()
            textBox1 = New Windows.Forms.TextBox()
            label14 = New Windows.Forms.Label()
            button5 = New Windows.Forms.Button()
            openFileDialog1 = New Windows.Forms.OpenFileDialog()
            saveFileDialog1 = New Windows.Forms.SaveFileDialog()
            linkLabel1 = New Windows.Forms.LinkLabel()
            label1 = New Windows.Forms.Label()
            button6 = New Windows.Forms.Button()
            groupBox1.SuspendLayout()
            groupBox2.SuspendLayout()
            groupBox3.SuspendLayout()
            SuspendLayout()
            ' 
            ' button1
            ' 
            button1.Font = New Drawing.Font("Microsoft Sans Serif", 7.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            button1.Location = New Drawing.Point(12, 12)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(200, 29)
            button1.TabIndex = 2
            button1.Text = "Open .bat"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Font = New Drawing.Font("Microsoft Sans Serif", 7.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            button2.Location = New Drawing.Point(336, 100)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(78, 23)
            button2.TabIndex = 5
            button2.Text = "Open File"
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' textBox2
            ' 
            textBox2.Location = New Drawing.Point(123, 100)
            textBox2.Name = "textBox2"
            textBox2.Size = New Drawing.Size(207, 22)
            textBox2.TabIndex = 4
            ' 
            ' checkBox1
            ' 
            checkBox1.AutoSize = True
            checkBox1.Location = New Drawing.Point(214, 21)
            checkBox1.Name = "checkBox1"
            checkBox1.Size = New Drawing.Size(66, 21)
            checkBox1.TabIndex = 6
            checkBox1.Text = "64-bit"
            checkBox1.UseVisualStyleBackColor = True
            ' 
            ' checkBox2
            ' 
            checkBox2.AutoSize = True
            checkBox2.Location = New Drawing.Point(49, 21)
            checkBox2.Name = "checkBox2"
            checkBox2.Size = New Drawing.Size(80, 21)
            checkBox2.TabIndex = 7
            checkBox2.Text = "Invisible"
            checkBox2.UseVisualStyleBackColor = True
            ' 
            ' checkBox3
            ' 
            checkBox3.AutoSize = True
            checkBox3.Location = New Drawing.Point(49, 48)
            checkBox3.Name = "checkBox3"
            checkBox3.Size = New Drawing.Size(101, 21)
            checkBox3.TabIndex = 8
            checkBox3.Text = "UAC Admin"
            checkBox3.UseVisualStyleBackColor = True
            ' 
            ' checkBox4
            ' 
            checkBox4.AutoSize = True
            checkBox4.Location = New Drawing.Point(49, 75)
            checkBox4.Name = "checkBox4"
            checkBox4.Size = New Drawing.Size(92, 21)
            checkBox4.TabIndex = 9
            checkBox4.Text = "UAC User"
            checkBox4.UseVisualStyleBackColor = True
            ' 
            ' checkBox5
            ' 
            checkBox5.AutoSize = True
            checkBox5.Location = New Drawing.Point(214, 51)
            checkBox5.Name = "checkBox5"
            checkBox5.Size = New Drawing.Size(153, 21)
            checkBox5.TabIndex = 10
            checkBox5.Text = "Compress with UPX"
            checkBox5.UseVisualStyleBackColor = True
            ' 
            ' button3
            ' 
            button3.Font = New Drawing.Font("Microsoft Sans Serif", 13.8F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button3.ForeColor = Drawing.Color.RoyalBlue
            button3.Location = New Drawing.Point(12, 216)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(442, 111)
            button3.TabIndex = 12
            button3.Text = "Convert!"
            button3.UseVisualStyleBackColor = True
            AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(checkBox6)
            groupBox1.Controls.Add(checkBox5)
            groupBox1.Controls.Add(checkBox4)
            groupBox1.Controls.Add(textBox2)
            groupBox1.Controls.Add(checkBox1)
            groupBox1.Controls.Add(checkBox3)
            groupBox1.Controls.Add(button2)
            groupBox1.Controls.Add(checkBox2)
            groupBox1.Location = New Drawing.Point(244, 12)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(439, 146)
            groupBox1.TabIndex = 13
            groupBox1.TabStop = False
            groupBox1.Text = "Settings"
            ' 
            ' checkBox6
            ' 
            checkBox6.AutoSize = True
            checkBox6.Location = New Drawing.Point(49, 102)
            checkBox6.Name = "checkBox6"
            checkBox6.Size = New Drawing.Size(60, 21)
            checkBox6.TabIndex = 11
            checkBox6.Text = "Icon:"
            checkBox6.UseVisualStyleBackColor = True
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(button6)
            groupBox2.Controls.Add(label7)
            groupBox2.Controls.Add(label5)
            groupBox2.Controls.Add(label4)
            groupBox2.Controls.Add(label3)
            groupBox2.Location = New Drawing.Point(12, 47)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(200, 111)
            groupBox2.TabIndex = 15
            groupBox2.TabStop = False
            groupBox2.Text = "Batch file info"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Location = New Drawing.Point(86, 40)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(46, 17)
            label7.TabIndex = 19
            label7.Text = "label7"
            label7.Visible = False
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Location = New Drawing.Point(86, 19)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(46, 17)
            label5.TabIndex = 17
            label5.Text = "label5"
            label5.Visible = False
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(6, 19)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(73, 17)
            label4.TabIndex = 16
            label4.Text = "File name:"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(40, 40)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(39, 17)
            label3.TabIndex = 15
            label3.Text = "Size:"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New Drawing.Point(6, 21)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(73, 17)
            label8.TabIndex = 16
            label8.Text = "File name:"
            ' 
            ' groupBox3
            ' 
            groupBox3.Controls.Add(button4)
            groupBox3.Controls.Add(label9)
            groupBox3.Controls.Add(label11)
            groupBox3.Controls.Add(label8)
            groupBox3.Controls.Add(label12)
            groupBox3.Location = New Drawing.Point(483, 216)
            groupBox3.Name = "groupBox3"
            groupBox3.Size = New Drawing.Size(200, 93)
            groupBox3.TabIndex = 21
            groupBox3.TabStop = False
            groupBox3.Text = "Executable file info"
            ' 
            ' button4
            ' 
            button4.Location = New Drawing.Point(7, 58)
            button4.Name = "button4"
            button4.Size = New Drawing.Size(187, 29)
            button4.TabIndex = 20
            button4.Text = "Go to file"
            button4.UseVisualStyleBackColor = True
            button4.Visible = False
            AddHandler button4.Click, New EventHandler(AddressOf button4_Click)
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Location = New Drawing.Point(86, 38)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(46, 17)
            label9.TabIndex = 19
            label9.Text = "label9"
            label9.Visible = False
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Location = New Drawing.Point(86, 21)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(54, 17)
            label11.TabIndex = 17
            label11.Text = "label11"
            label11.Visible = False
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.Location = New Drawing.Point(40, 38)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(39, 17)
            label12.TabIndex = 15
            label12.Text = "Size:"
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(79, 189)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(230, 22)
            textBox1.TabIndex = 22
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.Location = New Drawing.Point(13, 192)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(60, 17)
            label14.TabIndex = 23
            label14.Text = "Save to:"
            ' 
            ' button5
            ' 
            button5.Font = New Drawing.Font("Microsoft Sans Serif", 6.5F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            button5.Location = New Drawing.Point(315, 189)
            button5.Name = "button5"
            button5.Size = New Drawing.Size(139, 22)
            button5.TabIndex = 24
            button5.Text = "Choose Folder"
            button5.UseVisualStyleBackColor = True
            AddHandler button5.Click, New EventHandler(AddressOf button5_Click)
            ' 
            ' openFileDialog1
            ' 
            openFileDialog1.FileName = "openFileDialog1"
            ' 
            ' linkLabel1
            ' 
            linkLabel1.AutoSize = True
            linkLabel1.Location = New Drawing.Point(525, 313)
            linkLabel1.Name = "linkLabel1"
            linkLabel1.Size = New Drawing.Size(160, 17)
            linkLabel1.TabIndex = 25
            linkLabel1.TabStop = True
            linkLabel1.Text = "B2Executable on Github"
            AddHandler linkLabel1.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel1_LinkClicked)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(9, 161)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(46, 17)
            label1.TabIndex = 20
            label1.Text = "label1"
            label1.Visible = False
            ' 
            ' button6
            ' 
            button6.Enabled = False
            button6.Location = New Drawing.Point(7, 80)
            button6.Name = "button6"
            button6.Size = New Drawing.Size(187, 25)
            button6.TabIndex = 20
            button6.Text = "Show path to .bat"
            button6.UseVisualStyleBackColor = True
            AddHandler button6.Click, New EventHandler(AddressOf button6_Click)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8.0F, 16.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(697, 339)
            Controls.Add(label1)
            Controls.Add(linkLabel1)
            Controls.Add(button5)
            Controls.Add(label14)
            Controls.Add(textBox1)
            Controls.Add(groupBox2)
            Controls.Add(groupBox3)
            Controls.Add(groupBox1)
            Controls.Add(button3)
            Controls.Add(button1)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Form1"
            Text = "B2Executable | By ASiiMO"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            groupBox3.ResumeLayout(False)
            groupBox3.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
        Private textBox2 As Windows.Forms.TextBox
        Private checkBox1 As Windows.Forms.CheckBox
        Private checkBox2 As Windows.Forms.CheckBox
        Private checkBox3 As Windows.Forms.CheckBox
        Private checkBox4 As Windows.Forms.CheckBox
        Private checkBox5 As Windows.Forms.CheckBox
        Private button3 As Windows.Forms.Button
        Private groupBox1 As Windows.Forms.GroupBox
        Private groupBox2 As Windows.Forms.GroupBox
        Private label3 As Windows.Forms.Label
        Private label7 As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private label8 As Windows.Forms.Label
        Private groupBox3 As Windows.Forms.GroupBox
        Private button4 As Windows.Forms.Button
        Private label9 As Windows.Forms.Label
        Private label11 As Windows.Forms.Label
        Private label12 As Windows.Forms.Label
        Private textBox1 As Windows.Forms.TextBox
        Private label14 As Windows.Forms.Label
        Private button5 As Windows.Forms.Button
        Private openFileDialog1 As Windows.Forms.OpenFileDialog
        Private saveFileDialog1 As Windows.Forms.SaveFileDialog
        Private checkBox6 As Windows.Forms.CheckBox
        Private linkLabel1 As Windows.Forms.LinkLabel
        Private label1 As Windows.Forms.Label
        Private button6 As Windows.Forms.Button
    End Class
End Namespace
