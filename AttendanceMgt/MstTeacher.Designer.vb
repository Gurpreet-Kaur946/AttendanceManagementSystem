<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTeacher))
        Me.LblTchrId = New System.Windows.Forms.Label()
        Me.LblTchrName = New System.Windows.Forms.Label()
        Me.LblCls = New System.Windows.Forms.Label()
        Me.LblSub = New System.Windows.Forms.Label()
        Me.TxtTchrId = New System.Windows.Forms.TextBox()
        Me.TxtTchrName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbSub = New System.Windows.Forms.ComboBox()
        Me.CmbCls = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTchrId
        '
        Me.LblTchrId.AutoSize = True
        Me.LblTchrId.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTchrId.Location = New System.Drawing.Point(47, 52)
        Me.LblTchrId.Name = "LblTchrId"
        Me.LblTchrId.Size = New System.Drawing.Size(79, 19)
        Me.LblTchrId.TabIndex = 0
        Me.LblTchrId.Text = "Teacher Id"
        '
        'LblTchrName
        '
        Me.LblTchrName.AutoSize = True
        Me.LblTchrName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTchrName.Location = New System.Drawing.Point(47, 86)
        Me.LblTchrName.Name = "LblTchrName"
        Me.LblTchrName.Size = New System.Drawing.Size(106, 19)
        Me.LblTchrName.TabIndex = 0
        Me.LblTchrName.Text = "Teacher Name"
        '
        'LblCls
        '
        Me.LblCls.AutoSize = True
        Me.LblCls.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCls.Location = New System.Drawing.Point(47, 117)
        Me.LblCls.Name = "LblCls"
        Me.LblCls.Size = New System.Drawing.Size(46, 19)
        Me.LblCls.TabIndex = 0
        Me.LblCls.Text = "Class"
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSub.Location = New System.Drawing.Point(47, 149)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(60, 19)
        Me.LblSub.TabIndex = 0
        Me.LblSub.Text = "Subject"
        '
        'TxtTchrId
        '
        Me.TxtTchrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTchrId.Location = New System.Drawing.Point(214, 47)
        Me.TxtTchrId.Name = "TxtTchrId"
        Me.TxtTchrId.Size = New System.Drawing.Size(156, 22)
        Me.TxtTchrId.TabIndex = 0
        '
        'TxtTchrName
        '
        Me.TxtTchrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTchrName.Location = New System.Drawing.Point(214, 81)
        Me.TxtTchrName.Name = "TxtTchrName"
        Me.TxtTchrName.Size = New System.Drawing.Size(374, 22)
        Me.TxtTchrName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.CmbSub)
        Me.GroupBox1.Controls.Add(Me.CmbCls)
        Me.GroupBox1.Controls.Add(Me.TxtTchrName)
        Me.GroupBox1.Controls.Add(Me.TxtTchrId)
        Me.GroupBox1.Controls.Add(Me.LblSub)
        Me.GroupBox1.Controls.Add(Me.LblCls)
        Me.GroupBox1.Controls.Add(Me.LblTchrName)
        Me.GroupBox1.Controls.Add(Me.LblTchrId)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'CmbSub
        '
        Me.CmbSub.FormattingEnabled = True
        Me.CmbSub.Items.AddRange(New Object() {"English", "Hindi", "Science", "Maths", "SSc"})
        Me.CmbSub.Location = New System.Drawing.Point(214, 149)
        Me.CmbSub.Name = "CmbSub"
        Me.CmbSub.Size = New System.Drawing.Size(157, 27)
        Me.CmbSub.TabIndex = 3
        '
        'CmbCls
        '
        Me.CmbCls.FormattingEnabled = True
        Me.CmbCls.Items.AddRange(New Object() {"2nd", "3rd", "4th ", "5th", "6th", "7th"})
        Me.CmbCls.Location = New System.Drawing.Point(214, 114)
        Me.CmbCls.Name = "CmbCls"
        Me.CmbCls.Size = New System.Drawing.Size(121, 27)
        Me.CmbCls.TabIndex = 2
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.BackColor = System.Drawing.Color.LightCyan
        Me.BtnAdd.Location = New System.Drawing.Point(3, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(119, 36)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add New"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDel.BackColor = System.Drawing.Color.LightCyan
        Me.BtnDel.Location = New System.Drawing.Point(128, 3)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(119, 36)
        Me.BtnDel.TabIndex = 2
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.BackColor = System.Drawing.Color.LightCyan
        Me.BtnEdit.Location = New System.Drawing.Point(253, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(119, 36)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExit.BackColor = System.Drawing.Color.LightCyan
        Me.BtnExit.Location = New System.Drawing.Point(503, 3)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(119, 36)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSave.BackColor = System.Drawing.Color.LightCyan
        Me.BtnSave.Location = New System.Drawing.Point(378, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(119, 36)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(52, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.02615!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(774, 224)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnDel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnExit, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnEdit, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 3, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(140, 285)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(625, 43)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'FrmTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(904, 404)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTchrId As Label
    Friend WithEvents LblTchrName As Label
    Friend WithEvents LblCls As Label
    Friend WithEvents LblSub As Label
    Friend WithEvents TxtTchrId As TextBox
    Friend WithEvents TxtTchrName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbCls As ComboBox
    Friend WithEvents CmbSub As ComboBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
