﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DoubleTrackBar1 = New WindowsApplication1.DoubleTrackBar()
        Me.SuspendLayout()
        '
        'DoubleTrackBar1
        '
        Me.DoubleTrackBar1.Location = New System.Drawing.Point(38, 39)
        Me.DoubleTrackBar1.Maximum = 10
        Me.DoubleTrackBar1.Minimum = 0
        Me.DoubleTrackBar1.Name = "DoubleTrackBar1"
        Me.DoubleTrackBar1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.DoubleTrackBar1.Size = New System.Drawing.Size(204, 107)
        Me.DoubleTrackBar1.SmallChange = 1
        Me.DoubleTrackBar1.TabIndex = 0
        Me.DoubleTrackBar1.Text = "DoubleTrackBar1"
        Me.DoubleTrackBar1.ValueLeft = 0
        Me.DoubleTrackBar1.ValueRight = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.DoubleTrackBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DoubleTrackBar1 As WindowsApplication1.DoubleTrackBar

End Class
