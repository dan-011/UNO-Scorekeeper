using System.Media;
using System.Numerics;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.ListViewItem;

namespace UnoScorekeeper
{
    public partial class Form1 : Form
    {
        #region Construction
        public Form1()
        {
            InitializeComponent();
            InitializeColumnHeaders();
            RefreshEnabledStates();
        }
        #endregion Construction

        #region Initialize Events
        private void InitializeColumnHeaders()
        {
            playersListView.View = View.Details;
            ColumnHeader rankHeader = new ColumnHeader();
            rankHeader.Name = "rankHeader";
            rankHeader.Text = "Rank";
            rankHeader.Width = 100;
            ColumnHeader nameHeader = new ColumnHeader();
            nameHeader.Name = "nameHeader";
            nameHeader.Text = "Name";
            nameHeader.Width = 100;
            ColumnHeader scoreHeader = new ColumnHeader();
            scoreHeader.Name = "scoreHeader";
            scoreHeader.Text = "Score";
            scoreHeader.Width = 100;
            playersListView.Columns.Add(rankHeader);
            playersListView.Columns.Add(nameHeader);
            playersListView.Columns.Add(scoreHeader);
        }
        #endregion Initialize Events

        #region Private Methods
        private void SwitchTabs(TabPage currentTab, TabPage nextTab)
        {
            tabControl1.Controls.Add(nextTab);
            tabControl1.Controls.Remove(currentTab);
            tabControl1.SelectedTab = nextTab;
        }

        private void RefreshEnabledStates()
        {
            addCardsButton.Enabled = playersListView.SelectedItems.Count > 0;
            endGameButton.Enabled = !BeforeGame;
            playButton.Enabled = PlayerScores.Count > 1;
        }
        #endregion Private Methods

        #region Event Handlers
        private void enterPlayerButton_Click(object sender, EventArgs e)
        {
            string playerName = enterPlayersTextbox.Text;
            if(playerName.Length != 0)
            {
                if (!PlayerScores.ContainsKey(playerName))
                {
                    PlayerScores.Add(playerName, 0);
                    enterPlayersTextbox.Clear();
                    RefreshEnabledStates();
                }
                else
                {
                    MessageBox.Show("This player is already in the game!");
                }
            }
            enterPlayersTextbox.Focus();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SwitchTabs(enterPlayersTab, playersListTab);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == playersListTab)
            {
                CurrentPlayer = "";
                TotaledScores = 0;
                playersListView.Items.Clear();
                ListViewItem item;
                //bool unoPlayerSet = false;
                int scoreZeroCount = 0;
                List<Tuple<string, int>> scoreOrder = new List<Tuple<string, int>>();
                foreach (var player in PlayerScores)
                {
                    string name = player.Key;
                    int score = player.Value;
                    if (score == 0)
                    {
                        scoreZeroCount++;
                    }
                    int i = 0;
                    if (!name.Equals(UnoPlayer))
                    {
                        while (scoreOrder.Count > i && scoreOrder[i].Item2 < score) // pauh uno player to the front
                        {
                            i++;
                        }
                        scoreOrder.Insert(i, new Tuple<string, int>(name, score));
                    }
                }
                if(scoreOrder.Count != PlayerScores.Count)
                {
                    scoreOrder.Insert(0, new Tuple<string, int>(UnoPlayer, PlayerScores[UnoPlayer]));
                    //unoPlayerSet = true;
                }
                BeforeGame = scoreZeroCount > 1;
                for (int i = 0; i < scoreOrder.Count; i++)
                {
                    string rank = BeforeGame ? "N/A" : (i + 1).ToString();
                    string name = scoreOrder[i].Item1;
                    string score = scoreOrder[i].Item2 == 0 && BeforeGame && !name.Equals(UnoPlayer) && !ZeroPlayers.Contains(name) ? "-" : scoreOrder[i].Item2.ToString();
                    string[] playerArray = { rank, name, score };
                    item = new ListViewItem(playerArray);
                    playersListView.Items.Add(item);
                }
                RefreshEnabledStates();
            }
            else if (tabControl1.SelectedTab == enterPlayersTab)
            {
                RefreshEnabledStates();
            }
            else if (tabControl1.SelectedTab == podiumTab)
            {
                string winner = "";
                int winScore = int.MaxValue;
                foreach(var player in PlayerScores)
                {
                    if(player.Value < winScore)
                    {
                        winner = player.Key;
                    }
                }
                winnerLabel.Text = winner;
            }
            else if(tabControl1.SelectedTab == calculateTab)
            {
                unoButton.Enabled = true;
                enterScoreButton.Focus();
            }
        }

        private void addCardsButton_Click(object sender, EventArgs e)
        {
            SwitchTabs(playersListTab, calculateTab);
        }

        private void morePlayersButton_Click(object sender, EventArgs e)
        {
            SwitchTabs(playersListTab, enterPlayersTab);
        }
        private void enterScoreButton_Click(object sender, EventArgs e)
        {
            PlayerScores[CurrentPlayer] += TotaledScores;
            SwitchTabs(calculateTab, playersListTab);
        }

        private void playersListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection collection = playersListView.SelectedItems;
            if (collection.Count > 0)
            {
                ListViewItem item = collection[0];
                ListViewSubItemCollection subitems = item.SubItems;
                ListViewSubItem nameSubitem = subitems[1];
                string name = nameSubitem.Text;
                CurrentPlayer = name;
            }
            else
            {
                CurrentPlayer = "";
            }
            RefreshEnabledStates();
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            SwitchTabs(playersListTab, podiumTab);
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            PlayerScores.Clear();
            BeforeGame = false;
            CurrentPlayer = "";
            SwitchTabs(podiumTab, enterPlayersTab);
        }

        private void enterPlayersTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                enterPlayerButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        // S - skip
        // W - wild
        // R - reverse
        // shift 2 - draw 2
        // shift 4 - draw 4
        private void enterScoreButton_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                MessageBox.Show("KeyDown " + e.KeyValue);
            }
        }

        private void manualEntryButton_Click(object sender, EventArgs e)
        {
            TotaledScores = 0;

            manualEntryTextBox.Enabled = !manualEntryTextBox.Enabled;
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
            button3.Enabled = !button3.Enabled;
            button4.Enabled = !button4.Enabled;
            button5.Enabled = !button5.Enabled;
            button6.Enabled = !button6.Enabled;
            button7.Enabled = !button7.Enabled;
            button8.Enabled = !button8.Enabled;
            button9.Enabled = !button9.Enabled;
            button0.Enabled = !button0.Enabled;
            buttonSkip.Enabled = !buttonSkip.Enabled;
            buttonReverse.Enabled = !buttonReverse.Enabled;
            buttonDraw2.Enabled = !buttonDraw2.Enabled;
            buttonWild.Enabled = !buttonWild.Enabled;
            buttonDraw4.Enabled = !buttonDraw4.Enabled;
            unoButton.Enabled = true;

            manualEntryTextBox.Text = "Type Score";
        }

        private void manualEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if "UNO" run uno button event
            if (e.KeyCode == Keys.Enter)
            {
                if (manualEntryTextBox.Text.ToLower().Trim() == "uno")
                {
                    unoButton_Click(sender, e);
                }
                else
                {
                    try
                    {
                        string trimmed = manualEntryTextBox.Text.Trim();
                        int score = Int32.Parse(trimmed);
                        TotaledScores = score;
                        enterScoreButton_Click(sender, (EventArgs)e);
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a number or " + (char)34 + "UNO" + (char)34 + ".");
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void manualEntryTextBox_Click(object sender, EventArgs e)
        {
            manualEntryTextBox.Clear();
        }
        #region Keypad
        private void button1_Click(object sender, EventArgs e)
        {
            TotaledScores += 1;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TotaledScores += 2;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotaledScores += 3;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TotaledScores += 4;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TotaledScores += 5;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TotaledScores += 6;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TotaledScores += 7;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TotaledScores += 8;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TotaledScores += 9;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TotaledScores += 0;
            unoButton.Enabled = false;
            ZeroPlayers.Add(CurrentPlayer);
            enterScoreButton.Focus();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            TotaledScores += 20;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            TotaledScores += 20;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void buttonDraw2_Click(object sender, EventArgs e)
        {
            TotaledScores += 20;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }

        private void buttonWild_Click(object sender, EventArgs e)
        {
            TotaledScores += 50;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }
        private void buttonDraw4_Click(object sender, EventArgs e)
        {
            TotaledScores += 50;
            unoButton.Enabled = false;
            enterScoreButton.Focus();
        }



        private void unoButton_Click(object sender, EventArgs e)
        {
            // show confetti animation, wait 3 seconds switch back tabs
            //Thread.Sleep(TimeSpan.FromMilliseconds(3000));
            //calculateTab.Controls.Add(this.congratsPictureBox);
            //congratsPictureBox.Visible = true;
            TotaledScores = 0;
            UnoPlayer = CurrentPlayer;
            Thread.Sleep(2000);
            SwitchTabs(calculateTab, playersListTab);
            //calculateTab.Controls.Remove(this.congratsPictureBox);
            //congratsPictureBox.Visible = false;
        }
        #endregion Keypad
        private void nextGameButton_Click(object sender, EventArgs e)
        {
            // ZeroPlayers.Clear(); do this after you switch back
        }

        #endregion Event Handlers
        #region Private Properties
        private Dictionary<string, int> PlayerScores
        {
            get
            {
                if(_playerScores == null)
                {
                    _playerScores = new Dictionary<string, int>();
                }
                return _playerScores;
            }
            set
            {
                _playerScores = value;
            }
        }
        /*private Tuple<string, int> CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
            set
            {
                _currentPlayer = value;
            }
        }*/
        private string CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
            set
            {
                _currentPlayer = value;
            }
        }

        private bool BeforeGame
        {
            get
            {
                return _beforeGame;
            }
            set
            {
                _beforeGame = value;
            }
        }

        private int TotaledScores
        {
            get
            {
                return _totaledScores;
            }
            set
            {
                _totaledScores = value;
            }
        }

        private string UnoPlayer
        {
            get
            {
                return _unoPlayer;
            }
            set
            {
                _unoPlayer = value;
            }
        }

        private HashSet<string> ZeroPlayers
        {
            get
            {
                return _zeroPlayers;
            }
            set
            {
                _zeroPlayers = value;
            }
        }
        #endregion Private Properties

        #region Private Fields
        private Dictionary<string, int> _playerScores = new Dictionary<string, int>();
        private List<Tuple<string, int>> _orderedPlayers = new List<Tuple<string, int>>();
        private bool _beforeGame = true;
        private int _totaledScores = 0;
        //private Tuple<string, int> _currentPlayer = new Tuple<string, int>("", -1);
        private string _currentPlayer = "";
        private string _unoPlayer = "";
        private HashSet<string> _zeroPlayers = new HashSet<string>();

        #endregion Private Fields

        private void enterScoreButton_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}