Imports System.Windows.Forms
Public Class frmWelcome
    Private Sub mnuUsuario_Click(sender As Object, e As EventArgs) Handles mnuUsuario.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmUsuario
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuProducto_Click(sender As Object, e As EventArgs) Handles mnuProducto.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmProducto
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuCliente_Click(sender As Object, e As EventArgs) Handles mnuCliente.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmCliente
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub mnuProveedor_Click(sender As Object, e As EventArgs) Handles mnuProveedor.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmProveedor
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub frmWelcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub mnuBoleta_Click(sender As Object, e As EventArgs) Handles mnuBoleta.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmBoleta
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub
    Private Sub mnuConsultaBoleta_Click(sender As Object, e As EventArgs) Handles mnuConsultaBoleta.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmConsultaBoleta
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub
End Class
