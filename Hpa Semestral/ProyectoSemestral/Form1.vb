Public Class Form1

    Dim datos(100, 100) As String
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Visible = False
        i = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.Visible = True
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.Visible = True
        TabControl1.SelectedTab = TabPage2
    End Sub
    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad2.TextChanged
        Try
            Labeledad2.Text = txtedad2.Text * 12
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.Visible = True
        TabControl1.SelectedTab = TabPage3

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub limpiar()
        ComboBox1.Text = ""
        txtnom.Clear()
        txtnom2.Clear()
        txtcedula.Clear()
        txtcedula2.Clear()
        txtpeso.Clear()
        txtpeso.Clear()
        txtedad.Clear()
        txtedad2.Clear()
        txtFechadeNac.Clear()
        txtFechaNac2.Clear()
        txtocupacion.Clear()
        txtocupacion2.Clear()
        txtnumerotel.Clear()
        txtnumerotel2.Clear()
        ComboBox2.ResetText()
        ComboBox3.ResetText()

        RbSeguroSí.Checked = False
        RBsegurosi2.Checked = False
        RbSeguroNo.Checked = False
        RBsegurono2.Checked = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        limpiar()
    End Sub

    Private Sub txtpeso2_TextChanged(sender As Object, e As EventArgs) Handles txtpeso2.TextChanged
        Try
            Labelpeso2.Text = txtpeso2.Text / 2.2
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtpeso_TextChanged(sender As Object, e As EventArgs) Handles txtpeso.TextChanged
        Try
            Labelpeso.Text = CInt(txtpeso.Text / 2.2)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtedad_TextChanged_1(sender As Object, e As EventArgs) Handles txtedad.TextChanged

        Try
            Labeledad.Text = txtedad.Text * 12
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtcedula2_TextChanged(sender As Object, e As EventArgs) Handles txtcedula2.TextChanged

    End Sub

    Private Sub Guardar1_Click(sender As Object, e As EventArgs) Handles Guardar1.Click    'al presionar el boton se activa este metodo 

        Dim opc As Integer

        If txtnom.Text = "" Then
            MessageBox.Show("El campo de nombre esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtcedula.Text = "" Then
            MessageBox.Show("El campo de Cedula esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtFechadeNac.Text = "" Then
            MessageBox.Show("El campo de Fecha de nacimiento esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtocupacion.Text = "" Then
            MessageBox.Show("El campo de ocupacion esta vacio,Por Favor rellenelo")
            opc = 1
        ElseIf txtpeso.Text = "" Then
            MessageBox.Show("El campo de peso esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtnumerotel.Text = "" Then
            MessageBox.Show("El campo de numero de telefono esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtedad.Text = "" Then
            MessageBox.Show("El campo de edad esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf ComboBox2.selectedIndex = -1 Then
            MessageBox.Show("El Campo de genero esta vacio,Por favor elija una opcion")
            opc = 1
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("El campo de especialidad esta vacio,Por favor elija una opcion")
            opc = 1
        End If
        If opc <> 1 Then
            datos(0, i) = txtnom.Text 'nombre 
            datos(1, i) = txtcedula.Text 'cedula 
            datos(2, i) = txtFechadeNac.Text 'fechadeNacimiento
            datos(3, i) = txtocupacion.Text 'ocupacion 
            datos(4, i) = txtpeso.Text 'peso 
            datos(5, i) = txtnumerotel.Text 'numero de telefono 
            datos(6, i) = txtedad.Text 'edad
            datos(7, i) = ComboBox2.Text
            datos(9, i) = ComboBox1.Text
            If RbSeguroSí.Checked Then
                datos(8, i) = "Sí"
            Else
                datos(8, i) = "No"
            End If
            i = i + 1
            limpiar()


        End If




    End Sub

    Private Sub Guardar2_Click(sender As Object, e As EventArgs) Handles Guardar2.Click
        Dim opc As Integer
        If txtnom2.Text = "" Then
            MessageBox.Show("El campo de nombre esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtcedula2.Text = "" Then
            MessageBox.Show("El campo de Cedula esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtFechaNac2.Text = "" Then
            MessageBox.Show("El campo de Fecha de nacimiento esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtocupacion2.Text = "" Then
            MessageBox.Show("El campo de ocupacion esta vacio,Por Favor rellenelo")
            opc = 1
        ElseIf txtpeso2.Text = "" Then
            MessageBox.Show("El campo de peso esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtnumerotel2.Text = "" Then
            MessageBox.Show("El campo de numero de telefono esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf txtedad2.Text = "" Then
            MessageBox.Show("El campo de edad esta vacio,Por favor rellenelo")
            opc = 1
        ElseIf ComboBox3.SelectedIndex = -1 Then
            MessageBox.Show("El Campo de genero esta vacio,Por favor elija una opcion")
            opc = 1
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("El campo de especialidad esta vacio,Por favor elija una opcion")
            opc = 1
        End If
        If opc <> 1 Then
            datos(0, i) = txtnom2.Text 'nombre 
            datos(1, i) = txtcedula2.Text 'cedula 
            datos(2, i) = txtFechaNac2.Text 'fechadeNacimiento
            datos(3, i) = txtocupacion2.Text 'ocupacion 
            datos(4, i) = txtpeso2.Text 'peso 
            datos(5, i) = txtnumerotel2.Text 'numero de telefono 
            datos(6, i) = txtedad2.Text 'edad
            datos(7, i) = ComboBox3.Text
            datos(9, i) = ComboBox1.Text
            If RBsegurosi2.Checked Then
                datos(8, i) = "Sí"
            Else
                datos(8, i) = "No"
            End If
            i = i + 1
            limpiar()
        End If

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.RowCount = i + 1
        For k As Integer = 0 To i
            For j As Integer = 0 To 9
                DataGridView1(j, k).Value = datos(j, k)
            Next
        Next
    End Sub

    Private Sub RbSeguroSí_CheckedChanged(sender As Object, e As EventArgs) Handles RbSeguroSí.CheckedChanged

    End Sub
End Class
