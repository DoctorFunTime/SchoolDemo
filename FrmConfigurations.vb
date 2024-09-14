Imports Guna.UI2.WinForms
Imports Frond_End_Design
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmConfigurations
    Private design As New Design
    Private _frm As Homepage
    Private _darkmode As Boolean
    Private _conn As String
    Public Sub New(darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _conn = conn
        _frm = frm
        _darkmode = darkmode
        design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub FrmConfigurations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub btnValidateAndFinalise_Click(sender As Object, e As EventArgs) Handles btnValidateAndFinalise.Click

        'Dim verified As Boolean = design.txtboxformats(pnlControls)

        'If verified Then
        Dim aes As Aes = Aes.Create()
        aes.GenerateKey()
        aes.GenerateIV()

        Dim key As String = Convert.ToBase64String(aes.Key)
        Dim iv As String = Convert.ToBase64String(aes.IV)


        EncryptionHelper.initialize(aes.Key, aes.IV)

        Dim connString As String = $"Host={txtHost.Text};Port={txtPort.Text};Database={txtDatabase.Text};Username={txtUsername.Text};Password={txtPassword.Text};"

        ' Save encrypted connection string to a file
        File.WriteAllText("appsettings.json", "{""ConnectionString"": """ & connString & """}")

    End Sub
    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton)
        Return sidebarButtons
    End Function
    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton)
        Return pagebuttons
    End Function
    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
            pnlTopBar
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblHeading,
            lblHost,
            lblDatabase,
            lblPassword,
            lblPort,
            lblUsername
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateAndFinalise
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtDatabase,
            txtPassword,
            txtPort,
            txtUsername,
            txtHost
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
        }
        Return placeholder
    End Function

End Class

Public Class EncryptionHelper
    Private Shared encryptionKey As Byte()
    Private Shared initializationVector As Byte()
    Public Shared Sub initialize(key As Byte(), iv As Byte())
        encryptionKey = key
        initializationVector = iv
    End Sub
    ' Encrypt a string
    Public Shared Function EncryptString(plainText As String) As String

        Using aes As Aes = Aes.Create()
            aes.Key = encryptionKey
            aes.IV = initializationVector
            Dim encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                    Using sw As New StreamWriter(cs)
                        sw.Write(plainText)
                    End Using
                End Using
                Return Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
    End Function
    ' Decrypt a string
    Public Shared Function DecryptString(cipherText As String) As String

        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using aes As Aes = Aes.Create()
            aes.Key = encryptionKey
            aes.IV = initializationVector
            Dim decryptor As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
            Using ms As New MemoryStream(cipherBytes)
                Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                    Using sr As New StreamReader(cs)
                        Return sr.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
    End Function
End Class