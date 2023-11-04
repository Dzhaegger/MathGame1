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
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.btnreiniciar = New System.Windows.Forms.Button()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblIntentos = New System.Windows.Forms.Label()
        Me.btnminizar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblmaintext = New System.Windows.Forms.Label()
        Me.pnltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnltop.Controls.Add(Me.lblmaintext)
        Me.pnltop.Controls.Add(Me.btncerrar)
        Me.pnltop.Controls.Add(Me.btnminizar)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(635, 41)
        Me.pnltop.TabIndex = 0
        '
        'btnreiniciar
        '
        Me.btnreiniciar.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreiniciar.Location = New System.Drawing.Point(124, 252)
        Me.btnreiniciar.Name = "btnreiniciar"
        Me.btnreiniciar.Size = New System.Drawing.Size(164, 43)
        Me.btnreiniciar.TabIndex = 1
        Me.btnreiniciar.Text = "Reiniciar"
        Me.btnreiniciar.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirmar.Location = New System.Drawing.Point(323, 252)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(158, 43)
        Me.btnconfirmar.TabIndex = 2
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(124, 103)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(357, 48)
        Me.txtnumero.TabIndex = 3
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(164, 202)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(105, 30)
        Me.lblResultado.TabIndex = 4
        Me.lblResultado.Text = "resultado"
        '
        'lblIntentos
        '
        Me.lblIntentos.AutoSize = True
        Me.lblIntentos.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntentos.Location = New System.Drawing.Point(203, 163)
        Me.lblIntentos.Name = "lblIntentos"
        Me.lblIntentos.Size = New System.Drawing.Size(85, 25)
        Me.lblIntentos.TabIndex = 5
        Me.lblIntentos.Text = "intentos"
        Me.lblIntentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnminizar
        '
        Me.btnminizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminizar.BackgroundImage = Global.MathGame1.My.Resources.Resources._211863_minus_round_icon
        Me.btnminizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnminizar.FlatAppearance.BorderSize = 0
        Me.btnminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminizar.Location = New System.Drawing.Point(530, 0)
        Me.btnminizar.Name = "btnminizar"
        Me.btnminizar.Size = New System.Drawing.Size(52, 41)
        Me.btnminizar.TabIndex = 6
        Me.btnminizar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackgroundImage = Global.MathGame1.My.Resources.Resources.CROSS_1
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Location = New System.Drawing.Point(583, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 41)
        Me.btncerrar.TabIndex = 7
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblmaintext
        '
        Me.lblmaintext.AutoSize = True
        Me.lblmaintext.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaintext.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblmaintext.Location = New System.Drawing.Point(2, 0)
        Me.lblmaintext.Name = "lblmaintext"
        Me.lblmaintext.Size = New System.Drawing.Size(222, 37)
        Me.lblmaintext.TabIndex = 6
        Me.lblmaintext.Text = "NumberGuesser"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 382)
        Me.Controls.Add(Me.lblIntentos)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnreiniciar)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnltop As Panel
    Friend WithEvents btnreiniciar As Button
    Friend WithEvents btnconfirmar As Button
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblIntentos As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminizar As Button
    Friend WithEvents lblmaintext As Label
End Class
