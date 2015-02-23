Imports System.Windows.Forms
Public Class util
    Public Sub Limpiar(ByVal c1 As Control)
        For Each c As Control In c1.Controls
            If TypeOf c Is MaskedTextBox Then
                c.Text = String.Empty ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If TypeOf c Is TextBox Then
                c.Text = String.Empty ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If TypeOf c Is ComboBox Then
                CType(c, ComboBox).SelectedIndex = 0
            Else
                Limpiar(c)
            End If
            If TypeOf c Is DataGridView Then
                CType(c, DataGridView).Rows.Clear()
            Else
                Limpiar(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False
            Else
                Limpiar(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today ' eliminar el texto
            Else
                Limpiar(c)
            End If
        Next
    End Sub
    Public Sub Bloquear(ByVal c1 As Control)
        For Each c As Control In c1.Controls
            If TypeOf c Is MaskedTextBox Then
                c.Enabled = False ' eliminar el texto
            Else
                Bloquear(c)
            End If
            If TypeOf c Is TextBox Then
                c.Enabled = False
            Else
                Bloquear(c)
            End If
            If TypeOf c Is LinkLabel Then
                c.Enabled = False
            Else
                Bloquear(c)
            End If
            If TypeOf c Is ComboBox Then
                c.Enabled = False
            Else
                Bloquear(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                If c.Name = "cbEliminar" Then
                    c.Enabled = True
                Else
                    c.Enabled = False
                End If
            Else
                Bloquear(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Enabled = False ' eliminar el texto
            Else
                Bloquear(c)
            End If
        Next
    End Sub
    Public Sub Desbloquear(ByVal c1 As Control)
        For Each c As Control In c1.Controls
            If TypeOf c Is MaskedTextBox Then
                c.Enabled = True ' eliminar el texto
            Else
                Desbloquear(c)
            End If
            If TypeOf c Is TextBox Then
                c.Enabled = True
            Else
                Desbloquear(c)
            End If
            If TypeOf c Is LinkLabel Then
                c.Enabled = True
            Else
                Desbloquear(c)
            End If
            If TypeOf c Is ComboBox Then
                c.Enabled = True
            Else
                Desbloquear(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                c.Enabled = True
            Else
                Desbloquear(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Enabled = True ' eliminar el texto
            Else
                Desbloquear(c)
            End If
        Next
    End Sub
    Public Sub cambiarEstado(button1 As Button, button2 As Button)
        button1.Visible = False
        button2.Visible = True
    End Sub
    Public Sub bloquearButton(ByVal c1 As Control, bol As Boolean)
        For Each c As Control In c1.Controls
            If TypeOf c Is Button Then
                If c.Name Is "btnModificar" Then
                    c.Enabled = bol
                ElseIf c.Name Is "btnNuevo" Then
                    c.Enabled = Not (bol)
                End If
            Else
                bloquearButton(c, bol)
            End If
        Next
    End Sub
End Class
