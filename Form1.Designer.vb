<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDisplayName = New System.Windows.Forms.TextBox()
        Me.btNameApp = New System.Windows.Forms.Button()
        Me.btPatIcon = New System.Windows.Forms.Button()
        Me.txtPathIcon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btVersion = New System.Windows.Forms.Button()
        Me.txtVersionApp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btDateInstall = New System.Windows.Forms.Button()
        Me.txtInstallDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btPathInstall = New System.Windows.Forms.Button()
        Me.txtDirectoryApp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btUninstall = New System.Windows.Forms.Button()
        Me.txtUninstall = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btProcess = New System.Windows.Forms.Button()
        Me.btCompany = New System.Windows.Forms.Button()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btFileSize = New System.Windows.Forms.Button()
        Me.txtFileSize = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(449, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Aplicativo:"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(449, 39)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(489, 27)
        Me.txtDisplayName.TabIndex = 1
        '
        'btNameApp
        '
        Me.btNameApp.BackColor = System.Drawing.Color.Maroon
        Me.btNameApp.FlatAppearance.BorderSize = 0
        Me.btNameApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNameApp.Location = New System.Drawing.Point(957, 37)
        Me.btNameApp.Name = "btNameApp"
        Me.btNameApp.Size = New System.Drawing.Size(90, 28)
        Me.btNameApp.TabIndex = 2
        Me.btNameApp.Text = "Aplicar"
        Me.btNameApp.UseVisualStyleBackColor = False
        '
        'btPatIcon
        '
        Me.btPatIcon.BackColor = System.Drawing.Color.Maroon
        Me.btPatIcon.FlatAppearance.BorderSize = 0
        Me.btPatIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPatIcon.Location = New System.Drawing.Point(957, 93)
        Me.btPatIcon.Name = "btPatIcon"
        Me.btPatIcon.Size = New System.Drawing.Size(90, 28)
        Me.btPatIcon.TabIndex = 5
        Me.btPatIcon.Text = "Aplicar"
        Me.btPatIcon.UseVisualStyleBackColor = False
        '
        'txtPathIcon
        '
        Me.txtPathIcon.Location = New System.Drawing.Point(449, 93)
        Me.txtPathIcon.Name = "txtPathIcon"
        Me.txtPathIcon.Size = New System.Drawing.Size(489, 27)
        Me.txtPathIcon.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(452, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Caminho do Ícone:"
        '
        'btVersion
        '
        Me.btVersion.BackColor = System.Drawing.Color.Maroon
        Me.btVersion.FlatAppearance.BorderSize = 0
        Me.btVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVersion.Location = New System.Drawing.Point(957, 151)
        Me.btVersion.Name = "btVersion"
        Me.btVersion.Size = New System.Drawing.Size(90, 28)
        Me.btVersion.TabIndex = 8
        Me.btVersion.Text = "Aplicar"
        Me.btVersion.UseVisualStyleBackColor = False
        '
        'txtVersionApp
        '
        Me.txtVersionApp.Location = New System.Drawing.Point(449, 151)
        Me.txtVersionApp.Name = "txtVersionApp"
        Me.txtVersionApp.Size = New System.Drawing.Size(489, 27)
        Me.txtVersionApp.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Versão do Aplicativo:"
        '
        'btDateInstall
        '
        Me.btDateInstall.BackColor = System.Drawing.Color.Maroon
        Me.btDateInstall.FlatAppearance.BorderSize = 0
        Me.btDateInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDateInstall.Location = New System.Drawing.Point(957, 212)
        Me.btDateInstall.Name = "btDateInstall"
        Me.btDateInstall.Size = New System.Drawing.Size(90, 28)
        Me.btDateInstall.TabIndex = 11
        Me.btDateInstall.Text = "Aplicar"
        Me.btDateInstall.UseVisualStyleBackColor = False
        '
        'txtInstallDate
        '
        Me.txtInstallDate.Location = New System.Drawing.Point(449, 212)
        Me.txtInstallDate.Name = "txtInstallDate"
        Me.txtInstallDate.Size = New System.Drawing.Size(489, 27)
        Me.txtInstallDate.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(449, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data da Instalação:"
        '
        'btPathInstall
        '
        Me.btPathInstall.BackColor = System.Drawing.Color.Maroon
        Me.btPathInstall.FlatAppearance.BorderSize = 0
        Me.btPathInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPathInstall.Location = New System.Drawing.Point(957, 270)
        Me.btPathInstall.Name = "btPathInstall"
        Me.btPathInstall.Size = New System.Drawing.Size(90, 28)
        Me.btPathInstall.TabIndex = 14
        Me.btPathInstall.Text = "Aplicar"
        Me.btPathInstall.UseVisualStyleBackColor = False
        '
        'txtDirectoryApp
        '
        Me.txtDirectoryApp.Location = New System.Drawing.Point(449, 271)
        Me.txtDirectoryApp.Name = "txtDirectoryApp"
        Me.txtDirectoryApp.Size = New System.Drawing.Size(489, 27)
        Me.txtDirectoryApp.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(452, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Diretório da Aplicação:"
        '
        'btUninstall
        '
        Me.btUninstall.BackColor = System.Drawing.Color.Maroon
        Me.btUninstall.FlatAppearance.BorderSize = 0
        Me.btUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUninstall.Location = New System.Drawing.Point(957, 444)
        Me.btUninstall.Name = "btUninstall"
        Me.btUninstall.Size = New System.Drawing.Size(90, 28)
        Me.btUninstall.TabIndex = 17
        Me.btUninstall.Text = "Aplicar"
        Me.btUninstall.UseVisualStyleBackColor = False
        '
        'txtUninstall
        '
        Me.txtUninstall.Location = New System.Drawing.Point(449, 448)
        Me.txtUninstall.Name = "txtUninstall"
        Me.txtUninstall.Size = New System.Drawing.Size(489, 27)
        Me.txtUninstall.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Desinstalador:"
        '
        'btProcess
        '
        Me.btProcess.BackColor = System.Drawing.Color.Blue
        Me.btProcess.FlatAppearance.BorderSize = 0
        Me.btProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btProcess.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btProcess.Location = New System.Drawing.Point(835, 508)
        Me.btProcess.Name = "btProcess"
        Me.btProcess.Size = New System.Drawing.Size(212, 43)
        Me.btProcess.TabIndex = 18
        Me.btProcess.Text = "PROCESSAR"
        Me.btProcess.UseVisualStyleBackColor = False
        '
        'btCompany
        '
        Me.btCompany.BackColor = System.Drawing.Color.Maroon
        Me.btCompany.FlatAppearance.BorderSize = 0
        Me.btCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCompany.Location = New System.Drawing.Point(957, 329)
        Me.btCompany.Name = "btCompany"
        Me.btCompany.Size = New System.Drawing.Size(90, 28)
        Me.btCompany.TabIndex = 21
        Me.btCompany.Text = "Aplicar"
        Me.btCompany.UseVisualStyleBackColor = False
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(449, 329)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(489, 27)
        Me.txtCompany.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(452, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Empresa:"
        '
        'btFileSize
        '
        Me.btFileSize.BackColor = System.Drawing.Color.Maroon
        Me.btFileSize.FlatAppearance.BorderSize = 0
        Me.btFileSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFileSize.Location = New System.Drawing.Point(957, 385)
        Me.btFileSize.Name = "btFileSize"
        Me.btFileSize.Size = New System.Drawing.Size(90, 28)
        Me.btFileSize.TabIndex = 25
        Me.btFileSize.Text = "Aplicar"
        Me.btFileSize.UseVisualStyleBackColor = False
        '
        'txtFileSize
        '
        Me.txtFileSize.Location = New System.Drawing.Point(449, 389)
        Me.txtFileSize.Name = "txtFileSize"
        Me.txtFileSize.Size = New System.Drawing.Size(489, 27)
        Me.txtFileSize.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(456, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tamanho do Arquivo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 339)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1070, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btFileSize)
        Me.Controls.Add(Me.txtFileSize)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btCompany)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btProcess)
        Me.Controls.Add(Me.btUninstall)
        Me.Controls.Add(Me.txtUninstall)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btPathInstall)
        Me.Controls.Add(Me.txtDirectoryApp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btDateInstall)
        Me.Controls.Add(Me.txtInstallDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btVersion)
        Me.Controls.Add(Me.txtVersionApp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btPatIcon)
        Me.Controls.Add(Me.txtPathIcon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btNameApp)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Test"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents btNameApp As Button
    Friend WithEvents btPatIcon As Button
    Friend WithEvents txtPathIcon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btVersion As Button
    Friend WithEvents txtVersionApp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btDateInstall As Button
    Friend WithEvents txtInstallDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btPathInstall As Button
    Friend WithEvents txtDirectoryApp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btUninstall As Button
    Friend WithEvents txtUninstall As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btProcess As Button
    Friend WithEvents btCompany As Button
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btFileSize As Button
    Friend WithEvents txtFileSize As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
