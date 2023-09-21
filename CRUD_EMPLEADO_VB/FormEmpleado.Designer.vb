<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormEmpleado))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelTitulo = New Panel()
        txtId = New TextBox()
        btn_cerrar = New Button()
        labelTitulo = New Label()
        Panel1 = New Panel()
        TxtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        PanelDatos = New Panel()
        BtnCancelar = New Button()
        BtnActualizar = New Button()
        BtnAdd = New Button()
        TxtSalario = New TextBox()
        Label4 = New Label()
        TextApellido = New TextBox()
        Label3 = New Label()
        TxtEdad = New TextBox()
        Label2 = New Label()
        TxtNombre = New TextBox()
        Label1 = New Label()
        BtnRegistrar = New Button()
        DataList = New DataGridView()
        PanelTitulo.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        PanelDatos.SuspendLayout()
        CType(DataList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = SystemColors.ActiveCaption
        PanelTitulo.Controls.Add(txtId)
        PanelTitulo.Controls.Add(btn_cerrar)
        PanelTitulo.Controls.Add(labelTitulo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(616, 47)
        PanelTitulo.TabIndex = 0
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(26, 5)
        txtId.Name = "txtId"
        txtId.Size = New Size(55, 39)
        txtId.TabIndex = 11
        ' 
        ' btn_cerrar
        ' 
        btn_cerrar.Location = New Point(565, 5)
        btn_cerrar.Name = "btn_cerrar"
        btn_cerrar.Size = New Size(39, 39)
        btn_cerrar.TabIndex = 1
        btn_cerrar.Text = "X"
        btn_cerrar.UseVisualStyleBackColor = True
        ' 
        ' labelTitulo
        ' 
        labelTitulo.AutoSize = True
        labelTitulo.Font = New Font("Showcard Gothic", 15F, FontStyle.Italic, GraphicsUnit.Point)
        labelTitulo.Location = New Point(194, 12)
        labelTitulo.MaximumSize = New Size(400, 30)
        labelTitulo.Name = "labelTitulo"
        labelTitulo.Size = New Size(176, 26)
        labelTitulo.TabIndex = 0
        labelTitulo.Text = "CRUD EMPLEADO"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TxtBuscar)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(616, 47)
        Panel1.TabIndex = 1
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(73, 3)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(438, 39)
        TxtBuscar.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(PanelDatos)
        Panel2.Controls.Add(BtnRegistrar)
        Panel2.Controls.Add(DataList)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 95)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(616, 345)
        Panel2.TabIndex = 2
        ' 
        ' PanelDatos
        ' 
        PanelDatos.Controls.Add(BtnCancelar)
        PanelDatos.Controls.Add(BtnActualizar)
        PanelDatos.Controls.Add(BtnAdd)
        PanelDatos.Controls.Add(TxtSalario)
        PanelDatos.Controls.Add(Label4)
        PanelDatos.Controls.Add(TextApellido)
        PanelDatos.Controls.Add(Label3)
        PanelDatos.Controls.Add(TxtEdad)
        PanelDatos.Controls.Add(Label2)
        PanelDatos.Controls.Add(TxtNombre)
        PanelDatos.Controls.Add(Label1)
        PanelDatos.Location = New Point(0, -1)
        PanelDatos.Name = "PanelDatos"
        PanelDatos.Size = New Size(616, 338)
        PanelDatos.TabIndex = 4
        PanelDatos.Visible = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.IndianRed
        BtnCancelar.Location = New Point(399, 266)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(112, 41)
        BtnCancelar.TabIndex = 10
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.BackColor = Color.Silver
        BtnActualizar.Location = New Point(246, 266)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(124, 41)
        BtnActualizar.TabIndex = 9
        BtnActualizar.Text = "Actualizar"
        BtnActualizar.TextImageRelation = TextImageRelation.ImageAboveText
        BtnActualizar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BtnAdd.Location = New Point(102, 266)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(112, 41)
        BtnAdd.TabIndex = 8
        BtnAdd.Text = "Agregar"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' TxtSalario
        ' 
        TxtSalario.Location = New Point(378, 127)
        TxtSalario.Name = "TxtSalario"
        TxtSalario.Size = New Size(124, 39)
        TxtSalario.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(287, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 32)
        Label4.TabIndex = 6
        Label4.Text = "Salario"
        ' 
        ' TextApellido
        ' 
        TextApellido.Location = New Point(144, 71)
        TextApellido.Name = "TextApellido"
        TextApellido.Size = New Size(358, 39)
        TextApellido.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 32)
        Label3.TabIndex = 4
        Label3.Text = "Apellidos"
        ' 
        ' TxtEdad
        ' 
        TxtEdad.Location = New Point(144, 127)
        TxtEdad.Name = "TxtEdad"
        TxtEdad.Size = New Size(104, 39)
        TxtEdad.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 32)
        Label2.TabIndex = 2
        Label2.Text = "Edad"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(144, 17)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(358, 39)
        TxtNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 32)
        Label1.TabIndex = 0
        Label1.Text = "Nombres"
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.Location = New Point(165, 253)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(249, 40)
        BtnRegistrar.TabIndex = 3
        BtnRegistrar.Text = "Nuevo Empleado"
        BtnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' DataList
        ' 
        DataList.AllowUserToAddRows = False
        DataList.AllowUserToDeleteRows = False
        DataList.AllowUserToResizeColumns = False
        DataList.BackgroundColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataList.ColumnHeadersHeight = 40
        DataList.Location = New Point(73, 17)
        DataList.Name = "DataList"
        DataList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataList.RowTemplate.Height = 25
        DataList.Size = New Size(447, 202)
        DataList.TabIndex = 0
        ' 
        ' FormEmpleado
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(616, 440)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PanelTitulo)
        Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEmpleado"
        Text = "Form1"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        PanelDatos.ResumeLayout(False)
        PanelDatos.PerformLayout()
        CType(DataList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents labelTitulo As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents DataList As DataGridView
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents txtId As TextBox
End Class
