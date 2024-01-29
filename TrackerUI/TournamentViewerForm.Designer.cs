namespace TrackerUI
{
    partial class TournamentViewerForm
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
            tournamentLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOnelabel = new Label();
            teamTwoLabel = new Label();
            teamTneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentLabel.Location = new Point(21, 9);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(164, 37);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.Location = new Point(191, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(113, 37);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(21, 63);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(73, 30);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.ForeColor = SystemColors.MenuHighlight;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(97, 63);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(218, 38);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Location = new Point(139, 107);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(165, 34);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckbox.CheckedChanged += unplayedOnlyCheckbox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.ForeColor = SystemColors.MenuHighlight;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(21, 147);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(294, 274);
            matchupListBox.TabIndex = 5;
            // 
            // teamOnelabel
            // 
            teamOnelabel.AutoSize = true;
            teamOnelabel.Location = new Point(382, 147);
            teamOnelabel.Name = "teamOnelabel";
            teamOnelabel.Size = new Size(129, 30);
            teamOnelabel.TabIndex = 6;
            teamOnelabel.Text = "<team one>";
            teamOnelabel.Click += teamonelabel_Click;
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Location = new Point(382, 295);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(128, 30);
            teamTwoLabel.TabIndex = 7;
            teamTwoLabel.Text = "<team two>";
            teamTwoLabel.Click += teamTwoLabel_Click;
            // 
            // teamTneScoreLabel
            // 
            teamTneScoreLabel.AutoSize = true;
            teamTneScoreLabel.Location = new Point(366, 200);
            teamTneScoreLabel.Name = "teamTneScoreLabel";
            teamTneScoreLabel.Size = new Size(64, 30);
            teamTneScoreLabel.TabIndex = 8;
            teamTneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreValue.Location = new Point(436, 195);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 35);
            teamOneScoreValue.TabIndex = 9;
            teamOneScoreValue.TextChanged += textBox1_TextChanged;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreValue.Location = new Point(436, 345);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(100, 35);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(366, 350);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(64, 30);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Location = new Point(417, 245);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(53, 30);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.Location = new Point(577, 234);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(109, 53);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(768, 562);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamTneScoreLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOnelabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(tournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOnelabel;
        private Label teamTwoLabel;
        private Label teamTneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}