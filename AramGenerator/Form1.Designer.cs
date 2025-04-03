namespace AramGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playernameTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.team1Box = new System.Windows.Forms.ListBox();
            this.team2Box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shuffleBtn = new System.Windows.Forms.Button();
            // --- Renamed buttons ---
            this.addTestDataBtn = new System.Windows.Forms.Button(); // Formerly button1
            this.resetTeamsBtn = new System.Windows.Forms.Button();  // Formerly button2
            this.clearPlayersBtn = new System.Windows.Forms.Button(); // Formerly button3
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.rerollTeam1Btn = new System.Windows.Forms.Button(); // Formerly button4
            this.rerollTeam2Btn = new System.Windows.Forms.Button(); // Formerly button5
            // --- End Renamed buttons ---
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // playernameTxt
            //
            this.playernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playernameTxt.Location = new System.Drawing.Point(38, 73);
            this.playernameTxt.Name = "playernameTxt";
            this.playernameTxt.Size = new System.Drawing.Size(190, 35);
            this.playernameTxt.TabIndex = 0;
            //
            // addBtn
            //
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.addBtn.Location = new System.Drawing.Point(235, 73);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Player";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            //
            // playerListBox
            //
            this.playerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.playerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 20;
            this.playerListBox.Location = new System.Drawing.Point(38, 243);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(272, 340);
            this.playerListBox.TabIndex = 2;
            //
            // team1Box
            //
            this.team1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.team1Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.team1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.team1Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.team1Box.FormattingEnabled = true;
            this.team1Box.ItemHeight = 20;
            this.team1Box.Location = new System.Drawing.Point(464, 243);
            this.team1Box.Name = "team1Box";
            this.team1Box.Size = new System.Drawing.Size(277, 340);
            this.team1Box.TabIndex = 3;
            //
            // team2Box
            //
            this.team2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.team2Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.team2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.team2Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.team2Box.FormattingEnabled = true;
            this.team2Box.ItemHeight = 20;
            this.team2Box.Location = new System.Drawing.Point(756, 243);
            this.team2Box.Name = "team2Box";
            this.team2Box.Size = new System.Drawing.Size(277, 340);
            this.team2Box.TabIndex = 4;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(459, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team 1";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(751, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team 2";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(33, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Players";
            //
            // shuffleBtn
            //
            this.shuffleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.shuffleBtn.FlatAppearance.BorderSize = 0;
            this.shuffleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shuffleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.shuffleBtn.Location = new System.Drawing.Point(316, 243);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(75, 35);
            this.shuffleBtn.TabIndex = 8;
            this.shuffleBtn.Text = "Shuffle Teams"; // Updated Text for clarity
            this.shuffleBtn.UseVisualStyleBackColor = false;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            //
            // addTestDataBtn
            //
            this.addTestDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.addTestDataBtn.FlatAppearance.BorderSize = 0;
            this.addTestDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTestDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTestDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTestDataBtn.Location = new System.Drawing.Point(316, 548);
            this.addTestDataBtn.Name = "addTestDataBtn"; // Renamed from button1
            this.addTestDataBtn.Size = new System.Drawing.Size(75, 35);
            this.addTestDataBtn.TabIndex = 9;
            this.addTestDataBtn.Text = "Add Test Data"; // Updated Text
            this.addTestDataBtn.UseVisualStyleBackColor = false;
#if DEBUG
            // Ensure the event handler wiring matches the method name in Form1.cs
            this.addTestDataBtn.Click += new System.EventHandler(this.addTestDataBtn_Click);
#endif
            //
            // resetTeamsBtn
            //
            this.resetTeamsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.resetTeamsBtn.FlatAppearance.BorderSize = 0;
            this.resetTeamsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTeamsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetTeamsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetTeamsBtn.Location = new System.Drawing.Point(316, 284);
            this.resetTeamsBtn.Name = "resetTeamsBtn"; // Renamed from button2
            this.resetTeamsBtn.Size = new System.Drawing.Size(75, 35);
            this.resetTeamsBtn.TabIndex = 10;
            this.resetTeamsBtn.Text = "Reset Teams"; // Updated Text
            this.resetTeamsBtn.UseVisualStyleBackColor = false;
            // Ensure the event handler wiring matches the method name in Form1.cs
            this.resetTeamsBtn.Click += new System.EventHandler(this.resetTeamsBtn_Click);
            //
            // clearPlayersBtn
            //
            this.clearPlayersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.clearPlayersBtn.FlatAppearance.BorderSize = 0;
            this.clearPlayersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPlayersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearPlayersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearPlayersBtn.Location = new System.Drawing.Point(316, 325);
            this.clearPlayersBtn.Name = "clearPlayersBtn"; // Renamed from button3
            this.clearPlayersBtn.Size = new System.Drawing.Size(75, 35);
            this.clearPlayersBtn.TabIndex = 11;
            this.clearPlayersBtn.Text = "Clear Players"; // Updated Text
            this.clearPlayersBtn.UseVisualStyleBackColor = false;
            // Ensure the event handler wiring matches the method name in Form1.cs
            this.clearPlayersBtn.Click += new System.EventHandler(this.clearPlayersBtn_Click);
            //
            // randomizeBtn
            //
            this.randomizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.randomizeBtn.FlatAppearance.BorderSize = 0;
            this.randomizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randomizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.randomizeBtn.Location = new System.Drawing.Point(316, 366);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(75, 49);
            this.randomizeBtn.TabIndex = 12;
            this.randomizeBtn.Text = "Randomize Champs"; // Updated Text
            this.randomizeBtn.UseVisualStyleBackColor = false;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            //
            // rerollTeam1Btn
            //
            this.rerollTeam1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rerollTeam1Btn.FlatAppearance.BorderSize = 0;
            this.rerollTeam1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rerollTeam1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rerollTeam1Btn.ForeColor = System.Drawing.Color.White;
            this.rerollTeam1Btn.Location = new System.Drawing.Point(464, 547);
            this.rerollTeam1Btn.Name = "rerollTeam1Btn"; // Renamed from button4
            this.rerollTeam1Btn.Size = new System.Drawing.Size(277, 36);
            this.rerollTeam1Btn.TabIndex = 13;
            this.rerollTeam1Btn.Text = "Reroll Selected (Team 1)"; // Updated Text
            this.rerollTeam1Btn.UseVisualStyleBackColor = false;
            // Ensure the event handler wiring matches the method name in Form1.cs
            this.rerollTeam1Btn.Click += new System.EventHandler(this.rerollTeam1Btn_Click);
            //
            // rerollTeam2Btn
            //
            this.rerollTeam2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rerollTeam2Btn.FlatAppearance.BorderSize = 0;
            this.rerollTeam2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rerollTeam2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rerollTeam2Btn.ForeColor = System.Drawing.Color.White;
            this.rerollTeam2Btn.Location = new System.Drawing.Point(756, 547);
            this.rerollTeam2Btn.Name = "rerollTeam2Btn"; // Renamed from button5
            this.rerollTeam2Btn.Size = new System.Drawing.Size(277, 36);
            this.rerollTeam2Btn.TabIndex = 14;
            this.rerollTeam2Btn.Text = "Reroll Selected (Team 2)"; // Updated Text
            this.rerollTeam2Btn.UseVisualStyleBackColor = false;
            // Ensure the event handler wiring matches the method name in Form1.cs
            this.rerollTeam2Btn.Click += new System.EventHandler(this.rerollTeam2Btn_Click);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(33, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add Players";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1065, 618);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rerollTeam2Btn);  // Use new name
            this.Controls.Add(this.rerollTeam1Btn);  // Use new name
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.clearPlayersBtn); // Use new name
            this.Controls.Add(this.resetTeamsBtn);   // Use new name
            this.Controls.Add(this.addTestDataBtn);  // Use new name
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.team2Box);
            this.Controls.Add(this.team1Box);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.playernameTxt);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Aram Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playernameTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ListBox team1Box;
        private System.Windows.Forms.ListBox team2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Button addTestDataBtn;
        private System.Windows.Forms.Button resetTeamsBtn;
        private System.Windows.Forms.Button clearPlayersBtn;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.Button rerollTeam1Btn;
        private System.Windows.Forms.Button rerollTeam2Btn;
        private System.Windows.Forms.Label label4;
    }
}