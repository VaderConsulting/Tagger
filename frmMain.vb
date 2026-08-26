Public Class frmMain
    Inherits System.Windows.Forms.Form
    Friend WithEvents mniFile As System.Windows.Forms.MenuItem
    Friend WithEvents mniFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tpScores As System.Windows.Forms.TabPage
    Friend WithEvents tpClocks As System.Windows.Forms.TabPage
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents btnStart1 As System.Windows.Forms.Button
    Friend WithEvents btnStop1 As System.Windows.Forms.Button
    Friend WithEvents btnReset1 As System.Windows.Forms.Button
    Friend WithEvents lblClock1 As System.Windows.Forms.Label
    Friend WithEvents lblClock2 As System.Windows.Forms.Label
    Friend WithEvents btnReset2 As System.Windows.Forms.Button
    Friend WithEvents btnStop2 As System.Windows.Forms.Button
    Friend WithEvents btnStart2 As System.Windows.Forms.Button
    Friend WithEvents btnAddScore1 As System.Windows.Forms.Button
    Friend WithEvents btnDelScore1 As System.Windows.Forms.Button
    Friend WithEvents btnAddScore2 As System.Windows.Forms.Button
    Friend WithEvents btnDelScore2 As System.Windows.Forms.Button
    Friend WithEvents txtScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTeamName4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore4 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore3 As System.Windows.Forms.TextBox
    Friend WithEvents btnDelScore4 As System.Windows.Forms.Button
    Friend WithEvents btnAddScore4 As System.Windows.Forms.Button
    Friend WithEvents btnDelScore3 As System.Windows.Forms.Button
    Friend WithEvents btnAddScore3 As System.Windows.Forms.Button
    Friend WithEvents txtTeamName6 As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamName5 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore6 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore5 As System.Windows.Forms.TextBox
    Friend WithEvents btnDelScore6 As System.Windows.Forms.Button
    Friend WithEvents btnAddScore6 As System.Windows.Forms.Button
    Friend WithEvents btnDelScore5 As System.Windows.Forms.Button
    Friend WithEvents btnAddScore5 As System.Windows.Forms.Button
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MainMenu
        Me.mniFile = New System.Windows.Forms.MenuItem
        Me.mniFileExit = New System.Windows.Forms.MenuItem
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.tpScores = New System.Windows.Forms.TabPage
        Me.tpClocks = New System.Windows.Forms.TabPage
        Me.tmrMain = New System.Windows.Forms.Timer
        Me.btnStart1 = New System.Windows.Forms.Button
        Me.btnStop1 = New System.Windows.Forms.Button
        Me.btnReset1 = New System.Windows.Forms.Button
        Me.lblClock1 = New System.Windows.Forms.Label
        Me.lblClock2 = New System.Windows.Forms.Label
        Me.btnReset2 = New System.Windows.Forms.Button
        Me.btnStop2 = New System.Windows.Forms.Button
        Me.btnStart2 = New System.Windows.Forms.Button
        Me.btnAddScore1 = New System.Windows.Forms.Button
        Me.btnDelScore1 = New System.Windows.Forms.Button
        Me.btnAddScore2 = New System.Windows.Forms.Button
        Me.btnDelScore2 = New System.Windows.Forms.Button
        Me.txtScore1 = New System.Windows.Forms.TextBox
        Me.txtScore2 = New System.Windows.Forms.TextBox
        Me.txtTeamName1 = New System.Windows.Forms.TextBox
        Me.txtTeamName2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTeamName4 = New System.Windows.Forms.TextBox
        Me.txtTeamName3 = New System.Windows.Forms.TextBox
        Me.txtScore4 = New System.Windows.Forms.TextBox
        Me.txtScore3 = New System.Windows.Forms.TextBox
        Me.btnDelScore4 = New System.Windows.Forms.Button
        Me.btnAddScore4 = New System.Windows.Forms.Button
        Me.btnDelScore3 = New System.Windows.Forms.Button
        Me.btnAddScore3 = New System.Windows.Forms.Button
        Me.txtTeamName6 = New System.Windows.Forms.TextBox
        Me.txtTeamName5 = New System.Windows.Forms.TextBox
        Me.txtScore6 = New System.Windows.Forms.TextBox
        Me.txtScore5 = New System.Windows.Forms.TextBox
        Me.btnDelScore6 = New System.Windows.Forms.Button
        Me.btnAddScore6 = New System.Windows.Forms.Button
        Me.btnDelScore5 = New System.Windows.Forms.Button
        Me.btnAddScore5 = New System.Windows.Forms.Button
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.Add(Me.mniFile)
        '
        'mniFile
        '
        Me.mniFile.MenuItems.Add(Me.mniFileExit)
        Me.mniFile.Text = "File"
        '
        'mniFileExit
        '
        Me.mniFileExit.Text = "Exit"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tpScores)
        Me.tabMain.Controls.Add(Me.tpClocks)
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(240, 256)
        '
        'tpScores
        '
        Me.tpScores.Controls.Add(Me.txtTeamName6)
        Me.tpScores.Controls.Add(Me.txtTeamName5)
        Me.tpScores.Controls.Add(Me.txtScore6)
        Me.tpScores.Controls.Add(Me.txtScore5)
        Me.tpScores.Controls.Add(Me.btnDelScore6)
        Me.tpScores.Controls.Add(Me.btnAddScore6)
        Me.tpScores.Controls.Add(Me.btnDelScore5)
        Me.tpScores.Controls.Add(Me.btnAddScore5)
        Me.tpScores.Controls.Add(Me.txtTeamName4)
        Me.tpScores.Controls.Add(Me.txtTeamName3)
        Me.tpScores.Controls.Add(Me.txtScore4)
        Me.tpScores.Controls.Add(Me.txtScore3)
        Me.tpScores.Controls.Add(Me.btnDelScore4)
        Me.tpScores.Controls.Add(Me.btnAddScore4)
        Me.tpScores.Controls.Add(Me.btnDelScore3)
        Me.tpScores.Controls.Add(Me.btnAddScore3)
        Me.tpScores.Controls.Add(Me.Label1)
        Me.tpScores.Controls.Add(Me.txtTeamName2)
        Me.tpScores.Controls.Add(Me.txtTeamName1)
        Me.tpScores.Controls.Add(Me.txtScore2)
        Me.tpScores.Controls.Add(Me.txtScore1)
        Me.tpScores.Controls.Add(Me.btnDelScore2)
        Me.tpScores.Controls.Add(Me.btnAddScore2)
        Me.tpScores.Controls.Add(Me.btnDelScore1)
        Me.tpScores.Controls.Add(Me.btnAddScore1)
        Me.tpScores.Location = New System.Drawing.Point(4, 4)
        Me.tpScores.Size = New System.Drawing.Size(232, 230)
        Me.tpScores.Text = "Scores"
        '
        'tpClocks
        '
        Me.tpClocks.Controls.Add(Me.lblClock2)
        Me.tpClocks.Controls.Add(Me.btnReset2)
        Me.tpClocks.Controls.Add(Me.btnStop2)
        Me.tpClocks.Controls.Add(Me.btnStart2)
        Me.tpClocks.Controls.Add(Me.lblClock1)
        Me.tpClocks.Controls.Add(Me.btnReset1)
        Me.tpClocks.Controls.Add(Me.btnStop1)
        Me.tpClocks.Controls.Add(Me.btnStart1)
        Me.tpClocks.Location = New System.Drawing.Point(4, 4)
        Me.tpClocks.Size = New System.Drawing.Size(232, 230)
        Me.tpClocks.Text = "Clocks"
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 1000
        '
        'btnStart1
        '
        Me.btnStart1.Location = New System.Drawing.Point(8, 8)
        Me.btnStart1.Size = New System.Drawing.Size(40, 24)
        Me.btnStart1.Text = "Start"
        '
        'btnStop1
        '
        Me.btnStop1.Location = New System.Drawing.Point(56, 8)
        Me.btnStop1.Size = New System.Drawing.Size(40, 24)
        Me.btnStop1.Text = "Stop"
        '
        'btnReset1
        '
        Me.btnReset1.Location = New System.Drawing.Point(104, 8)
        Me.btnReset1.Size = New System.Drawing.Size(48, 24)
        Me.btnReset1.Text = "Reset"
        '
        'lblClock1
        '
        Me.lblClock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblClock1.Location = New System.Drawing.Point(168, 8)
        Me.lblClock1.Size = New System.Drawing.Size(56, 24)
        Me.lblClock1.Text = "0:00"
        Me.lblClock1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClock2
        '
        Me.lblClock2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblClock2.Location = New System.Drawing.Point(168, 40)
        Me.lblClock2.Size = New System.Drawing.Size(56, 24)
        Me.lblClock2.Text = "0:00"
        Me.lblClock2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReset2
        '
        Me.btnReset2.Location = New System.Drawing.Point(104, 40)
        Me.btnReset2.Size = New System.Drawing.Size(48, 24)
        Me.btnReset2.Text = "Reset"
        '
        'btnStop2
        '
        Me.btnStop2.Location = New System.Drawing.Point(56, 40)
        Me.btnStop2.Size = New System.Drawing.Size(40, 24)
        Me.btnStop2.Text = "Stop"
        '
        'btnStart2
        '
        Me.btnStart2.Location = New System.Drawing.Point(8, 40)
        Me.btnStart2.Size = New System.Drawing.Size(40, 24)
        Me.btnStart2.Text = "Start"
        '
        'btnAddScore1
        '
        Me.btnAddScore1.Location = New System.Drawing.Point(128, 32)
        Me.btnAddScore1.Size = New System.Drawing.Size(24, 24)
        Me.btnAddScore1.Text = "+"
        '
        'btnDelScore1
        '
        Me.btnDelScore1.Location = New System.Drawing.Point(160, 32)
        Me.btnDelScore1.Size = New System.Drawing.Size(24, 24)
        Me.btnDelScore1.Text = "-"
        '
        'btnAddScore2
        '
        Me.btnAddScore2.Location = New System.Drawing.Point(128, 64)
        Me.btnAddScore2.Size = New System.Drawing.Size(24, 24)
        Me.btnAddScore2.Text = "+"
        '
        'btnDelScore2
        '
        Me.btnDelScore2.Location = New System.Drawing.Point(160, 64)
        Me.btnDelScore2.Size = New System.Drawing.Size(24, 24)
        Me.btnDelScore2.Text = "-"
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(192, 32)
        Me.txtScore1.Multiline = True
        Me.txtScore1.Size = New System.Drawing.Size(32, 24)
        Me.txtScore1.Text = "0"
        Me.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(192, 64)
        Me.txtScore2.Multiline = True
        Me.txtScore2.Size = New System.Drawing.Size(32, 24)
        Me.txtScore2.Text = "0"
        Me.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTeamName1
        '
        Me.txtTeamName1.Location = New System.Drawing.Point(8, 32)
        Me.txtTeamName1.Size = New System.Drawing.Size(112, 20)
        Me.txtTeamName1.Text = "Team 1"
        '
        'txtTeamName2
        '
        Me.txtTeamName2.Location = New System.Drawing.Point(8, 64)
        Me.txtTeamName2.Size = New System.Drawing.Size(112, 20)
        Me.txtTeamName2.Text = "Team 2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Size = New System.Drawing.Size(216, 16)
        Me.Label1.Text = "Scores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTeamName4
        '
        Me.txtTeamName4.Location = New System.Drawing.Point(8, 128)
        Me.txtTeamName4.Size = New System.Drawing.Size(112, 20)
        Me.txtTeamName4.Text = "Team 4"
        '
        'txtTeamName3
        '
        Me.txtTeamName3.Location = New System.Drawing.Point(8, 96)
        Me.txtTeamName3.Size = New System.Drawing.Size(112, 20)
        Me.txtTeamName3.Text = "Team 3"
        '
        'txtScore4
        '
        Me.txtScore4.Location = New System.Drawing.Point(192, 128)
        Me.txtScore4.Multiline = True
        Me.txtScore4.Size = New System.Drawing.Size(32, 24)
        Me.txtScore4.Text = "0"
        Me.txtScore4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(192, 96)
        Me.txtScore3.Multiline = True
        Me.txtScore3.Size = New System.Drawing.Size(32, 24)
        Me.txtScore3.Text = "0"
        Me.txtScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelScore4
        '
        Me.btnDelScore4.Location = New System.Drawing.Point(160, 128)
        Me.btnDelScore4.Size = New System.Drawing.Size(24, 24)
        Me.btnDelScore4.Text = "-"
        '
        'btnAddScore4
        '
        Me.btnAddScore4.Location = New System.Drawing.Point(128, 128)
        Me.btnAddScore4.Size = New System.Drawing.Size(24, 24)
        Me.btnAddScore4.Text = "+"
        '
        'btnDelScore3
        '
        Me.btnDelScore3.Location = New System.Drawing.Point(160, 96)
        Me.btnDelScore3.Size = New System.Drawing.Size(24, 24)
        Me.btnDelScore3.Text = "-"
        '
        'btnAddScore3
        '
        Me.btnAddScore3.Location = New System.Drawing.Point(128, 96)
        Me.btnAddScore3.Size = New System.Drawing.Size(24, 24)
        Me.btnAddScore3.Text = "+"
        '
        'txtTeamName6
        '
        Me.txtTeamName6.Location = New System.Drawing.Point(8, 192)
        Me.txtTeamName6.Size = New System.Drawing.Size(112, 20)
        Me.txtTeamName6.Text = "Team 6"
        '
        'txtTeamName5
        '
        Me.txtTeamName5.Location = New System.Drawing.Point(8, 160)
        Me.txtTeamName5.Size = New System.Drawing.Size(112, 20)
        Me.txtTeamName5.Text = "Team 5"
        '
        'txtScore6
        '
        Me.txtScore6.Location = New System.Drawing.Point(192, 192)
        Me.txtScore6.Multiline = True
        Me.txtScore6.Size = New System.Drawing.Size(32, 24)
        Me.txtScore6.Text = "0"
        Me.txtScore6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScore5
        '
        Me.txtScore5.Location = New System.Drawing.Point(192, 160)
        Me.txtScore5.Multiline = True
        Me.txtScore5.Size = New System.Drawing.Size(32, 24)
        Me.txtScore5.Text = "0"
        Me.txtScore5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelScore6
        '
        Me.btnDelScore6.Location = New System.Drawing.Point(160, 192)
        Me.btnDelScore6.Size = New System.Drawing.Size(24, 24)
        Me.btnDelScore6.Text = "-"
        '
        'btnAddScore6
        '
        Me.btnAddScore6.Location = New System.Drawing.Point(128, 192)
        Me.btnAddScore6.Size = New System.Drawing.Size(24, 24)
        Me.btnAddScore6.Text = "+"
        '
        'btnDelScore5
        '
        Me.btnDelScore5.Location = New System.Drawing.Point(160, 160)
        Me.btnDelScore5.Size = New System.Drawing.Size(24, 24)
        Me.btnDelScore5.Text = "-"
        '
        'btnAddScore5
        '
        Me.btnAddScore5.Location = New System.Drawing.Point(128, 160)
        Me.btnAddScore5.Size = New System.Drawing.Size(24, 24)
        Me.btnAddScore5.Text = "+"
        '
        'frmMain
        '
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mnuMain
        Me.Text = "Tagger"

    End Sub

#End Region

    Private Sub mniFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniFileExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAddScore1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore1.Click
        Me.txtScore1.Text = CInt(Me.txtScore1.Text) + 1
    End Sub

    Private Sub btnAddScore2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore2.Click
        Me.txtScore2.Text = CInt(Me.txtScore2.Text) + 1
    End Sub

    Private Sub btnAddScore3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore3.Click
        Me.txtScore3.Text = CInt(Me.txtScore3.Text) + 1
    End Sub

    Private Sub btnAddScore4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore4.Click
        Me.txtScore4.Text = CInt(Me.txtScore4.Text) + 1
    End Sub

    Private Sub btnAddScore5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore5.Click
        Me.txtScore5.Text = CInt(Me.txtScore5.Text) + 1
    End Sub

    Private Sub btnAddScore6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore6.Click
        Me.txtScore6.Text = CInt(Me.txtScore6.Text) + 1
    End Sub

    Private Sub btnDelScore1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScore1.Click
        Me.txtScore1.Text = CInt(Me.txtScore1.Text) - 1
    End Sub

    Private Sub btnDelScore2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScore2.Click
        Me.txtScore2.Text = CInt(Me.txtScore2.Text) - 1
    End Sub

    Private Sub btnDelScore3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScore3.Click
        Me.txtScore3.Text = CInt(Me.txtScore3.Text) - 1
    End Sub

    Private Sub btnDelScore4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScore4.Click
        Me.txtScore4.Text = CInt(Me.txtScore4.Text) - 1
    End Sub

    Private Sub btnDelScore5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScore5.Click
        Me.txtScore5.Text = CInt(Me.txtScore5.Text) - 1
    End Sub

    Private Sub btnDelScore6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScore6.Click
        Me.txtScore6.Text = CInt(Me.txtScore6.Text) - 1
    End Sub
End Class
