<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Preview = New System.Windows.Forms.PrintPreviewDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBoxsuma = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.TextBoxV = New System.Windows.Forms.TextBox()
        Me.TextBoxF = New System.Windows.Forms.TextBox()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cedula = New System.Windows.Forms.Label()
        Me.DGVclientes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'Preview
        '
        Me.Preview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Preview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Preview.ClientSize = New System.Drawing.Size(400, 300)
        Me.Preview.Enabled = True
        Me.Preview.Icon = CType(resources.GetObject("Preview.Icon"), System.Drawing.Icon)
        Me.Preview.Name = "Preview"
        Me.Preview.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.control_de_cuentas.My.Resources.Resources.fondo_tecnologico_brillante_azul_36402_430
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.TextBoxFecha)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.TextBoxsuma)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBoxB)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBoxN)
        Me.Panel1.Controls.Add(Me.TextBoxV)
        Me.Panel1.Controls.Add(Me.TextBoxF)
        Me.Panel1.Controls.Add(Me.TextBoxA)
        Me.Panel1.Controls.Add(Me.TextBoxC)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cedula)
        Me.Panel1.Controls.Add(Me.DGVclientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1591, 770)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "V.3.0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Blue
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.LinkVisited = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1381, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(207, 28)
        Me.LinkLabel1.TabIndex = 29
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nuestra pagina web"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(518, 449)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(181, 42)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "crear recibo"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(760, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(602, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(303, 26)
        Me.DateTimePicker1.TabIndex = 25
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.control_de_cuentas.My.Resources.Resources.que_es_un_reporte
        Me.PictureBox4.Location = New System.Drawing.Point(764, 423)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(93, 85)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.BackgroundImage = Global.control_de_cuentas.My.Resources.Resources._1457188
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(379, 189)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(54, 42)
        Me.Button6.TabIndex = 23
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBoxFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFecha.Location = New System.Drawing.Point(250, 200)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(110, 19)
        Me.TextBoxFecha.TabIndex = 22
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.control_de_cuentas.My.Resources.Resources.Actions_edit_clear_list_icon
        Me.PictureBox3.Location = New System.Drawing.Point(1402, 67)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'TextBoxsuma
        '
        Me.TextBoxsuma.BackColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxsuma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxsuma.ForeColor = System.Drawing.Color.Tomato
        Me.TextBoxsuma.Location = New System.Drawing.Point(1240, 382)
        Me.TextBoxsuma.Name = "TextBoxsuma"
        Me.TextBoxsuma.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxsuma.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(368, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 34)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.control_de_cuentas.My.Resources.Resources.Excel_2013_23480
        Me.PictureBox2.Location = New System.Drawing.Point(411, 379)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.control_de_cuentas.My.Resources.Resources._7
        Me.PictureBox1.Location = New System.Drawing.Point(326, 382)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TextBoxB
        '
        Me.TextBoxB.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxB.Location = New System.Drawing.Point(250, 64)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(110, 19)
        Me.TextBoxB.TabIndex = 16
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button5.BackgroundImage = Global.control_de_cuentas.My.Resources.Resources.vieu
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(224, 382)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(51, 37)
        Me.Button5.TabIndex = 15
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.BackgroundImage = Global.control_de_cuentas.My.Resources.Resources._296382
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(379, 53)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 42)
        Me.Button4.TabIndex = 14
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(239, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 34)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(97, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxN
        '
        Me.TextBoxN.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxN.Location = New System.Drawing.Point(81, 131)
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxN.TabIndex = 10
        '
        'TextBoxV
        '
        Me.TextBoxV.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxV.Location = New System.Drawing.Point(81, 326)
        Me.TextBoxV.Name = "TextBoxV"
        Me.TextBoxV.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxV.TabIndex = 9
        '
        'TextBoxF
        '
        Me.TextBoxF.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxF.Location = New System.Drawing.Point(81, 261)
        Me.TextBoxF.Name = "TextBoxF"
        Me.TextBoxF.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxF.TabIndex = 8
        '
        'TextBoxA
        '
        Me.TextBoxA.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxA.Location = New System.Drawing.Point(81, 200)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxA.TabIndex = 7
        '
        'TextBoxC
        '
        Me.TextBoxC.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxC.Location = New System.Drawing.Point(81, 67)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxC.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(87, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(87, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(87, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(87, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Cedula
        '
        Me.Cedula.AutoSize = True
        Me.Cedula.BackColor = System.Drawing.Color.RoyalBlue
        Me.Cedula.Location = New System.Drawing.Point(87, 44)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(59, 20)
        Me.Cedula.TabIndex = 1
        Me.Cedula.Text = "Cedula"
        '
        'DGVclientes
        '
        Me.DGVclientes.BackgroundColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVclientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVclientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVclientes.GridColor = System.Drawing.Color.DodgerBlue
        Me.DGVclientes.Location = New System.Drawing.Point(579, 67)
        Me.DGVclientes.Name = "DGVclientes"
        Me.DGVclientes.RowHeadersWidth = 62
        Me.DGVclientes.RowTemplate.Height = 28
        Me.DGVclientes.Size = New System.Drawing.Size(813, 309)
        Me.DGVclientes.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1591, 770)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cobros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVclientes As DataGridView
    Friend WithEvents TextBoxN As TextBox
    Friend WithEvents TextBoxV As TextBox
    Friend WithEvents TextBoxF As TextBox
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cedula As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxsuma As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBoxFecha As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label6 As Label
    Friend WithEvents Preview As PrintPreviewDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button7 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
