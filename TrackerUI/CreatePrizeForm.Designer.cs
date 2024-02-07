using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
     partial class CreatePrizeForm 
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
            createTeamLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.Location = new Point(26, 21);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(158, 37);
            createTeamLabel.TabIndex = 13;
            createTeamLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.ForeColor = SystemColors.MenuHighlight;
            placeNumberValue.Location = new Point(178, 70);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(210, 35);
            placeNumberValue.TabIndex = 15;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Location = new Point(28, 75);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(144, 30);
            placeNumberLabel.TabIndex = 14;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.ForeColor = SystemColors.MenuHighlight;
            placeNameValue.Location = new Point(178, 116);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(210, 35);
            placeNameValue.TabIndex = 17;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Location = new Point(28, 121);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(124, 30);
            placeNameLabel.TabIndex = 16;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.ForeColor = SystemColors.MenuHighlight;
            prizeAmountValue.Location = new Point(178, 162);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(210, 35);
            prizeAmountValue.TabIndex = 19;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Location = new Point(26, 167);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(139, 30);
            prizeAmountLabel.TabIndex = 18;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.ForeColor = SystemColors.MenuHighlight;
            prizePercentageValue.Location = new Point(178, 275);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(210, 35);
            prizePercentageValue.TabIndex = 21;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Location = new Point(12, 278);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(167, 30);
            prizePercentageLabel.TabIndex = 20;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Location = new Point(155, 223);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(48, 30);
            orLabel.TabIndex = 22;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(67, 377);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(281, 73);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(464, 500);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}