Imports System.IO

Public Class frmCheckCodeLines

    ''' <summary>
    ''' 画面ロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmCheckSolutionCodeLines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call initApp()
        Call switchBtnElable()
    End Sub

    ''' <summary>
    ''' 閉じるボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 選択ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs) Handles btnSelectFolder.Click
        Call execSelectFolder()
    End Sub

    ''' <summary>
    ''' 実行ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExecCheck_Click(sender As Object, e As EventArgs) Handles btnExecCheck.Click
        If txtFolderPath.Text <> "" AndAlso txtKakuchoshi.Text <> "" Then
            Call execCheck()
        End If
    End Sub

    ''' <summary>
    ''' テキストチェンジ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtFolderPath.TextChanged, txtKakuchoshi.TextChanged
        Call switchBtnElable()
    End Sub

    ''' <summary>
    ''' 画面初期化
    ''' </summary>
    Private Sub initApp()
        txtFolderPath.Text = ""
        txtKakuchoshi.Text = ""
        txtAllCodeNum.Text = ""
        txtCodeNum.Text = ""
    End Sub

    ''' <summary>
    ''' フォルダ選択と拡張子指定をしていなかったら実行ボタンを押せない
    ''' </summary>
    Private Sub switchBtnElable()
        If txtFolderPath.Text = "" OrElse txtKakuchoshi.Text = "" Then
            btnExecCheck.Enabled = False
        Else
            btnExecCheck.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' フォルダ選択し、選択したフォルダパスをテキストボックスに入力
    ''' </summary>
    Private Sub execSelectFolder()
        ' FolderBrowserDialogを作成
        Using folderDialog As New FolderBrowserDialog
            ' ダイアログの説明文を設定
            folderDialog.Description = "ソリューションのルートフォルダを選択してください"
            ' ルートフォルダー（初期表示）を設定（ここではデスクトップ）
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop
            ' ダイアログを表示
            If folderDialog.ShowDialog() = DialogResult.OK Then
                ' 選択されたフォルダーパスをテキストボックスに設定
                txtFolderPath.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub

    ''' <summary>
    ''' 行数チェックを実行
    ''' </summary>
    Private Sub execCheck()
        '指定された拡張子を取得
        Dim kakuchoshi As String = txtKakuchoshi.Text
        If Strings.Left(kakuchoshi, 1) <> "." Then
            kakuchoshi = "." & kakuchoshi
        End If
        'フォルダパスを取得
        Dim folderPath As String = txtFolderPath.Text
        '行数を定義
        Dim totalLines As Integer = 0

        '総行数を取得
        For Each file As String In Directory.GetFiles(folderPath, "*" & kakuchoshi, SearchOption.AllDirectories)
            Dim lines As Integer = System.IO.File.ReadAllLines(file).Length
            totalLines += lines
        Next

        '総行数を入力
        txtAllCodeNum.Text = totalLines.ToString()

        '有効行数を取得
        totalLines = 0
        For Each file As String In Directory.GetFiles(folderPath, "*" & kakuchoshi, SearchOption.AllDirectories)
            Dim effectiveLines As Integer = 0

            ' 各行をチェック
            For Each line As String In System.IO.File.ReadAllLines(file)
                Dim trimmedLine As String = line.Trim()

                ' 空白行とコメント行をスキップ
                If Not String.IsNullOrEmpty(trimmedLine) AndAlso Not trimmedLine.StartsWith("'") Then
                    effectiveLines += 1
                End If
            Next

            totalLines += effectiveLines
        Next

        '有効行数を入力
        txtCodeNum.Text = totalLines.ToString()

    End Sub


End Class