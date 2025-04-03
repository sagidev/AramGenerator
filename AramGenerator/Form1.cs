using AramGenerator.Models;
using AramGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AramGenerator
{
    public partial class Form1 : Form
    {
        private readonly List<Player> _playerList = new List<Player>();
        private readonly AramService _aramService = new AramService();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = playernameTxt.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a player name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playernameTxt.Focus();
                return;
            }

            if (_playerList.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Player '{name}' already exists.", "Duplicate Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                playernameTxt.Focus();
                return;
            }

            try
            {
                var newPlayer = new Player(name);
                _playerList.Add(newPlayer);
                playernameTxt.Clear();
                UpdatePlayerListBox();
                playernameTxt.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            if (_playerList.Count < 2)
            {
                MessageBox.Show("Need at least two players to shuffle teams.", "Not Enough Players", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _aramService.ShuffleTeams(_playerList);
            UpdateTeamListBoxes();
            UpdatePlayerListBox();
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            if (!_playerList.Any())
            {
                MessageBox.Show("Add players before assigning champions.", "No Players", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_playerList.Any(p => p.Team == Player.NoTeam))
            {
                MessageBox.Show("Shuffle teams before assigning champions.", "Teams Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _aramService.AssignInitialChampions(_playerList);
                UpdateAllListBoxes();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Randomization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rerollTeam1Btn_Click(object sender, EventArgs e)
        {
            RerollChampionForSelectedPlayer(team1Box);
        }

        private void rerollTeam2Btn_Click(object sender, EventArgs e)
        {
            RerollChampionForSelectedPlayer(team2Box);
        }

        private void resetTeamsBtn_Click(object sender, EventArgs e)
        {
            _aramService.ResetPlayers(_playerList);
            UpdateAllListBoxes();
        }

        private void clearPlayersBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear all players?",
                                     "Confirm Clear",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                _playerList.Clear();
                UpdateAllListBoxes();
            }
        }

        private void RerollChampionForSelectedPlayer(ListBox targetListBox)
        {
            if (targetListBox.SelectedItem is Player selectedPlayer)
            {
                if (!selectedPlayer.CanReroll)
                {
                    MessageBox.Show($"{selectedPlayer.Name} has no rerolls left.", "Cannot Reroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool success = _aramService.RerollChampion(selectedPlayer);

                if (success)
                {
                    int index = targetListBox.SelectedIndex;
                    targetListBox.Items[index] = selectedPlayer;
                    UpdatePlayerListBox();
                }
                else
                {
                    MessageBox.Show($"Failed to reroll champion for {selectedPlayer.Name}.", "Reroll Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a player from the team list to reroll.", "No Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UpdatePlayerListBox()
        {
            playerListBox.BeginUpdate(); // Prevent flicker
            playerListBox.Items.Clear();
            foreach (var player in _playerList.OrderBy(p => p.Name))
            {
                playerListBox.Items.Add(player);
            }
            playerListBox.EndUpdate(); // Allow drawing
        }

        private void UpdateTeamListBoxes()
        {
            team1Box.BeginUpdate();
            team2Box.BeginUpdate();

            team1Box.Items.Clear();
            team2Box.Items.Clear();

            foreach (var player in _playerList.OrderBy(p => p.Name)) // Or order as desired
            {
                if (player.Team == 1)
                {
                    team1Box.Items.Add(player);
                }
                else if (player.Team == 2)
                {
                    team2Box.Items.Add(player);
                }
            }

            team1Box.EndUpdate();
            team2Box.EndUpdate();
        }

        private void UpdateAllListBoxes()
        {
            UpdatePlayerListBox();
            UpdateTeamListBoxes();
        }

        // --- Optional: Test Data Button ---
        // Keep button1_Click logic but perhaps wrap it in #if DEBUG
#if DEBUG
        private void addTestDataBtn_Click(object sender, EventArgs e) // Renamed button1
        {
            if (_playerList.Any(p => p.Name.StartsWith("Test"))) return; // Add only once

            string[] testNames = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy" };
            foreach (var name in testNames)
            {
                if (!_playerList.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    _playerList.Add(new Player(name));
                }
            }
            UpdatePlayerListBox();
            MessageBox.Show($"{testNames.Length} test players added.", "Test Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
#endif

    }
}