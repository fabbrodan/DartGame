namespace DartGame
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
            this.playerName_label = new System.Windows.Forms.Label();
            this.playerName_tb = new System.Windows.Forms.TextBox();
            this.addPlayer_btn = new System.Windows.Forms.Button();
            this.playerList_label = new System.Windows.Forms.Label();
            this.startGame_btn = new System.Windows.Forms.Button();
            this.playerListView = new System.Windows.Forms.ListBox();
            this.playerPointsView = new System.Windows.Forms.ListBox();
            this.nextTurn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerName_label
            // 
            this.playerName_label.AutoSize = true;
            this.playerName_label.Location = new System.Drawing.Point(13, 13);
            this.playerName_label.Name = "playerName_label";
            this.playerName_label.Size = new System.Drawing.Size(38, 13);
            this.playerName_label.TabIndex = 0;
            this.playerName_label.Text = "Name:";
            // 
            // playerName_tb
            // 
            this.playerName_tb.Location = new System.Drawing.Point(16, 30);
            this.playerName_tb.Name = "playerName_tb";
            this.playerName_tb.Size = new System.Drawing.Size(122, 20);
            this.playerName_tb.TabIndex = 1;
            // 
            // addPlayer_btn
            // 
            this.addPlayer_btn.Location = new System.Drawing.Point(145, 26);
            this.addPlayer_btn.Name = "addPlayer_btn";
            this.addPlayer_btn.Size = new System.Drawing.Size(75, 23);
            this.addPlayer_btn.TabIndex = 2;
            this.addPlayer_btn.Text = "Add Player";
            this.addPlayer_btn.UseVisualStyleBackColor = true;
            this.addPlayer_btn.Click += new System.EventHandler(this.addPlayer_btn_Click);
            // 
            // playerList_label
            // 
            this.playerList_label.AutoSize = true;
            this.playerList_label.Location = new System.Drawing.Point(13, 58);
            this.playerList_label.Name = "playerList_label";
            this.playerList_label.Size = new System.Drawing.Size(44, 13);
            this.playerList_label.TabIndex = 4;
            this.playerList_label.Text = "Players:";
            // 
            // startGame_btn
            // 
            this.startGame_btn.Location = new System.Drawing.Point(16, 177);
            this.startGame_btn.Name = "startGame_btn";
            this.startGame_btn.Size = new System.Drawing.Size(75, 23);
            this.startGame_btn.TabIndex = 5;
            this.startGame_btn.Text = "Start Game!";
            this.startGame_btn.UseVisualStyleBackColor = true;
            this.startGame_btn.Click += new System.EventHandler(this.startGame_btn_Click);
            // 
            // playerListView
            // 
            this.playerListView.FormattingEnabled = true;
            this.playerListView.Location = new System.Drawing.Point(16, 74);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(120, 95);
            this.playerListView.TabIndex = 6;
            // 
            // playerPointsView
            // 
            this.playerPointsView.FormattingEnabled = true;
            this.playerPointsView.Location = new System.Drawing.Point(354, 74);
            this.playerPointsView.Name = "playerPointsView";
            this.playerPointsView.Size = new System.Drawing.Size(159, 95);
            this.playerPointsView.TabIndex = 7;
            // 
            // nextTurn_btn
            // 
            this.nextTurn_btn.Location = new System.Drawing.Point(354, 175);
            this.nextTurn_btn.Name = "nextTurn_btn";
            this.nextTurn_btn.Size = new System.Drawing.Size(75, 23);
            this.nextTurn_btn.TabIndex = 8;
            this.nextTurn_btn.Text = "Next Turn";
            this.nextTurn_btn.UseVisualStyleBackColor = true;
            this.nextTurn_btn.Click += new System.EventHandler(this.nextTurn_btn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 336);
            this.Controls.Add(this.nextTurn_btn);
            this.Controls.Add(this.playerPointsView);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.startGame_btn);
            this.Controls.Add(this.playerList_label);
            this.Controls.Add(this.addPlayer_btn);
            this.Controls.Add(this.playerName_tb);
            this.Controls.Add(this.playerName_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName_label;
        private System.Windows.Forms.TextBox playerName_tb;
        private System.Windows.Forms.Button addPlayer_btn;
        private System.Windows.Forms.Label playerList_label;
        private System.Windows.Forms.Button startGame_btn;
        private System.Windows.Forms.ListBox playerListView;
        private System.Windows.Forms.ListBox playerPointsView;
        private System.Windows.Forms.Button nextTurn_btn;
    }
}

