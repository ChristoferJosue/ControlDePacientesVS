<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Guardar1 = New System.Windows.Forms.Button()
        Me.txtnumerotel = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Labelpeso = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Labeledad = New System.Windows.Forms.Label()
        Me.RbSeguroNo = New System.Windows.Forms.RadioButton()
        Me.RbSeguroSí = New System.Windows.Forms.RadioButton()
        Me.txtocupacion = New System.Windows.Forms.TextBox()
        Me.txtFechadeNac = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Guardar2 = New System.Windows.Forms.Button()
        Me.txtnumerotel2 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Labelpeso2 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtpeso2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Labeledad2 = New System.Windows.Forms.Label()
        Me.RBsegurono2 = New System.Windows.Forms.RadioButton()
        Me.RBsegurosi2 = New System.Windows.Forms.RadioButton()
        Me.txtocupacion2 = New System.Windows.Forms.TextBox()
        Me.txtFechaNac2 = New System.Windows.Forms.TextBox()
        Me.txtedad2 = New System.Windows.Forms.TextBox()
        Me.txtnom2 = New System.Windows.Forms.TextBox()
        Me.txtcedula2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(20, 161)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(966, 404)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Guardar1)
        Me.TabPage1.Controls.Add(Me.txtnumerotel)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Labelpeso)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.txtpeso)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Labeledad)
        Me.TabPage1.Controls.Add(Me.RbSeguroNo)
        Me.TabPage1.Controls.Add(Me.RbSeguroSí)
        Me.TabPage1.Controls.Add(Me.txtocupacion)
        Me.TabPage1.Controls.Add(Me.txtFechadeNac)
        Me.TabPage1.Controls.Add(Me.txtedad)
        Me.TabPage1.Controls.Add(Me.txtnom)
        Me.TabPage1.Controls.Add(Me.txtcedula)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(958, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Formulario de solicitud de una cita"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Guardar1
        '
        Me.Guardar1.Location = New System.Drawing.Point(657, 313)
        Me.Guardar1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guardar1.Name = "Guardar1"
        Me.Guardar1.Size = New System.Drawing.Size(152, 28)
        Me.Guardar1.TabIndex = 48
        Me.Guardar1.Text = "Guardar Datos"
        Me.Guardar1.UseVisualStyleBackColor = True
        '
        'txtnumerotel
        '
        Me.txtnumerotel.Location = New System.Drawing.Point(531, 231)
        Me.txtnumerotel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumerotel.Multiline = True
        Me.txtnumerotel.Name = "txtnumerotel"
        Me.txtnumerotel.Size = New System.Drawing.Size(277, 19)
        Me.txtnumerotel.TabIndex = 47
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(384, 235)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(131, 16)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Número de Teléfono"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(45, 92)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(269, 16)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "Ingrese su peso para hacer calcularlo en Kg"
        '
        'Labelpeso
        '
        Me.Labelpeso.AutoSize = True
        Me.Labelpeso.Location = New System.Drawing.Point(159, 139)
        Me.Labelpeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelpeso.Name = "Labelpeso"
        Me.Labelpeso.Size = New System.Drawing.Size(0, 16)
        Me.Labelpeso.TabIndex = 44
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(63, 139)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(76, 16)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Peso en Kg"
        '
        'txtpeso
        '
        Me.txtpeso.Location = New System.Drawing.Point(169, 117)
        Me.txtpeso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(132, 22)
        Me.txtpeso.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Peso"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(48, 256)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(295, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Ingrese su edad para hacer calcularlo en meses"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(39, 336)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 16)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Edad en Meses:"
        '
        'Labeledad
        '
        Me.Labeledad.AutoSize = True
        Me.Labeledad.Location = New System.Drawing.Point(165, 336)
        Me.Labeledad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeledad.Name = "Labeledad"
        Me.Labeledad.Size = New System.Drawing.Size(0, 16)
        Me.Labeledad.TabIndex = 33
        '
        'RbSeguroNo
        '
        Me.RbSeguroNo.AutoSize = True
        Me.RbSeguroNo.Location = New System.Drawing.Point(620, 183)
        Me.RbSeguroNo.Margin = New System.Windows.Forms.Padding(4)
        Me.RbSeguroNo.Name = "RbSeguroNo"
        Me.RbSeguroNo.Size = New System.Drawing.Size(46, 20)
        Me.RbSeguroNo.TabIndex = 32
        Me.RbSeguroNo.TabStop = True
        Me.RbSeguroNo.Text = "No"
        Me.RbSeguroNo.UseVisualStyleBackColor = True
        '
        'RbSeguroSí
        '
        Me.RbSeguroSí.AutoSize = True
        Me.RbSeguroSí.Location = New System.Drawing.Point(620, 154)
        Me.RbSeguroSí.Margin = New System.Windows.Forms.Padding(4)
        Me.RbSeguroSí.Name = "RbSeguroSí"
        Me.RbSeguroSí.Size = New System.Drawing.Size(40, 20)
        Me.RbSeguroSí.TabIndex = 31
        Me.RbSeguroSí.TabStop = True
        Me.RbSeguroSí.Text = "Sí"
        Me.RbSeguroSí.UseVisualStyleBackColor = True
        '
        'txtocupacion
        '
        Me.txtocupacion.Location = New System.Drawing.Point(519, 89)
        Me.txtocupacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtocupacion.Multiline = True
        Me.txtocupacion.Name = "txtocupacion"
        Me.txtocupacion.Size = New System.Drawing.Size(277, 19)
        Me.txtocupacion.TabIndex = 30
        '
        'txtFechadeNac
        '
        Me.txtFechadeNac.Location = New System.Drawing.Point(553, 50)
        Me.txtFechadeNac.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechadeNac.Name = "txtFechadeNac"
        Me.txtFechadeNac.Size = New System.Drawing.Size(243, 22)
        Me.txtFechadeNac.TabIndex = 29
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(116, 292)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(132, 22)
        Me.txtedad.TabIndex = 26
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(139, 26)
        Me.txtnom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(132, 22)
        Me.txtnom.TabIndex = 25
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(139, 64)
        Me.txtcedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(132, 22)
        Me.txtcedula.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(463, 156)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 16)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Tiene seguro?"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(428, 91)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 16)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Ocupación "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(407, 54)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 16)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Fecha de nacimiento"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(65, 292)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "Edad"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(39, 186)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 16)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Género "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(39, 36)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 16)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Nombre"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(39, 64)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 16)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Cédula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.Guardar2)
        Me.TabPage2.Controls.Add(Me.txtnumerotel2)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.Labelpeso2)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.txtpeso2)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Labeledad2)
        Me.TabPage2.Controls.Add(Me.RBsegurono2)
        Me.TabPage2.Controls.Add(Me.RBsegurosi2)
        Me.TabPage2.Controls.Add(Me.txtocupacion2)
        Me.TabPage2.Controls.Add(Me.txtFechaNac2)
        Me.TabPage2.Controls.Add(Me.txtedad2)
        Me.TabPage2.Controls.Add(Me.txtnom2)
        Me.TabPage2.Controls.Add(Me.txtcedula2)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(958, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Formulario para Admisión a hospitalización"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Guardar2
        '
        Me.Guardar2.Location = New System.Drawing.Point(657, 318)
        Me.Guardar2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guardar2.Name = "Guardar2"
        Me.Guardar2.Size = New System.Drawing.Size(152, 28)
        Me.Guardar2.TabIndex = 50
        Me.Guardar2.Text = "Guardar Datos"
        Me.Guardar2.UseVisualStyleBackColor = True
        '
        'txtnumerotel2
        '
        Me.txtnumerotel2.Location = New System.Drawing.Point(548, 231)
        Me.txtnumerotel2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumerotel2.Multiline = True
        Me.txtnumerotel2.Name = "txtnumerotel2"
        Me.txtnumerotel2.Size = New System.Drawing.Size(277, 19)
        Me.txtnumerotel2.TabIndex = 49
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(409, 235)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(131, 16)
        Me.Label35.TabIndex = 48
        Me.Label35.Text = "Número de Teléfono"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(23, 90)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(269, 16)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "Ingrese su peso para hacer calcularlo en Kg"
        '
        'Labelpeso2
        '
        Me.Labelpeso2.AutoSize = True
        Me.Labelpeso2.Location = New System.Drawing.Point(133, 149)
        Me.Labelpeso2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelpeso2.Name = "Labelpeso2"
        Me.Labelpeso2.Size = New System.Drawing.Size(0, 16)
        Me.Labelpeso2.TabIndex = 41
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(37, 149)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 16)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "Peso en Kg"
        '
        'txtpeso2
        '
        Me.txtpeso2.Location = New System.Drawing.Point(137, 121)
        Me.txtpeso2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpeso2.Name = "txtpeso2"
        Me.txtpeso2.Size = New System.Drawing.Size(132, 22)
        Me.txtpeso2.TabIndex = 39
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(37, 121)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 16)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Peso"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(47, 261)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(295, 16)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Ingrese su edad para hacer calcularlo en meses"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 341)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Edad en Meses:"
        '
        'Labeledad2
        '
        Me.Labeledad2.AutoSize = True
        Me.Labeledad2.Location = New System.Drawing.Point(164, 341)
        Me.Labeledad2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeledad2.Name = "Labeledad2"
        Me.Labeledad2.Size = New System.Drawing.Size(0, 16)
        Me.Labeledad2.TabIndex = 14
        '
        'RBsegurono2
        '
        Me.RBsegurono2.AutoSize = True
        Me.RBsegurono2.Location = New System.Drawing.Point(619, 186)
        Me.RBsegurono2.Margin = New System.Windows.Forms.Padding(4)
        Me.RBsegurono2.Name = "RBsegurono2"
        Me.RBsegurono2.Size = New System.Drawing.Size(46, 20)
        Me.RBsegurono2.TabIndex = 13
        Me.RBsegurono2.TabStop = True
        Me.RBsegurono2.Text = "No"
        Me.RBsegurono2.UseVisualStyleBackColor = True
        '
        'RBsegurosi2
        '
        Me.RBsegurosi2.AutoSize = True
        Me.RBsegurosi2.Location = New System.Drawing.Point(619, 156)
        Me.RBsegurosi2.Margin = New System.Windows.Forms.Padding(4)
        Me.RBsegurosi2.Name = "RBsegurosi2"
        Me.RBsegurosi2.Size = New System.Drawing.Size(40, 20)
        Me.RBsegurosi2.TabIndex = 12
        Me.RBsegurosi2.TabStop = True
        Me.RBsegurosi2.Text = "Sí"
        Me.RBsegurosi2.UseVisualStyleBackColor = True
        '
        'txtocupacion2
        '
        Me.txtocupacion2.Location = New System.Drawing.Point(517, 91)
        Me.txtocupacion2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtocupacion2.Multiline = True
        Me.txtocupacion2.Name = "txtocupacion2"
        Me.txtocupacion2.Size = New System.Drawing.Size(277, 19)
        Me.txtocupacion2.TabIndex = 12
        '
        'txtFechaNac2
        '
        Me.txtFechaNac2.Location = New System.Drawing.Point(552, 53)
        Me.txtFechaNac2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaNac2.Name = "txtFechaNac2"
        Me.txtFechaNac2.Size = New System.Drawing.Size(243, 22)
        Me.txtFechaNac2.TabIndex = 11
        '
        'txtedad2
        '
        Me.txtedad2.Location = New System.Drawing.Point(115, 297)
        Me.txtedad2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtedad2.Name = "txtedad2"
        Me.txtedad2.Size = New System.Drawing.Size(132, 22)
        Me.txtedad2.TabIndex = 9
        '
        'txtnom2
        '
        Me.txtnom2.Location = New System.Drawing.Point(137, 21)
        Me.txtnom2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnom2.Name = "txtnom2"
        Me.txtnom2.Size = New System.Drawing.Size(132, 22)
        Me.txtnom2.TabIndex = 8
        '
        'txtcedula2
        '
        Me.txtcedula2.Location = New System.Drawing.Point(137, 53)
        Me.txtcedula2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcedula2.Name = "txtcedula2"
        Me.txtcedula2.Size = New System.Drawing.Size(132, 22)
        Me.txtcedula2.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(461, 159)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Tiene seguro?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(427, 94)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Ocupación "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(405, 57)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Fecha de nacimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 297)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Edad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 191)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Género "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 53)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cédula"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(958, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reporte de Pacientes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column6, Me.Column7, Me.Column4, Me.Column2, Me.Column3, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(958, 290)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cédula"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha de nacimiento"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Ocupacion"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Peso"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Numero de Telefono"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Edad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de Especialidad próxima a atenderse: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(488, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "de la Clínica Angel de la Guarda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(742, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido al Sistema de Registro y Control de los Pacientes "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Geriatría", "Medicina interna", "Nefrología", "Cardiología"})
        Me.ComboBox1.Location = New System.Drawing.Point(20, 96)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 87)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Solicitar una Cita"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(544, 87)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 53)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Admisión a Hospitalización"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo de Servicio: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1065, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(671, 87)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 53)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Impresión de los Pacientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1065, 374)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Cerrar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1065, 281)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 65)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Limpiar Registro"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(825, 297)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 50)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "mostrar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Femenino", "Masculino", "No Especifico"})
        Me.ComboBox2.Location = New System.Drawing.Point(116, 183)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 49
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Femenino", "Masculino", "No Especifico"})
        Me.ComboBox3.Location = New System.Drawing.Point(115, 191)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 51
        '
        'Column8
        '
        Me.Column8.HeaderText = "Genero"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Seguro"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Especialidad"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1355, 620)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Labeledad2 As Label
    Friend WithEvents RBsegurono2 As RadioButton
    Friend WithEvents RBsegurosi2 As RadioButton
    Friend WithEvents txtocupacion2 As TextBox
    Friend WithEvents txtFechaNac2 As TextBox
    Friend WithEvents txtedad2 As TextBox
    Friend WithEvents txtnom2 As TextBox
    Friend WithEvents txtcedula2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Labeledad As Label
    Friend WithEvents RbSeguroNo As RadioButton
    Friend WithEvents RbSeguroSí As RadioButton
    Friend WithEvents txtocupacion As TextBox
    Friend WithEvents txtFechadeNac As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtpeso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Labelpeso2 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtpeso2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtnumerotel As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Labelpeso As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtnumerotel2 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Guardar1 As Button
    Friend WithEvents Guardar2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
