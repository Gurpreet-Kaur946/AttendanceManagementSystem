<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendanceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttendanceList))
        Me.GrdInfo = New System.Windows.Forms.DataGridView()
        Me.LblStudId = New System.Windows.Forms.Label()
        Me.TxtStudId = New System.Windows.Forms.TextBox()
        Me.BtnSrch = New System.Windows.Forms.Button()
        Me.GrpBxStudDet = New System.Windows.Forms.GroupBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GrpBxList = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GrdInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxStudDet.SuspendLayout()
        Me.GrpBxList.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdInfo
        '
        Me.GrdInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrdInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdInfo.Location = New System.Drawing.Point(26, 44)
        Me.GrdInfo.Name = "GrdInfo"
        Me.GrdInfo.RowHeadersWidth = 51
        Me.GrdInfo.RowTemplate.Height = 24
        Me.GrdInfo.Size = New System.Drawing.Size(984, 307)
        Me.GrdInfo.TabIndex = 0
        '
        'LblStudId
        '
        Me.LblStudId.AutoSize = True
        Me.LblStudId.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudId.Location = New System.Drawing.Point(26, 29)
        Me.LblStudId.Name = "LblStudId"
        Me.LblStudId.Size = New System.Drawing.Size(137, 19)
        Me.LblStudId.TabIndex = 1
        Me.LblStudId.Text = "Enter Student ID "
        '
        'TxtStudId
        '
        Me.TxtStudId.Location = New System.Drawing.Point(178, 26)
        Me.TxtStudId.Name = "TxtStudId"
        Me.TxtStudId.Size = New System.Drawing.Size(256, 27)
        Me.TxtStudId.TabIndex = 2
        '
        'BtnSrch
        '
        Me.BtnSrch.BackColor = System.Drawing.Color.LightCyan
        Me.BtnSrch.Location = New System.Drawing.Point(466, 25)
        Me.BtnSrch.Name = "BtnSrch"
        Me.BtnSrch.Size = New System.Drawing.Size(137, 34)
        Me.BtnSrch.TabIndex = 3
        Me.BtnSrch.Text = "Search"
        Me.BtnSrch.UseVisualStyleBackColor = False
        '
        'GrpBxStudDet
        '
        Me.GrpBxStudDet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBxStudDet.Controls.Add(Me.BtnExit)
        Me.GrpBxStudDet.Controls.Add(Me.BtnSrch)
        Me.GrpBxStudDet.Controls.Add(Me.TxtStudId)
        Me.GrpBxStudDet.Controls.Add(Me.LblStudId)
        Me.GrpBxStudDet.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxStudDet.Location = New System.Drawing.Point(11, 3)
        Me.GrpBxStudDet.Name = "GrpBxStudDet"
        Me.GrpBxStudDet.Size = New System.Drawing.Size(857, 85)
        Me.GrpBxStudDet.TabIndex = 4
        Me.GrpBxStudDet.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.LightCyan
        Me.BtnExit.Location = New System.Drawing.Point(622, 25)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(140, 34)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GrpBxList
        '
        Me.GrpBxList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpBxList.BackColor = System.Drawing.Color.LemonChiffon
        Me.GrpBxList.Controls.Add(Me.GrdInfo)
        Me.GrpBxList.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxList.Location = New System.Drawing.Point(5, 4)
        Me.GrpBxList.Name = "GrpBxList"
        Me.GrpBxList.Size = New System.Drawing.Size(1028, 377)
        Me.GrpBxList.TabIndex = 5
        Me.GrpBxList.TabStop = False
        Me.GrpBxList.Text = "Student List"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrpBxStudDet, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(31, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(879, 91)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GrpBxList, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(31, 136)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1038, 386)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'FrmAttendanceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1094, 563)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmAttendanceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance List"
        CType(Me.GrdInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxStudDet.ResumeLayout(False)
        Me.GrpBxStudDet.PerformLayout()
        Me.GrpBxList.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrdInfo As DataGridView
    Friend WithEvents LblStudId As Label
    Friend WithEvents TxtStudId As TextBox
    Friend WithEvents BtnSrch As Button
    Friend WithEvents GrpBxStudDet As GroupBox
    Friend WithEvents GrpBxList As GroupBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
