namespace TrackerUI
{
    partial class CreateTournamentForm
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
            createTournamentLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizesButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentLabel.Location = new Point(21, 29);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(242, 37);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.ForeColor = SystemColors.MenuHighlight;
            tournamentNameValue.Location = new Point(42, 118);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(305, 35);
            tournamentNameValue.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(42, 85);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(186, 30);
            tournamentNameLabel.TabIndex = 10;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.Click += tournamentNameLabel_Click;
            // 
            // entryFeeValue
            // 
            entryFeeValue.ForeColor = SystemColors.MenuHighlight;
            entryFeeValue.Location = new Point(146, 170);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(117, 35);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            entryFeeValue.TextAlign = HorizontalAlignment.Right;
            entryFeeValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(42, 175);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(98, 30);
            entryFeeLabel.TabIndex = 12;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.ForeColor = SystemColors.MenuHighlight;
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(55, 264);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(292, 38);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Location = new Point(42, 231);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(123, 30);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(233, 231);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 30);
            createNewTeamLink.TabIndex = 16;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.Location = new Point(90, 335);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(223, 40);
            addTeamButton.TabIndex = 17;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(90, 405);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(223, 40);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(409, 118);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(294, 154);
            tournamentPlayersListBox.TabIndex = 19;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Location = new Point(406, 76);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(156, 30);
            tournamentPlayersLabel.TabIndex = 20;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPlayerButton.Location = new Point(718, 153);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(109, 72);
            deleteSelectedPlayerButton.TabIndex = 21;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizesButton
            // 
            deleteSelectedPrizesButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizesButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizesButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPrizesButton.Location = new Point(718, 374);
            deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            deleteSelectedPrizesButton.Size = new Size(109, 71);
            deleteSelectedPrizesButton.TabIndex = 24;
            deleteSelectedPrizesButton.Text = "Delete Selected";
            deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Location = new Point(406, 293);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(156, 30);
            prizesLabel.TabIndex = 23;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.ForeColor = SystemColors.MenuHighlight;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(409, 335);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(294, 154);
            prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.Location = new Point(258, 524);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(281, 73);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 623);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizesButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizesButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}