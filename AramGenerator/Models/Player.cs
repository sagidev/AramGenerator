using AramGenerator.Models;
using System;

namespace AramGenerator.Models
{
    /// <summary>
    /// Represents a player in the ARAM generator.
    /// </summary>
    public class Player
    {
        // Constants
        public const int NoTeam = -1;
        public const int DefaultRolls = 1; // Standard ARAM allows 1 or 2 rolls, let's default to 1

        // Properties
        public string Name { get; set; }
        public Champion Champion { get; set; }
        public int Team { get; set; } // Use constants like NoTeam, 1, 2
        public int Rolls { get; set; }

        public bool CanReroll => Rolls > 0;

        public Player(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player name cannot be empty.", nameof(name));
            }
            Name = name;
            Reset();
        }

        /// <summary>
        /// Resets player state to defaults (no champion, no team, default rolls).
        /// </summary>
        public void Reset()
        {
            Champion = Champion.None;
            Team = NoTeam;
            Rolls = DefaultRolls;
        }

        /// <summary>
        /// Returns a string representation for display purposes.
        /// </summary>
        public override string ToString()
        {
            string championName = Champion == Champion.None ? "---" : Champion.ToString();
            return $"{Name} - {championName} [{Rolls}]";
        }
    }
}