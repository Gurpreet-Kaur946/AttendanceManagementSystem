<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStud))
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblCls = New System.Windows.Forms.Label()
        Me.LblSub = New System.Windows.Forms.Label()
        Me.LblTchrName = New System.Windows.Forms.Label()
        Me.TxtStudId = New System.Windows.Forms.TextBox()
        Me.TxtStudName = New System.Windows.Forms.TextBox()
        Me.TxtTchrName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbSub = New System.Windows.Forms.ComboBox()
        Me.CmbCls = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(60, 42)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(81, 19)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Student ID"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(60, 81)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(104, 19)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Student Name"
        '
        'LblCls
        '
        Me.LblCls.AutoSize = True
        Me.LblCls.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCls.Location = New System.Drawing.Point(60, 120)
        Me.LblCls.Name = "LblCls"
        Me.LblCls.Size = New System.Drawing.Size(46, 19)
        Me.LblCls.TabIndex = 1
        Me.LblCls.Text = "Class"
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSub.Location = New System.Drawing.Point(60, 159)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(60, 19)
        Me.LblSub.TabIndex = 2
        Me.LblSub.Text = "Subject"
        '
        'LblTchrName
        '
        Me.LblTchrName.AutoSize = True
        Me.LblTchrName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTchrName.Location = New System.Drawing.Point(60, 199)
        Me.LblTchrName.Name = "LblTchrName"
        Me.LblTchrName.Size = New System.Drawing.Size(106, 19)
        Me.LblTchrName.TabIndex = 2
        Me.LblTchrName.Text = "Teacher Name"
        '
        'TxtStudId
        '
        Me.TxtStudId.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStudId.Location = New System.Drawing.Point(253, 35)
        Me.TxtStudId.Name = "TxtStudId"
        Me.TxtStudId.Size = New System.Drawing.Size(177, 27)
        Me.TxtStudId.TabIndex = 0
        '
        'TxtStudName
        '
        Me.TxtStudName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStudName.Location = New System.Drawing.Point(253, 74)
        Me.TxtStudName.Name = "TxtStudName"
        Me.TxtStudName.Size = New System.Drawing.Size(407, 27)
        Me.TxtStudName.TabIndex = 1
        '
        'TxtTchrName
        '
        Me.TxtTchrName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTchrName.Location = New System.Drawing.Point(253, 192)
        Me.TxtTchrName.Name = "TxtTchrName"
        Me.TxtTchrName.Size = New System.Drawing.Size(407, 27)
        Me.TxtTchrName.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.CmbSub)
        Me.GroupBox1.Controls.Add(Me.CmbCls)
        Me.GroupBox1.Controls.Add(Me.TxtTchrName)
        Me.GroupBox1.Controls.Add(Me.TxtStudName)
        Me.GroupBox1.Controls.Add(Me.TxtStudId)
        Me.GroupBox1.Controls.Add(Me.LblTchrName)
        Me.GroupBox1.Controls.Add(Me.LblSub)
        Me.GroupBox1.Controls.Add(Me.LblCls)
        Me.GroupBox1.Controls.Add(Me.LblName)
        Me.GroupBox1.Controls.Add(Me.LblId)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student's Details"
        '
        'CmbSub
        '
        Me.CmbSub.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub.FormattingEnabled = True
        Me.CmbSub.Items.AddRange(New Object() {"English", "Hindi", "Science", "Maths", "SSc"})
        Me.CmbSub.Location = New System.Drawing.Point(253, 156)
        Me.CmbSub.Name = "CmbSub"
        Me.CmbSub.Size = New System.Drawing.Size(177, 27)
        Me.CmbSub.TabIndex = 3
        '
        'CmbCls
        '
        Me.CmbCls.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCls.FormattingEnabled = True
        Me.CmbCls.Items.AddRange(New Object() {"3rd", "4rt", "5th", "6th", "7th"})
        Me.CmbCls.Location = New System.Drawing.Point(253, 113)
        Me.CmbCls.Name = "CmbCls"
        Me.CmbCls.Size = New System.Drawing.Size(121, 27)
        Me.CmbCls.TabIndex = 2
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.BackColor = System.Drawing.Color.LightCyan
        Me.BtnAdd.Location = New System.Drawing.Point(3, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(117, 39)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add New"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDel.BackColor = System.Drawing.Color.LightCyan
        Me.BtnDel.Location = New System.Drawing.Point(126, 5)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(117, 39)
        Me.BtnDel.TabIndex = 2
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightCyan
        Me.BtnUpdate.Location = New System.Drawing.Point(249, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(117, 39)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Edit"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSave.BackColor = System.Drawing.Color.LightCyan
        Me.BtnSave.Location = New System.Drawing.Point(372, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(117, 39)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExit.BackColor = System.Drawing.Color.LightCyan
        Me.BtnExit.Location = New System.Drawing.Point(495, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(119, 39)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 46)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(741, 262)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnDel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnExit, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 3, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(110, 387)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(617, 50)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'FrmStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 558)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblCls As Label
    Friend WithEvents LblSub As Label
    Friend WithEvents LblTchrName As Label
    Friend WithEvents TxtStudId As TextBox
    Friend WithEvents TxtStudName As TextBox
    Friend WithEvents TxtTchrName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents CmbCls As ComboBox
    Friend WithEvents CmbSub As ComboBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
