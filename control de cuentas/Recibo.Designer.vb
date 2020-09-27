<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recibo
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recibo))
        Me.DGVclientes = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.Cedula = New System.Windows.Forms.Label()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.TextBoxV = New System.Windows.Forms.TextBox()
        Me.TextBoxF = New System.Windows.Forms.TextBox()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Richimp = New System.Windows.Forms.RichTextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.imprimir = New System.Windows.Forms.PictureBox()
        CType(Me.DGVclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVclientes
        '
        Me.DGVclientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVclientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVclientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVclientes.DefaultCellStyle = DataGridViewCellStyle12
        Me.DGVclientes.GridColor = System.Drawing.Color.DodgerBlue
        Me.DGVclientes.Location = New System.Drawing.Point(477, 85)
        Me.DGVclientes.Name = "DGVclientes"
        Me.DGVclientes.RowHeadersWidth = 62
        Me.DGVclientes.RowTemplate.Height = 28
        Me.DGVclientes.Size = New System.Drawing.Size(10, 10)
        Me.DGVclientes.TabIndex = 48
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = Global.control_de_cuentas.My.Resources.Resources.rwcibo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBoxC)
        Me.Panel1.Controls.Add(Me.Cedula)
        Me.Panel1.Controls.Add(Me.TextBoxN)
        Me.Panel1.Controls.Add(Me.TextBoxV)
        Me.Panel1.Controls.Add(Me.TextBoxF)
        Me.Panel1.Controls.Add(Me.TextBoxA)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Richimp)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.imprimir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 53
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(333, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 19)
        Me.TextBox2.TabIndex = 68
        Me.TextBox2.Text = "RECIBO DE PAGO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(545, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 22)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Serie"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(549, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 19)
        Me.TextBox1.TabIndex = 66
        '
        'TextBoxC
        '
        Me.TextBoxC.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxC.Location = New System.Drawing.Point(87, 81)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxC.TabIndex = 65
        '
        'Cedula
        '
        Me.Cedula.AutoSize = True
        Me.Cedula.BackColor = System.Drawing.Color.RoyalBlue
        Me.Cedula.Location = New System.Drawing.Point(93, 58)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(59, 20)
        Me.Cedula.TabIndex = 64
        Me.Cedula.Text = "Cedula"
        '
        'TextBoxN
        '
        Me.TextBoxN.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxN.Location = New System.Drawing.Point(87, 148)
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxN.TabIndex = 63
        '
        'TextBoxV
        '
        Me.TextBoxV.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxV.Location = New System.Drawing.Point(87, 343)
        Me.TextBoxV.Name = "TextBoxV"
        Me.TextBoxV.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxV.TabIndex = 62
        '
        'TextBoxF
        '
        Me.TextBoxF.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxF.Location = New System.Drawing.Point(87, 278)
        Me.TextBoxF.Name = "TextBoxF"
        Me.TextBoxF.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxF.TabIndex = 61
        '
        'TextBoxA
        '
        Me.TextBoxA.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxA.Location = New System.Drawing.Point(87, 217)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(138, 19)
        Me.TextBoxA.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(93, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(93, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(93, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(93, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nombre"
        '
        'Richimp
        '
        Me.Richimp.BackColor = System.Drawing.Color.DodgerBlue
        Me.Richimp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Richimp.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Richimp.Location = New System.Drawing.Point(259, 139)
        Me.Richimp.MaximumSize = New System.Drawing.Size(300, 300)
        Me.Richimp.Name = "Richimp"
        Me.Richimp.Size = New System.Drawing.Size(300, 275)
        Me.Richimp.TabIndex = 55
        Me.Richimp.Text = ""
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = Global.control_de_cuentas.My.Resources.Resources.png_transparent_hewlett_packard_printer_printing_computer_icons_button_hewlett_packard_blue_angle_ink
        Me.PictureBox5.Location = New System.Drawing.Point(577, 374)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(72, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 54
        Me.PictureBox5.TabStop = False
        '
        'imprimir
        '
        Me.imprimir.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imprimir.Image = Global.control_de_cuentas.My.Resources.Resources.exportar
        Me.imprimir.Location = New System.Drawing.Point(269, 93)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(72, 40)
        Me.imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imprimir.TabIndex = 53
        Me.imprimir.TabStop = False
        '
        'Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVclientes)
        Me.Name = "Recibo"
        Me.Opacity = 0.9R
        Me.Text = "Recibo"
        CType(Me.DGVclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVclientes As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents Cedula As Label
    Friend WithEvents TextBoxN As TextBox
    Friend WithEvents TextBoxV As TextBox
    Friend WithEvents TextBoxF As TextBox
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Richimp As RichTextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents imprimir As PictureBox
End Class
