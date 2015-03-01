Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmListaVentas
    Dim objDao As New BoletaCN
    Dim objreporte As New ReporteCN
    Dim util As New util
  
    Sub sumaventatotal()
        Dim valorbol As Double = 0
        Dim valorfac As Double = 0
        Dim valorped As Double = 0
        Dim valortotal As Double = 0
        valorbol = Val(lblboleta.Text)
        valorfac = Val(lblfactura.Text)
        valorped = Val(lblpedido.Text)
        valortotal = valorbol + valorfac + valortotal
        lbltotalventa.Text = valortotal
    End Sub
    Sub GananciaDiaria()
        Dim valorganancia As Double = 0
        Dim valorcompra As Double = 0
        Dim valortotal As Double = 0
        valortotal = Val(lbltotalventa.Text)
        valorcompra = Val(lblCompra.Text)
        valorganancia = valortotal - valorcompra
        lblganancia.Text = valorganancia
    End Sub
    Sub fSumarboleta()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dgLista.Rows
            total += Convert.ToDouble(fila.Cells(1).Value)
        Next
        lblboleta.Text = Format(total, "#,##0.00")
    End Sub
    Sub fSumarfactura()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dglistafactura.Rows
            total += Convert.ToDouble(fila.Cells(1).Value)
        Next
        lblfactura.Text = Format(total, "#,##0.00")
    End Sub
    Sub fSumarpedido()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dglistapedido.Rows
            total += Convert.ToDouble(fila.Cells(1).Value)
        Next
        lblpedido.Text = Format(total, "#,##0.00")
    End Sub
    Sub fSumarCompra()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dgCompra.Rows
            total += Convert.ToDouble(fila.Cells(1).Value)
        Next
        lblCompra.Text = Format(total, "#,##0.00")
    End Sub
    Sub llenaTablaBoleta()
        Dim des = txtdesde.Text
        Dim has = txtHasta.Text
        Dim dt As New DataTable
        Try
            dt = objreporte.ReporteFechaBoleta(des, has).Tables("ReporteBoletaFecha")
            If dt.Rows.Count <> 0 Then
                dgLista.DataSource = dt
                dgLista.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgLista.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgLista.DataSource = Nothing
                dgLista.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenaTablaFactura()
        Dim des = txtDesde.Text
        Dim has = txtHasta.Text
        Dim dt As New DataTable
        Try
            dt = objreporte.ReporteFechaFactura(des, has).Tables("ReporteFacturaFecha")
            If dt.Rows.Count <> 0 Then
                dglistafactura.DataSource = dt
                dglistafactura.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblencFac.Text = dglistafactura.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dglistafactura.DataSource = Nothing
                dglistafactura.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblencFac.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenaTablaPedido()
        Dim des = txtDesde.Text
        Dim has = txtHasta.Text
        Dim dt As New DataTable
        Try
            dt = objreporte.ReporteFechaPedido(des, has).Tables("ReportePedidoFecha")
            If dt.Rows.Count <> 0 Then
                dglistapedido.DataSource = dt
                dglistapedido.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncPed.Text = dgLista.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dglistapedido.DataSource = Nothing
                dglistapedido.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblencFac.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenaTablaCompra()
        Dim des = txtDesde.Text
        Dim has = txtHasta.Text
        Dim dt As New DataTable
        Try
            dt = objreporte.ReporteFechaCompra(des, has).Tables("ReporteCompraFecha")
            If dt.Rows.Count <> 0 Then
                dgCompra.DataSource = dt
                dgCompra.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEnCompra.Text = dgCompra.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgCompra.DataSource = Nothing
                dgCompra.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEnCompra.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 

    Private Sub btnfiltrar_Click_1(sender As Object, e As EventArgs) Handles btnfiltrar.Click
        llenaTablaBoleta()
        fSumarboleta()
        llenaTablaFactura()
        fSumarfactura()
        llenaTablaPedido()
        fSumarpedido()
        llenaTablaCompra()
        sumaventatotal()
        GananciaDiaria()
    End Sub

    
    Private Sub dgLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista.CellDoubleClick
        Dim ChildForm As New frmConsultaDetalleBoleta
        ChildForm.MdiParent = frmWelcome
        ChildForm.codigo = dgLista.CurrentRow.Cells(0).Value
        ChildForm.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        util.Limpiar(Me)
    End Sub

    Private Sub frmListaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class