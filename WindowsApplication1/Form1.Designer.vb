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
        Me.lblsaldoactual = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtultimosdigitos = New System.Windows.Forms.TextBox()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.txtconcepto = New System.Windows.Forms.TextBox()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnenviar = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtorigen = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.botonCerrar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblsaldoactual
        '
        Me.lblsaldoactual.AutoSize = True
        Me.lblsaldoactual.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldoactual.ForeColor = System.Drawing.Color.Transparent
        Me.lblsaldoactual.Location = New System.Drawing.Point(88, -33)
        Me.lblsaldoactual.Name = "lblsaldoactual"
        Me.lblsaldoactual.Size = New System.Drawing.Size(0, 20)
        Me.lblsaldoactual.TabIndex = 34
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Transparent
        Me.label7.Location = New System.Drawing.Point(7, -33)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(75, 20)
        Me.label7.TabIndex = 33
        Me.label7.Text = "Saldo Actual:"
        '
        'txtultimosdigitos
        '
        Me.txtultimosdigitos.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtultimosdigitos.ForeColor = System.Drawing.Color.Black
        Me.txtultimosdigitos.Location = New System.Drawing.Point(16, 318)
        Me.txtultimosdigitos.Name = "txtultimosdigitos"
        Me.txtultimosdigitos.Size = New System.Drawing.Size(144, 27)
        Me.txtultimosdigitos.TabIndex = 32
        '
        'txtimporte
        '
        Me.txtimporte.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.Color.Black
        Me.txtimporte.Location = New System.Drawing.Point(16, 263)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(125, 27)
        Me.txtimporte.TabIndex = 31
        '
        'txtconcepto
        '
        Me.txtconcepto.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconcepto.ForeColor = System.Drawing.Color.Black
        Me.txtconcepto.Location = New System.Drawing.Point(15, 210)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(126, 27)
        Me.txtconcepto.TabIndex = 30
        '
        'txtdestino
        '
        Me.txtdestino.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestino.ForeColor = System.Drawing.Color.Black
        Me.txtdestino.Location = New System.Drawing.Point(16, 161)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(125, 27)
        Me.txtdestino.TabIndex = 29
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(262, -96)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(31, 44)
        Me.btnCerrar.TabIndex = 28
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnenviar
        '
        Me.btnenviar.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnenviar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenviar.ForeColor = System.Drawing.Color.Transparent
        Me.btnenviar.Location = New System.Drawing.Point(12, 359)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(292, 52)
        Me.btnenviar.TabIndex = 27
        Me.btnenviar.Text = "Enviar"
        Me.btnenviar.UseVisualStyleBackColor = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(12, 295)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(183, 20)
        Me.label6.TabIndex = 26
        Me.label6.Text = "Ultimos 6 digitos de Targeta Debito"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(12, 240)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 20)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Importe"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(12, 187)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(55, 20)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Concepto"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(12, 138)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(83, 20)
        Me.label3.TabIndex = 23
        Me.label3.Text = "Cuenta Destino"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Transparent
        Me.label2.Location = New System.Drawing.Point(12, 82)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(94, 20)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Cuenta de Origen"
        '
        'txtorigen
        '
        Me.txtorigen.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorigen.ForeColor = System.Drawing.Color.Black
        Me.txtorigen.Location = New System.Drawing.Point(15, 105)
        Me.txtorigen.Name = "txtorigen"
        Me.txtorigen.Size = New System.Drawing.Size(126, 27)
        Me.txtorigen.TabIndex = 21
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(-8, -77)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(200, 44)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Transferencias"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(105, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(24, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Saldo Actual:"
        '
        'botonCerrar
        '
        Me.botonCerrar.FlatAppearance.BorderSize = 0
        Me.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonCerrar.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonCerrar.ForeColor = System.Drawing.Color.White
        Me.botonCerrar.Location = New System.Drawing.Point(276, 1)
        Me.botonCerrar.Name = "botonCerrar"
        Me.botonCerrar.Size = New System.Drawing.Size(31, 44)
        Me.botonCerrar.TabIndex = 36
        Me.botonCerrar.Text = "X"
        Me.botonCerrar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 44)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Transferencias"
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldo.ForeColor = System.Drawing.Color.Transparent
        Me.lblsaldo.Location = New System.Drawing.Point(105, 54)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(36, 20)
        Me.lblsaldo.TabIndex = 39
        Me.lblsaldo.Text = "saldo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(309, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblsaldo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.botonCerrar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblsaldoactual)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtultimosdigitos)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.txtconcepto)
        Me.Controls.Add(Me.txtdestino)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnenviar)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtorigen)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblsaldoactual As Label
    Private WithEvents label7 As Label
    Private WithEvents txtultimosdigitos As TextBox
    Private WithEvents txtimporte As TextBox
    Private WithEvents txtconcepto As TextBox
    Private WithEvents txtdestino As TextBox
    Friend WithEvents btnCerrar As Button
    Private WithEvents btnenviar As Button
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtorigen As TextBox
    Private WithEvents label1 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents botonCerrar As Button
    Private WithEvents Label10 As Label
    Private WithEvents lblsaldo As Label
End Class
