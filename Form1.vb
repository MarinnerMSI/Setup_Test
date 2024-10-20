

Imports Microsoft.Win32
Imports Microsoft.Win32.RegistryKey

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btNameApp_Click(sender As Object, e As EventArgs) Handles btNameApp.Click
        Try
            txtDisplayName.Text = ProductName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btPatIcon_Click(sender As Object, e As EventArgs) Handles btPatIcon.Click
        Try
            'aplicando o ícone da aplicação
            txtPathIcon.Text = Application.StartupPath & "\" & "Setup_MarinnerMSI.ico"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btVersion_Click(sender As Object, e As EventArgs) Handles btVersion.Click
        Try
            txtVersionApp.Text = ProductVersion
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btDateInstall_Click(sender As Object, e As EventArgs) Handles btDateInstall.Click
        Try
            txtInstallDate.Text = DateAndTime.Today
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btPathInstall_Click(sender As Object, e As EventArgs) Handles btPathInstall.Click
        Try
            'local da pasta do projeto a ser usado para instalação/desinstalação
            ' txtDirectoryApp.Text = "C:\Users\Marcio\Documents\Visual Studio 2022\Projetos\Setup_Test\bin\Setup Test\Debug"
            txtDirectoryApp.Text = Application.StartupPath

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCompany_Click(sender As Object, e As EventArgs) Handles btCompany.Click
        Try
            txtCompany.Text = Application.CompanyName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btUninstall_Click(sender As Object, e As EventArgs) Handles btUninstall.Click
        Try
            txtUninstall.Text = Application.StartupPath & "\" & ProductName & ".exe"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btProcess_Click(sender As Object, e As EventArgs) Handles btProcess.Click
        Try
            'Criando a chave para o registro do Windows 
            'Para que também apareça no Painel de Controle
            Dim KeyLM As RegistryKey = Registry.LocalMachine.OpenSubKey _
                ("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", True)

            Dim NewKeyLM As RegistryKey = KeyLM.CreateSubKey(ProductName)

            NewKeyLM.SetValue("DisplayName", txtDisplayName.Text)
            NewKeyLM.SetValue("DisplayIcon", txtPathIcon.Text)
            NewKeyLM.SetValue("DisplayVersion", txtVersionApp.Text)
            NewKeyLM.SetValue("InstallDate", txtInstallDate.Text)
            NewKeyLM.SetValue("InstallLocation", txtDirectoryApp.Text)
            NewKeyLM.SetValue("Publisher", txtCompany.Text)
            NewKeyLM.SetValue("EstimatedSize", txtFileSize.Text, Microsoft.Win32.RegistryValueKind.DWord)
            NewKeyLM.SetValue("UninstallString", txtUninstall)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btFileSize_Click(sender As Object, e As EventArgs) Handles btFileSize.Click
        Try
            'onde fica o valor
            Dim ValorDecimal As Integer = txtFileSize.Text

            'o 3 determina a quantida de zeros à esquerda
            Dim DecimalSize As Integer = ValorDecimal.ToString("D").Length + 3
            txtFileSize.Text = ValorDecimal.ToString("D" & DecimalSize.ToString())

        Catch ex As Exception

        End Try
    End Sub
End Class
