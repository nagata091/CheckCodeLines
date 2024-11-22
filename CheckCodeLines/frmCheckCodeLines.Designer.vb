<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckCodeLines
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolderPath = New System.Windows.Forms.TextBox()
        Me.btnSelectFolder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExecCheck = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAllCodeNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodeNum = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKakuchoshi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "①フォルダを選択"
        '
        'txtFolderPath
        '
        Me.txtFolderPath.Font = New System.Drawing.Font("Meiryo UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFolderPath.Location = New System.Drawing.Point(12, 35)
        Me.txtFolderPath.Name = "txtFolderPath"
        Me.txtFolderPath.ReadOnly = True
        Me.txtFolderPath.Size = New System.Drawing.Size(364, 24)
        Me.txtFolderPath.TabIndex = 1
        '
        'btnSelectFolder
        '
        Me.btnSelectFolder.Location = New System.Drawing.Point(382, 19)
        Me.btnSelectFolder.Name = "btnSelectFolder"
        Me.btnSelectFolder.Size = New System.Drawing.Size(89, 52)
        Me.btnSelectFolder.TabIndex = 1
        Me.btnSelectFolder.Text = "選択"
        Me.btnSelectFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "②チェックを実行"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "③結果を表示"
        '
        'btnExecCheck
        '
        Me.btnExecCheck.Location = New System.Drawing.Point(196, 103)
        Me.btnExecCheck.Name = "btnExecCheck"
        Me.btnExecCheck.Size = New System.Drawing.Size(246, 60)
        Me.btnExecCheck.TabIndex = 2
        Me.btnExecCheck.Text = "実行"
        Me.btnExecCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "総行数"
        '
        'txtAllCodeNum
        '
        Me.txtAllCodeNum.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAllCodeNum.Location = New System.Drawing.Point(99, 211)
        Me.txtAllCodeNum.Name = "txtAllCodeNum"
        Me.txtAllCodeNum.ReadOnly = True
        Me.txtAllCodeNum.Size = New System.Drawing.Size(131, 32)
        Me.txtAllCodeNum.TabIndex = 1
        Me.txtAllCodeNum.Text = "0000000"
        Me.txtAllCodeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "行"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "コメント行と空行を除くと..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "行"
        '
        'txtCodeNum
        '
        Me.txtCodeNum.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCodeNum.Location = New System.Drawing.Point(99, 297)
        Me.txtCodeNum.Name = "txtCodeNum"
        Me.txtCodeNum.ReadOnly = True
        Me.txtCodeNum.Size = New System.Drawing.Size(131, 32)
        Me.txtCodeNum.TabIndex = 1
        Me.txtCodeNum.Text = "0000000"
        Me.txtCodeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(337, 297)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 52)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "有効行数"
        '
        'txtKakuchoshi
        '
        Me.txtKakuchoshi.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtKakuchoshi.Location = New System.Drawing.Point(68, 131)
        Me.txtKakuchoshi.Name = "txtKakuchoshi"
        Me.txtKakuchoshi.Size = New System.Drawing.Size(97, 32)
        Me.txtKakuchoshi.TabIndex = 1
        Me.txtKakuchoshi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "拡張子を指定"
        '
        'frmCheckSolutionCodeLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.btnExecCheck)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSelectFolder)
        Me.Controls.Add(Me.txtCodeNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAllCodeNum)
        Me.Controls.Add(Me.txtKakuchoshi)
        Me.Controls.Add(Me.txtFolderPath)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmCheckSolutionCodeLines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "フォルダ内の指定拡張子ファイルの行数をチェックするツール"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents btnSelectFolder As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExecCheck As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAllCodeNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodeNum As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKakuchoshi As TextBox
    Friend WithEvents Label9 As Label
End Class
