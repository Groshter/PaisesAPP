﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.irInsertar = New System.Windows.Forms.ToolStripMenuItem()
        Me.irPaises = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTool})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuTool
        '
        Me.MenuTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.irInsertar, Me.irPaises})
        Me.MenuTool.Name = "MenuTool"
        Me.MenuTool.Size = New System.Drawing.Size(60, 24)
        Me.MenuTool.Text = "Menu"
        '
        'irInsertar
        '
        Me.irInsertar.Name = "irInsertar"
        Me.irInsertar.Size = New System.Drawing.Size(184, 26)
        Me.irInsertar.Text = "Insertar Paises"
        '
        'irPaises
        '
        Me.irPaises.Name = "irPaises"
        Me.irPaises.Size = New System.Drawing.Size(184, 26)
        Me.irPaises.Text = "Ver Paises"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuTool As ToolStripMenuItem
    Friend WithEvents irInsertar As ToolStripMenuItem
    Friend WithEvents irPaises As ToolStripMenuItem
End Class
