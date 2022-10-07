namespace UnoScorekeeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.enterPlayersTab = new System.Windows.Forms.TabPage();
            this.playButton = new System.Windows.Forms.Button();
            this.enterPlayerButton = new System.Windows.Forms.Button();
            this.enterPlayersTextbox = new System.Windows.Forms.TextBox();
            this.enterPlayersLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.playingGameTab = new System.Windows.Forms.TabPage();
            this.calculateTab = new System.Windows.Forms.TabPage();
            this.manualEntryTextBox = new System.Windows.Forms.TextBox();
            this.manualEntryButton = new System.Windows.Forms.Button();
            this.unoButton = new System.Windows.Forms.Button();
            this.buttonDraw4 = new System.Windows.Forms.Button();
            this.buttonWild = new System.Windows.Forms.Button();
            this.buttonDraw2 = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.enterScoreButton = new System.Windows.Forms.Button();
            this.playersListTab = new System.Windows.Forms.TabPage();
            this.nextGameButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.morePlayersButton = new System.Windows.Forms.Button();
            this.addCardsButton = new System.Windows.Forms.Button();
            this.playersListView = new System.Windows.Forms.ListView();
            this.podiumTab = new System.Windows.Forms.TabPage();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.enterPlayersTab.SuspendLayout();
            this.calculateTab.SuspendLayout();
            this.playersListTab.SuspendLayout();
            this.podiumTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.enterPlayersTab);
            this.tabControl1.Controls.Add(this.playingGameTab);
            this.tabControl1.Controls.Add(this.calculateTab);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 451);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // enterPlayersTab
            // 
            this.enterPlayersTab.Controls.Add(this.playButton);
            this.enterPlayersTab.Controls.Add(this.enterPlayerButton);
            this.enterPlayersTab.Controls.Add(this.enterPlayersTextbox);
            this.enterPlayersTab.Controls.Add(this.enterPlayersLabel);
            this.enterPlayersTab.Controls.Add(this.welcomeLabel);
            this.enterPlayersTab.Location = new System.Drawing.Point(4, 29);
            this.enterPlayersTab.Name = "enterPlayersTab";
            this.enterPlayersTab.Padding = new System.Windows.Forms.Padding(3);
            this.enterPlayersTab.Size = new System.Drawing.Size(790, 418);
            this.enterPlayersTab.TabIndex = 0;
            this.enterPlayersTab.Text = "Enter Players";
            this.enterPlayersTab.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(351, 267);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(94, 29);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // enterPlayerButton
            // 
            this.enterPlayerButton.Location = new System.Drawing.Point(417, 165);
            this.enterPlayerButton.Name = "enterPlayerButton";
            this.enterPlayerButton.Size = new System.Drawing.Size(94, 29);
            this.enterPlayerButton.TabIndex = 3;
            this.enterPlayerButton.Text = "Enter";
            this.enterPlayerButton.UseVisualStyleBackColor = true;
            this.enterPlayerButton.Click += new System.EventHandler(this.enterPlayerButton_Click);
            // 
            // enterPlayersTextbox
            // 
            this.enterPlayersTextbox.Location = new System.Drawing.Point(269, 166);
            this.enterPlayersTextbox.Name = "enterPlayersTextbox";
            this.enterPlayersTextbox.Size = new System.Drawing.Size(125, 27);
            this.enterPlayersTextbox.TabIndex = 2;
            this.enterPlayersTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterPlayersTextbox_KeyDown);
            // 
            // enterPlayersLabel
            // 
            this.enterPlayersLabel.AutoSize = true;
            this.enterPlayersLabel.Location = new System.Drawing.Point(349, 101);
            this.enterPlayersLabel.Name = "enterPlayersLabel";
            this.enterPlayersLabel.Size = new System.Drawing.Size(96, 20);
            this.enterPlayersLabel.TabIndex = 1;
            this.enterPlayersLabel.Text = "Enter Players:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(334, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(129, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to UNO!";
            // 
            // playingGameTab
            // 
            this.playingGameTab.Location = new System.Drawing.Point(4, 29);
            this.playingGameTab.Name = "playingGameTab";
            this.playingGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.playingGameTab.Size = new System.Drawing.Size(790, 418);
            this.playingGameTab.TabIndex = 1;
            this.playingGameTab.Text = "Playing Game";
            this.playingGameTab.UseVisualStyleBackColor = true;
            // 
            // calculateTab
            // 
            this.calculateTab.Controls.Add(this.manualEntryTextBox);
            this.calculateTab.Controls.Add(this.manualEntryButton);
            this.calculateTab.Controls.Add(this.unoButton);
            this.calculateTab.Controls.Add(this.buttonDraw4);
            this.calculateTab.Controls.Add(this.buttonWild);
            this.calculateTab.Controls.Add(this.buttonDraw2);
            this.calculateTab.Controls.Add(this.buttonReverse);
            this.calculateTab.Controls.Add(this.buttonSkip);
            this.calculateTab.Controls.Add(this.button0);
            this.calculateTab.Controls.Add(this.button9);
            this.calculateTab.Controls.Add(this.button8);
            this.calculateTab.Controls.Add(this.button7);
            this.calculateTab.Controls.Add(this.button6);
            this.calculateTab.Controls.Add(this.button5);
            this.calculateTab.Controls.Add(this.button4);
            this.calculateTab.Controls.Add(this.button3);
            this.calculateTab.Controls.Add(this.button2);
            this.calculateTab.Controls.Add(this.button1);
            this.calculateTab.Controls.Add(this.enterScoreButton);
            this.calculateTab.Location = new System.Drawing.Point(4, 29);
            this.calculateTab.Name = "calculateTab";
            this.calculateTab.Size = new System.Drawing.Size(790, 418);
            this.calculateTab.TabIndex = 2;
            this.calculateTab.Text = "Calculate Score";
            this.calculateTab.UseVisualStyleBackColor = true;
            // 
            // manualEntryTextBox
            // 
            this.manualEntryTextBox.Enabled = false;
            this.manualEntryTextBox.Location = new System.Drawing.Point(358, 352);
            this.manualEntryTextBox.Name = "manualEntryTextBox";
            this.manualEntryTextBox.Size = new System.Drawing.Size(184, 27);
            this.manualEntryTextBox.TabIndex = 18;
            this.manualEntryTextBox.Click += new System.EventHandler(this.manualEntryTextBox_Click);
            this.manualEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualEntryTextBox_KeyDown);
            // 
            // manualEntryButton
            // 
            this.manualEntryButton.Location = new System.Drawing.Point(248, 350);
            this.manualEntryButton.Name = "manualEntryButton";
            this.manualEntryButton.Size = new System.Drawing.Size(104, 29);
            this.manualEntryButton.TabIndex = 17;
            this.manualEntryButton.Text = "Manual Entry";
            this.manualEntryButton.UseVisualStyleBackColor = true;
            this.manualEntryButton.Click += new System.EventHandler(this.manualEntryButton_Click);
            // 
            // unoButton
            // 
            this.unoButton.Location = new System.Drawing.Point(248, 238);
            this.unoButton.Name = "unoButton";
            this.unoButton.Size = new System.Drawing.Size(294, 29);
            this.unoButton.TabIndex = 16;
            this.unoButton.Text = "UNO";
            this.unoButton.UseVisualStyleBackColor = true;
            this.unoButton.Click += new System.EventHandler(this.unoButton_Click);
            // 
            // buttonDraw4
            // 
            this.buttonDraw4.Location = new System.Drawing.Point(448, 203);
            this.buttonDraw4.Name = "buttonDraw4";
            this.buttonDraw4.Size = new System.Drawing.Size(94, 29);
            this.buttonDraw4.TabIndex = 15;
            this.buttonDraw4.Text = "Draw 4";
            this.buttonDraw4.UseVisualStyleBackColor = true;
            this.buttonDraw4.Click += new System.EventHandler(this.buttonDraw4_Click);
            // 
            // buttonWild
            // 
            this.buttonWild.Location = new System.Drawing.Point(348, 203);
            this.buttonWild.Name = "buttonWild";
            this.buttonWild.Size = new System.Drawing.Size(94, 29);
            this.buttonWild.TabIndex = 14;
            this.buttonWild.Text = "Wild";
            this.buttonWild.UseVisualStyleBackColor = true;
            this.buttonWild.Click += new System.EventHandler(this.buttonWild_Click);
            // 
            // buttonDraw2
            // 
            this.buttonDraw2.Location = new System.Drawing.Point(248, 203);
            this.buttonDraw2.Name = "buttonDraw2";
            this.buttonDraw2.Size = new System.Drawing.Size(94, 29);
            this.buttonDraw2.TabIndex = 13;
            this.buttonDraw2.Text = "Draw 2";
            this.buttonDraw2.UseVisualStyleBackColor = true;
            this.buttonDraw2.Click += new System.EventHandler(this.buttonDraw2_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(448, 168);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(94, 29);
            this.buttonReverse.TabIndex = 12;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(248, 168);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(94, 29);
            this.buttonSkip.TabIndex = 11;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(348, 168);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(94, 29);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(448, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 29);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(348, 133);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(248, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(448, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(348, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterScoreButton
            // 
            this.enterScoreButton.Location = new System.Drawing.Point(348, 288);
            this.enterScoreButton.Name = "enterScoreButton";
            this.enterScoreButton.Size = new System.Drawing.Size(94, 29);
            this.enterScoreButton.TabIndex = 0;
            this.enterScoreButton.Text = "Enter Score";
            this.enterScoreButton.UseVisualStyleBackColor = true;
            this.enterScoreButton.Click += new System.EventHandler(this.enterScoreButton_Click);
            this.enterScoreButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterScoreButton_KeyDown);
            this.enterScoreButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.enterScoreButton_KeyUp);
            // 
            // playersListTab
            // 
            this.playersListTab.Controls.Add(this.nextGameButton);
            this.playersListTab.Controls.Add(this.endGameButton);
            this.playersListTab.Controls.Add(this.morePlayersButton);
            this.playersListTab.Controls.Add(this.addCardsButton);
            this.playersListTab.Controls.Add(this.playersListView);
            this.playersListTab.Location = new System.Drawing.Point(4, 29);
            this.playersListTab.Name = "playersListTab";
            this.playersListTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersListTab.Size = new System.Drawing.Size(790, 418);
            this.playersListTab.TabIndex = 1;
            this.playersListTab.Text = "Players";
            this.playersListTab.UseVisualStyleBackColor = true;
            // 
            // nextGameButton
            // 
            this.nextGameButton.Location = new System.Drawing.Point(641, 303);
            this.nextGameButton.Name = "nextGameButton";
            this.nextGameButton.Size = new System.Drawing.Size(94, 55);
            this.nextGameButton.TabIndex = 3;
            this.nextGameButton.Text = "Play Next Game";
            this.nextGameButton.UseVisualStyleBackColor = true;
            this.nextGameButton.Click += new System.EventHandler(this.nextGameButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(641, 126);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(94, 51);
            this.endGameButton.TabIndex = 2;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // morePlayersButton
            // 
            this.morePlayersButton.Location = new System.Drawing.Point(641, 218);
            this.morePlayersButton.Name = "morePlayersButton";
            this.morePlayersButton.Size = new System.Drawing.Size(94, 49);
            this.morePlayersButton.TabIndex = 1;
            this.morePlayersButton.Text = "Add More Players";
            this.morePlayersButton.UseVisualStyleBackColor = true;
            this.morePlayersButton.Click += new System.EventHandler(this.morePlayersButton_Click);
            // 
            // addCardsButton
            // 
            this.addCardsButton.Enabled = false;
            this.addCardsButton.Location = new System.Drawing.Point(641, 33);
            this.addCardsButton.Name = "addCardsButton";
            this.addCardsButton.Size = new System.Drawing.Size(94, 58);
            this.addCardsButton.TabIndex = 0;
            this.addCardsButton.Text = "Calculate Score";
            this.addCardsButton.UseVisualStyleBackColor = true;
            this.addCardsButton.Click += new System.EventHandler(this.addCardsButton_Click);
            // 
            // playersListView
            // 
            this.playersListView.FullRowSelect = true;
            this.playersListView.Location = new System.Drawing.Point(24, 33);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(571, 325);
            this.playersListView.TabIndex = 0;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.playersListView_ItemSelectionChanged);
            // 
            // podiumTab
            // 
            this.podiumTab.Controls.Add(this.winnerLabel);
            this.podiumTab.Controls.Add(this.winLabel);
            this.podiumTab.Controls.Add(this.newGameButton);
            this.podiumTab.Location = new System.Drawing.Point(4, 29);
            this.podiumTab.Name = "podiumTab";
            this.podiumTab.Size = new System.Drawing.Size(790, 418);
            this.podiumTab.TabIndex = 2;
            this.podiumTab.Text = "Winner Podium";
            this.podiumTab.UseVisualStyleBackColor = true;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(366, 104);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(50, 20);
            this.winnerLabel.TabIndex = 2;
            this.winnerLabel.Text = "label1";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(357, 73);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(69, 20);
            this.winLabel.TabIndex = 1;
            this.winLabel.Text = "WINNER:";
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(4, 378);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(94, 29);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Uno Scorekeeper";
            this.tabControl1.ResumeLayout(false);
            this.enterPlayersTab.ResumeLayout(false);
            this.enterPlayersTab.PerformLayout();
            this.calculateTab.ResumeLayout(false);
            this.calculateTab.PerformLayout();
            this.playersListTab.ResumeLayout(false);
            this.podiumTab.ResumeLayout(false);
            this.podiumTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage enterPlayersTab;
        private TabPage playersListTab;
        private Button enterPlayerButton;
        private TextBox enterPlayersTextbox;
        private Label enterPlayersLabel;
        private Label welcomeLabel;
        private Button playButton;
        private ListView playersListView;
        private Button addCardsButton;
        private TabPage calculateTab;
        private Button morePlayersButton;
        private Button enterScoreButton;
        private Button buttonReverse;
        private Button buttonSkip;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonDraw4;
        private Button buttonWild;
        private Button buttonDraw2;
        private Button endGameButton;
        private TabPage podiumTab;
        private Button newGameButton;
        private Label winnerLabel;
        private Label winLabel;
        private Button unoButton;
        private TextBox manualEntryTextBox;
        private Button manualEntryButton;
        private Button nextGameButton;
        private TabPage playingGameTab;
    }
}