Imports System.Windows.Forms
''' -----------------------------------------------
'''  Project: 
'''  Class: util
''' -----------------------------------------------
''' <summary>
'''  En esta clase se encuentran todas las utilades
'''  del software
'''  {limpieza,bloqueo, desbloqueo}
''' </summary>
''' <remarks>  
''' </remarks>
''' <history>
'''  [Javier Huaman] 21/02/2015 Created
''' </history>
Public Class util
    ''' <summary>
    '''  Hace la limpieza de cada control de un formulario
    ''' </summary>
    ''' <param name="c1">
    '''  Recibo como parametro un Formulario
    ''' </param>
    ''' <example>
    '''  La manera de llamarlo:
    '''  [Class util].Limpieza([formularioDeseado] or [Me]) 
    ''' </example>
    ''' <remarks></remarks>
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
    ''' <summary>
    ''' Bloquea todos los controles de un formulario
    ''' </summary>
    ''' <param name="c1">
    '''  Recibo como parametro un Formulario
    ''' </param>
    ''' <example>
    '''  La manera de llamarlo:
    '''  [Class util].Bloquear([formularioDeseado] or [Me]) 
    ''' </example>
    ''' <remarks></remarks>
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
    ''' <summary>
    ''' Desbloquea todos los controles de un formulario
    ''' </summary>
    ''' <param name="c1">
    '''  Recibo como parametro un Formulario
    ''' </param>
    ''' <example>
    '''  La manera de llamarlo:
    '''  [Class util].Desbloquear([formularioDeseado] or [Me]) 
    ''' </example>
    ''' <remarks></remarks>
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
    ''' <summary>
    '''  Cambia el estado de dos buttons
    ''' </summary>
    ''' <param name="button1">
    '''  Recibo como parametro un Button 
    ''' que se desea ocultar
    ''' </param>
    ''' <param name="button2">
    ''' Recibo como parametro un Button 
    ''' que se desea mostrar
    ''' </param>
    ''' <example>
    '''  La manera de llamarlo:
    '''  [Class util].cambiarEstado([button] , [button]) 
    ''' </example>
    ''' <remarks></remarks>
    Public Sub cambiarEstado(button1 As Button, button2 As Button)
        button1.Visible = False
        button2.Visible = True
    End Sub
    ''' <summary>
    ''' Desbloquea o bloquea los buttons de un formulario
    ''' </summary>
    ''' <param name="c1">
    ''' Recibo como parametro un formulario
    ''' </param>
    ''' <param name="bol">
    ''' Recibo como parametro un boolean
    ''' Si es true: Bloquea los buttons
    ''' Si es false: Desbloquea los buttons
    ''' </param>
    ''' <example>
    '''  La manera de llamarlo:
    '''  [Class util].bloquearButton([Me] , [{false or true}]) 
    ''' </example>
    ''' <remarks></remarks>
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
    Public Sub soloNumero(txt As TextBox)
        If Not IsNumeric(txt.Text) And txt.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt.Text = ""
            txt.Focus()
        End If
    End Sub
End Class
