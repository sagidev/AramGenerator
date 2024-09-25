using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AramGenerator
{
    

    public partial class Form1 : Form
    {
        List<Player> playerList = new List<Player>();
        List<Player> team1 = new List<Player>();
        List<Player> team2 = new List<Player>();
        List<Champion> rolledChampions = new List<Champion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(playernameTxt.Text == "")
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            string name = playernameTxt.Text;
            Player player = new Player();
            player.name = name;
            player.champion = Champion.None;
            player.team = -1;

            playerList.Add(player);
            playernameTxt.Text = "";
            playerListBox.Items.Add(player);
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            int playerCount = playerList.Count;
            int teamCount = playerCount /2;
            Random random = new Random();


            foreach(Player player in playerList)
            {
                if (player.team == -1)
                {
                    int team = random.Next(1, 3);
                    if (team == 1 && team1.Count < teamCount)
                    {
                        player.team = 1;
                        team1.Add(player);
                        Console.WriteLine(player.name + " - " + player.team);
                    }
                    else if (team == 2 && team2.Count < teamCount)
                    {
                        player.team = 2;
                        team2.Add(player);
                        Console.WriteLine(player.name + " - " + player.team);
                    }
                    else
                    {
                        if (team1.Count < teamCount)
                        {
                            player.team = 1;
                            team1.Add(player);
                            Console.WriteLine(player.name + " - " + player.team);
                        }
                        else
                        {
                            player.team = 2;
                            team2.Add(player);
                            Console.WriteLine(player.name + " - " + player.team);
                        }
                    }
                }
            }

            team1 = team1.OrderBy(x => random.Next()).ToList();
            team2 = team2.OrderBy(x => random.Next()).ToList();

            foreach (Player player in team1)
            {
                team1Box.Items.Add(player);
            }
            foreach (Player player in team2)
            {
                team2Box.Items.Add(player);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.name = "Test1";
            player.champion = Champion.None;
            player.team = -1;
            playerList.Add(player);
            playerListBox.Items.Add(player);

            Player player2 = new Player();
            player2.name = "Test2";
            player2.champion = Champion.None;
            player2.team = -1;
            playerList.Add(player2);
            playerListBox.Items.Add(player2);

            Player player3 = new Player();
            player3.name = "Test3";
            player3.champion = Champion.None;
            player3.team = -1;
            playerList.Add(player3);
            playerListBox.Items.Add(player3);

            Player player4 = new Player();
            player4.name = "Test4";
            player4.champion = Champion.None;
            player4.team = -1;
            playerList.Add(player4);
            playerListBox.Items.Add(player4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            team1Box.Items.Clear();
            team2Box.Items.Clear();
            team1.Clear();
            team2.Clear();

            foreach(Player player in playerList)
            {
                player.team = -1;
                player.rolls = 1;
                player.champion = Champion.None;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerListBox.Items.Clear();
            playerList.Clear();
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            playerListBox.Items.Clear();
            foreach (Player player in playerList)
            {
                do
                {
                    player.champion = player.getRandomChampion();
                } while (rolledChampions.Contains(player.champion));
                rolledChampions.Add(player.champion);
                playerListBox.Items.Add(player);
            }

            team1Box.Items.Clear();
            team2Box.Items.Clear();

            foreach (Player player in playerList)
            {
                if (player.team == 1)
                {
                    team1Box.Items.Add(player);
                }
                else if (player.team == 2)
                {
                    team2Box.Items.Add(player);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var index = team1Box.SelectedIndex;
            if (index != -1)
            {
                Player player = team1Box.SelectedItem as Player;
                player.champion = player.getRandomChampion();
                player.rolls--;
                team1Box.Items[index] = player;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var index = team2Box.SelectedIndex;
            if (index != -1)
            {
                Player player = team2Box.SelectedItem as Player;
                player.champion = player.getRandomChampion();
                player.rolls--;
                team2Box.Items[index] = player;
            }
        }
    }


    public class Player
    {
        private static readonly Random random = new Random();
        public string name { get; set; }
        public Champion champion { get; set; }
        public int team { get; set; }
        public int rolls { get; set; }

        public Player()
        {
            name = "";
            champion = Champion.None;
            team = -1;
            rolls = 1;
        }

        public override string ToString()
        {
            return name + " - " + champion + " [" + rolls + "]";
        }

        public Champion getRandomChampion()
        {
            Array values = Enum.GetValues(typeof(Champion));
            Champion randomChampion = (Champion)values.GetValue(random.Next(values.Length));
            do
            {
                randomChampion = (Champion)values.GetValue(random.Next(values.Length));
            } while (randomChampion == Champion.None);

            return randomChampion;
        }
    }

    public enum Champion
    {
        None,
        Aatrox,
        Ahri,
        Akali,
        Akshan,
        Alistar,
        Amumu,
        Anivia,
        Annie,
        Aphelios,
        Ashe,
        AurelionSol,
        Azir,
        Aurora,
        Hwei,
        Smolder,
        Bard,
        Belveth,
        Blitzcrank,
        Brand,
        Braum,
        Briar,
        Caitlyn,
        Camille,
        Cassiopeia,
        Chogath,
        Corki,
        Darius,
        Diana,
        DrMundo,
        Draven,
        Ekko,
        Elise,
        Evelynn,
        Ezreal,
        Fiddlesticks,
        Fiora,
        Fizz,
        Galio,
        Gangplank,
        Garen,
        Gnar,
        Gragas,
        Graves,
        Gwen,
        Hecarim,
        Heimerdinger,
        Illaoi,
        Irelia,
        Ivern,
        Janna,
        JarvanIV,
        Jax,
        Jayce,
        Jhin,
        Jinx,
        KSante,
        Kaisa,
        Kalista,
        Karma,
        Karthus,
        Kassadin,
        Katarina,
        Kayle,
        Kayn,
        Kennen,
        Khazix,
        Kindred,
        Kled,
        Kogmaw,
        Leblanc,
        LeeSin,
        Leona,
        Lillia,
        Lissandra,
        Lucian,
        Lulu,
        Lux,
        Malphite,
        Malzahar,
        Maokai,
        MasterYi,
        Milio,
        MissFortune,
        Mordekaiser,
        Morgana,
        Naafiri,
        Nami,
        Nasus,
        Nautilus,
        Neeko,
        Nidalee,
        Nilah,
        Nocturne,
        Nunu,
        Olaf,
        Orianna,
        Ornn,
        Pantheon,
        Poppy,
        Pyke,
        Qiyana,
        Quinn,
        Rakan,
        Rammus,
        RekSai,
        Rell,
        RenataGlasc,
        Renekton,
        Rengar,
        Riven,
        Rumble,
        Ryze,
        Samira,
        Sejuani,
        Senna,
        Seraphine,
        Sett,
        Shaco,
        Shen,
        Shyvana,
        Singed,
        Sion,
        Sivir,
        Skarner,
        Sona,
        Soraka,
        Swain,
        Sylas,
        Syndra,
        TahmKench,
        Taliyah,
        Talon,
        Taric,
        Teemo,
        Thresh,
        Tristana,
        Trundle,
        Tryndamere,
        TwistedFate,
        Twitch,
        Udyr,
        Urgot,
        Varus,
        Vayne,
        Veigar,
        Velkoz,
        Vex,
        Vi,
        Viego,
        Viktor,
        Vladimir,
        Volibear,
        Warwick,
        Wukong,
        Xayah,
        Xerath,
        XinZhao,
        Yasuo,
        Yone,
        Yorick,
        Yuumi,
        Zac,
        Zed,
        Zeri,
        Ziggs,
        Zilean,
        Zoe,
        Zyra
    }

}
