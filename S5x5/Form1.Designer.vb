<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvChave = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTxtEnt = New System.Windows.Forms.TextBox()
        Me.txtTxtSaida = New System.Windows.Forms.TextBox()
        Me.lblTxtEnt = New System.Windows.Forms.Label()
        Me.lblTxtSaida = New System.Windows.Forms.Label()
        Me.cmdCript = New System.Windows.Forms.Button()
        CType(Me.dgvChave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvChave
        '
        Me.dgvChave.AllowUserToAddRows = False
        Me.dgvChave.AllowUserToResizeColumns = False
        Me.dgvChave.AllowUserToResizeRows = False
        Me.dgvChave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChave.ColumnHeadersVisible = False
        Me.dgvChave.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvChave.Location = New System.Drawing.Point(12, 12)
        Me.dgvChave.Name = "dgvChave"
        Me.dgvChave.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvChave.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvChave.RowTemplate.Height = 60
        Me.dgvChave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvChave.Size = New System.Drawing.Size(468, 441)
        Me.dgvChave.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 60
        '
        'txtTxtEnt
        '
        Me.txtTxtEnt.Location = New System.Drawing.Point(486, 28)
        Me.txtTxtEnt.Multiline = True
        Me.txtTxtEnt.Name = "txtTxtEnt"
        Me.txtTxtEnt.Size = New System.Drawing.Size(213, 68)
        Me.txtTxtEnt.TabIndex = 1
        '
        'txtTxtSaida
        '
        Me.txtTxtSaida.Location = New System.Drawing.Point(489, 144)
        Me.txtTxtSaida.Multiline = True
        Me.txtTxtSaida.Name = "txtTxtSaida"
        Me.txtTxtSaida.Size = New System.Drawing.Size(213, 121)
        Me.txtTxtSaida.TabIndex = 2
        '
        'lblTxtEnt
        '
        Me.lblTxtEnt.AutoSize = True
        Me.lblTxtEnt.Location = New System.Drawing.Point(483, 12)
        Me.lblTxtEnt.Name = "lblTxtEnt"
        Me.lblTxtEnt.Size = New System.Drawing.Size(72, 13)
        Me.lblTxtEnt.TabIndex = 3
        Me.lblTxtEnt.Text = "Digite o texto:"
        '
        'lblTxtSaida
        '
        Me.lblTxtSaida.AutoSize = True
        Me.lblTxtSaida.Location = New System.Drawing.Point(486, 128)
        Me.lblTxtSaida.Name = "lblTxtSaida"
        Me.lblTxtSaida.Size = New System.Drawing.Size(58, 13)
        Me.lblTxtSaida.TabIndex = 4
        Me.lblTxtSaida.Text = "Resultado:"
        '
        'cmdCript
        '
        Me.cmdCript.Location = New System.Drawing.Point(489, 102)
        Me.cmdCript.Name = "cmdCript"
        Me.cmdCript.Size = New System.Drawing.Size(210, 23)
        Me.cmdCript.TabIndex = 5
        Me.cmdCript.Text = "Criptografar"
        Me.cmdCript.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 465)
        Me.Controls.Add(Me.cmdCript)
        Me.Controls.Add(Me.lblTxtSaida)
        Me.Controls.Add(Me.lblTxtEnt)
        Me.Controls.Add(Me.txtTxtSaida)
        Me.Controls.Add(Me.txtTxtEnt)
        Me.Controls.Add(Me.dgvChave)
        Me.Name = "main"
        Me.Text = "Form1"
        CType(Me.dgvChave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvChave As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTxtEnt As System.Windows.Forms.TextBox
    Friend WithEvents txtTxtSaida As System.Windows.Forms.TextBox
    Friend WithEvents lblTxtEnt As System.Windows.Forms.Label
    Friend WithEvents lblTxtSaida As System.Windows.Forms.Label
    Friend WithEvents cmdCript As System.Windows.Forms.Button

End Class
