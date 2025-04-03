# AramGenerator

A simple Windows Forms application built with C# (.NET) to help organize custom League of Legends ARAM (All Random All Mid) games. It allows you to add players, shuffle them into two balanced teams, assign random champions, and manage rerolls.

![Screenshot Placeholder](https://i.imgur.com/BA0Oi5g.png)

## Features

*   **Add Players:** Easily add participants by name.
*   **Shuffle Teams:** Randomly assign players to two teams (Team 1 and Team 2).
*   **Randomize Champions:** Assign a unique random champion to every player initially.
*   **Reroll Champions:** Players can use their available rolls (default is 1) to get a different random champion.
*   **Reset Teams:** Clear team assignments, champion picks, and used rolls while keeping the player list intact.
*   **Clear All:** Reset the entire application by removing all players.
*   **(Debug Build Only):** Quickly add a list of test players.

## Requirements

*   **.NET Desktop Runtime:** Version X.Y or later (Check the project's target framework - e.g., .NET 6.0, .NET 7.0, or .NET Framework 4.X). You'll need the Desktop Runtime, not just the base runtime, because it uses Windows Forms.
*   **Windows Operating System:** As this is a Windows Forms application.

## Getting Started

### Building from Source

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/sagidev/AramGenerator.git
    cd AramGenerator
    ```
    *(<- Update the repository URL)*
2.  **Open the solution:** Open the `AramGenerator.sln` file in Visual Studio (2019 or later recommended, ensure the ".NET desktop development" workload is installed).
3.  **Build the solution:** Press `Ctrl+Shift+B` or go to `Build` > `Build Solution`.
4.  **Run the application:**
    *   Press `F5` to start debugging.
    *   Or, find the executable in the `bin\Debug\[Target Framework]` or `bin\Release\[Target Framework]` folder (e.g., `bin\Debug\net6.0-windows`).

## How to Use

1.  **Launch** the `AramGenerator` application.
2.  **Add Players:**
    *   Type a player's name into the text box under "Add Players".
    *   Click the "Add Player" button. The player will appear in the "Players" list.
    *   Repeat for all participants.
3.  **Shuffle Teams:**
    *   Once all players are added, click the "Shuffle Teams" button (the arrow button between the lists). Players will be randomly assigned to "Team 1" and "Team 2".
4.  **Randomize Champions:**
    *   Click the "Randomize Champs" button. Each player in both teams will be assigned a random champion and will have `[1]` roll available.
5.  **Reroll:**
    *   If a player wants to reroll, select their name in the "Team 1" or "Team 2" list.
    *   Click the "Reroll Selected" button below the corresponding team list.
    *   Their champion will change, and their roll count will decrease (e.g., `[0]`). A player cannot reroll if they have 0 rolls left.
6.  **Reset Teams:**
    *   Click "Reset Teams" to clear champion assignments, rolls, and team placements. The list of added players remains. You can then shuffle and randomize again.
7.  **Clear Players:**
    *   Click "Clear Players" to remove all added players and start completely fresh. You will be asked to confirm.

## Contributing

Contributions are welcome! If you have suggestions for improvements or find a bug, please feel free to:

*   Open an issue to discuss the change or report the bug.
*   Fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License.
