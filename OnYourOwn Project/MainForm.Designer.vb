<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.txtItemInput = New System.Windows.Forms.TextBox()
        Me.lblItemCountInputLabel = New System.Windows.Forms.Label()
        Me.btn64Stack = New System.Windows.Forms.RadioButton()
        Me.btn16Stack = New System.Windows.Forms.RadioButton()
        Me.lblStackCount = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStacksOutputContext = New System.Windows.Forms.Label()
        Me.lblItemCount = New System.Windows.Forms.Label()
        Me.lblItemsOutputContext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtItemInput
        '
        Me.txtItemInput.Location = New System.Drawing.Point(12, 25)
        Me.txtItemInput.Name = "txtItemInput"
        Me.txtItemInput.Size = New System.Drawing.Size(100, 20)
        Me.txtItemInput.TabIndex = 1
        '
        'lblItemCountInputLabel
        '
        Me.lblItemCountInputLabel.AutoSize = True
        Me.lblItemCountInputLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCountInputLabel.Location = New System.Drawing.Point(27, 9)
        Me.lblItemCountInputLabel.Name = "lblItemCountInputLabel"
        Me.lblItemCountInputLabel.Size = New System.Drawing.Size(70, 15)
        Me.lblItemCountInputLabel.TabIndex = 0
        Me.lblItemCountInputLabel.Text = "&Item Count:"
        '
        'btn64Stack
        '
        Me.btn64Stack.AutoSize = True
        Me.btn64Stack.Checked = True
        Me.btn64Stack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn64Stack.Location = New System.Drawing.Point(12, 51)
        Me.btn64Stack.Name = "btn64Stack"
        Me.btn64Stack.Size = New System.Drawing.Size(87, 19)
        Me.btn64Stack.TabIndex = 2
        Me.btn64Stack.TabStop = True
        Me.btn64Stack.Text = "Stacks to 64"
        Me.btn64Stack.UseVisualStyleBackColor = True
        '
        'btn16Stack
        '
        Me.btn16Stack.AutoSize = True
        Me.btn16Stack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn16Stack.Location = New System.Drawing.Point(12, 74)
        Me.btn16Stack.Name = "btn16Stack"
        Me.btn16Stack.Size = New System.Drawing.Size(87, 19)
        Me.btn16Stack.TabIndex = 3
        Me.btn16Stack.Text = "Stacks to 16"
        Me.btn16Stack.UseVisualStyleBackColor = True
        '
        'lblStackCount
        '
        Me.lblStackCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStackCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStackCount.Location = New System.Drawing.Point(132, 13)
        Me.lblStackCount.Name = "lblStackCount"
        Me.lblStackCount.Size = New System.Drawing.Size(50, 32)
        Me.lblStackCount.TabIndex = 6
        Me.lblStackCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(132, 51)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(201, 42)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate stacks"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(345, 51)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 42)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStacksOutputContext
        '
        Me.lblStacksOutputContext.AutoSize = True
        Me.lblStacksOutputContext.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStacksOutputContext.Location = New System.Drawing.Point(182, 13)
        Me.lblStacksOutputContext.Name = "lblStacksOutputContext"
        Me.lblStacksOutputContext.Size = New System.Drawing.Size(125, 32)
        Me.lblStacksOutputContext.TabIndex = 7
        Me.lblStacksOutputContext.Text = "stacks and"
        '
        'lblItemCount
        '
        Me.lblItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemCount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCount.Location = New System.Drawing.Point(307, 13)
        Me.lblItemCount.Name = "lblItemCount"
        Me.lblItemCount.Size = New System.Drawing.Size(49, 32)
        Me.lblItemCount.TabIndex = 8
        Me.lblItemCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblItemsOutputContext
        '
        Me.lblItemsOutputContext.AutoSize = True
        Me.lblItemsOutputContext.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsOutputContext.Location = New System.Drawing.Point(357, 13)
        Me.lblItemsOutputContext.Name = "lblItemsOutputContext"
        Me.lblItemsOutputContext.Size = New System.Drawing.Size(78, 32)
        Me.lblItemsOutputContext.TabIndex = 9
        Me.lblItemsOutputContext.Text = "items."
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 107)
        Me.Controls.Add(Me.lblItemsOutputContext)
        Me.Controls.Add(Me.lblItemCount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblStackCount)
        Me.Controls.Add(Me.btn16Stack)
        Me.Controls.Add(Me.btn64Stack)
        Me.Controls.Add(Me.lblItemCountInputLabel)
        Me.Controls.Add(Me.txtItemInput)
        Me.Controls.Add(Me.lblStacksOutputContext)
        Me.Name = "MainForm"
        Me.Text = "Minecraft Stack Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemInput As TextBox
    Friend WithEvents lblItemCountInputLabel As Label
    Friend WithEvents btn64Stack As RadioButton
    Friend WithEvents btn16Stack As RadioButton
    Friend WithEvents lblStackCount As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStacksOutputContext As Label
    Friend WithEvents lblItemCount As Label
    Friend WithEvents lblItemsOutputContext As Label
End Class
