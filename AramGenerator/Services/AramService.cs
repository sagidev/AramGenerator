using AramGenerator.Models; // <--- Add this line
using System;
using System.Collections.Generic;
using System.Linq;

namespace AramGenerator.Services
{
    /// <summary>
    /// Provides services for managing players, teams, and champion assignments.
    /// </summary>
    public class AramService
    {
        private static readonly Random _random = new Random();
        private List<Champion> _availableChampions;

        public AramService()
        {
            // Cache the list of valid champions (excluding None)
            _availableChampions = Enum.GetValues(typeof(Champion))
                                      .Cast<Champion>()
                                      .Where(c => c != Champion.None)
                                      .ToList();
        }

        /// <summary>
        /// Shuffles the list of players and assigns them to two teams as evenly as possible.
        /// </summary>
        /// <param name="players">The list of players to shuffle and assign teams.</param>
        public void ShuffleTeams(List<Player> players)
        {
            if (players == null || players.Count < 2) return;

            // Reset teams before shuffling
            foreach (var player in players)
            {
                player.Team = Player.NoTeam;
            }

            // Fisher-Yates shuffle
            int n = players.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                Player value = players[k];
                players[k] = players[n];
                players[n] = value;
            }

            // Assign teams
            int teamSize = players.Count / 2;
            for (int i = 0; i < players.Count; i++)
            {
                players[i].Team = (i < teamSize) ? 1 : 2;
            }
        }

        /// <summary>
        /// Assigns a unique random champion to each player in the list.
        /// </summary>
        /// <param name="players">The list of players to assign champions to.</param>
        public void AssignInitialChampions(List<Player> players)
        {
            if (players == null || !players.Any()) return;

            if (players.Count > _availableChampions.Count)
            {
                throw new InvalidOperationException("Not enough unique champions for all players.");
            }

            var shuffledChampions = _availableChampions.OrderBy(c => _random.Next()).ToList();

            for (int i = 0; i < players.Count; i++)
            {
                players[i].Champion = shuffledChampions[i];
            }
        }

        /// <summary>
        /// Attempts to reroll the champion for a specific player.
        /// </summary>
        /// <param name="player">The player requesting a reroll.</param>
        /// <param name="currentlyAssignedChampions">A collection of champions currently assigned to other players (to potentially avoid direct duplicates if desired, though standard ARAM allows this).</param>
        /// <returns>True if the reroll was successful, false otherwise (e.g., no rolls left).</returns>
        public bool RerollChampion(Player player, IEnumerable<Champion> currentlyAssignedChampions = null)
        {
            if (player == null || !player.CanReroll)
            {
                return false; // Cannot reroll
            }

            Champion oldChampion = player.Champion;
            Champion newChampion;
            do
            {
                newChampion = GetRandomChampion();
            } while (newChampion == oldChampion);

            player.Champion = newChampion;
            player.Rolls--;

            return true;
        }

        /// <summary>
        /// Resets the state (Team, Champion, Rolls) for all players in the list.
        /// </summary>
        /// <param name="players">The list of players to reset.</param>
        public void ResetPlayers(List<Player> players)
        {
            if (players == null) return;
            foreach (var player in players)
            {
                player.Reset();
            }
        }

        /// <summary>
        /// Gets a single random champion (excluding None).
        /// </summary>
        /// <returns>A random champion.</returns>
        private Champion GetRandomChampion()
        {
            int randomIndex = _random.Next(_availableChampions.Count);
            return _availableChampions[randomIndex];
        }
    }
}