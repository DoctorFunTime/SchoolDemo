Imports DatabaseSelectStatements
Imports Guna.UI2.WinForms
Imports Frond_End_Design

Public Class FrmSelectStudent

    Dim selectStatement As New SelectStats()
    Public stID As Integer
    Public stName As String
    Public stSurname As String
    Public stClass As String
    Public _targetForm As String
    Private design As New Design
    Private classList As DataTable

    Public Sub New(targetForm As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _targetForm = targetForm
        classList = selectStatement.GetClasses()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnFilter.Click, btnToggleFilter.Click

        Select Case sender.name
            Case "btnClose"
                Close()

            Case "btnClear"
                cmbBoxClass.Text = ""

            Case "btnFilter"
                StudentFilters()
                pnlControls.Width = 30

            Case "btnToggleFilter"
                lblClass.Visible = True
                lblName.Visible = True
                lblSurname.Visible = True
                lblIDNumber.Visible = True

                If pnlControls.Width = 30 Then
                    pnlControls.Width = 575
                Else
                    pnlControls.Width = 30
                End If
        End Select
    End Sub

    Private Sub FrmSelectStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim datatable As DataTable = selectStatement.GetNamesFromTable()
        DataGridView.DataSource = datatable

        For Each row As DataRow In classList.Rows
            Dim sclass As String = row("cl_class").ToString
            cmbBoxClass.Items.Add(sclass)
        Next

    End Sub

    Private Sub DataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView.DoubleClick

        Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)

        stID = selectedRow.Cells("student_id").Value
        stName = selectedRow.Cells("name").Value
        stSurname = selectedRow.Cells("surname").Value
        stClass = selectedRow.Cells("class").Value

        Select Case _targetForm

            Case "FrmTuition"
                FrmTuition.txtStudentID.Text = stID
                FrmTuition.txtStudentName.Text = stName & " " & stSurname

            Case "studentDetails"
                Dim datatable As DataTable = selectStatement.GetStudentProfile(stID)

                Dim reportForm As New FrmStudentReport(datatable, "stdDetails", "studentDetails")
                reportForm.Show()

            Case "studentFeesStatement"
                Dim datatable As DataTable = selectStatement.GetFeesStatement(stID)

                Dim reportForm As New FrmStudentReport(datatable, "StudentFeesStatement", "FeesStatement")
                reportForm.Show()

            Case "Enrollment"
                FrmEnrollment.newStdID = stID

        End Select

        Close()

    End Sub

    Private Sub StudentFilters()

        Dim dgIDNumber As String = txtIDNumber.Text
        Dim dgSurname As String = txtSurname.Text
        Dim dgName As String = txtName.Text
        Dim dgClass As String = cmbBoxClass.Text
        Dim datatable As DataTable = selectStatement.GetNamesFromTable()

        If String.IsNullOrEmpty(dgName) And String.IsNullOrEmpty(dgClass) And String.IsNullOrEmpty(dgIDNumber) And String.IsNullOrEmpty(dgSurname) Then
            DataGridView.DataSource = datatable
        Else
            Dim filterText As String = $"name = '{dgName}' OR class = '{dgClass}' OR surname = '{dgSurname}' OR id_number = '{dgIDNumber}'"
            Dim dataView As New DataView(datatable) With {
                .RowFilter = filterText
            }
            DataGridView.DataSource = dataView
        End If
    End Sub
End Class