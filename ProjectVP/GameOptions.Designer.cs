
namespace ProjectVP
{
    partial class GameOptions
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
            this.components = new System.ComponentModel.Container();
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.TextBox();
            this.pointsToWin = new System.Windows.Forms.Label();
            this.pointsWin = new System.Windows.Forms.NumericUpDown();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.player1Color = new System.Windows.Forms.Label();
            this.player2Color = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.ComboBox();
            this.color1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointsWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.player1Name.Location = new System.Drawing.Point(31, 51);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(84, 20);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "Player 1:";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.player2Name.Location = new System.Drawing.Point(31, 145);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(84, 20);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "Player 2:";
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(239, 49);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(263, 22);
            this.player1.TabIndex = 2;
            this.player1.Validating += new System.ComponentModel.CancelEventHandler(this.player1_Validating);
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(239, 143);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(263, 22);
            this.player2.TabIndex = 3;
            // 
            // pointsToWin
            // 
            this.pointsToWin.AutoSize = true;
            this.pointsToWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.pointsToWin.Location = new System.Drawing.Point(31, 245);
            this.pointsToWin.Name = "pointsToWin";
            this.pointsToWin.Size = new System.Drawing.Size(191, 20);
            this.pointsToWin.TabIndex = 4;
            this.pointsToWin.Text = "Points to win a game:";
            // 
            // pointsWin
            // 
            this.pointsWin.Location = new System.Drawing.Point(352, 245);
            this.pointsWin.Name = "pointsWin";
            this.pointsWin.Size = new System.Drawing.Size(150, 22);
            this.pointsWin.TabIndex = 6;
            this.pointsWin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(83, 378);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 50);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonPlay.Location = new System.Drawing.Point(284, 378);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(150, 50);
            this.buttonPlay.TabIndex = 10;
            this.buttonPlay.Text = "Play Game";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // player1Color
            // 
            this.player1Color.AutoSize = true;
            this.player1Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.player1Color.Location = new System.Drawing.Point(31, 100);
            this.player1Color.Name = "player1Color";
            this.player1Color.Size = new System.Drawing.Size(228, 20);
            this.player1Color.TabIndex = 11;
            this.player1Color.Text = "Choose color for player 1:";
            // 
            // player2Color
            // 
            this.player2Color.AutoSize = true;
            this.player2Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.player2Color.Location = new System.Drawing.Point(31, 192);
            this.player2Color.Name = "player2Color";
            this.player2Color.Size = new System.Drawing.Size(228, 20);
            this.player2Color.TabIndex = 12;
            this.player2Color.Text = "Choose color for player 2:";
            // 
            // color2
            // 
            this.color2.FormattingEnabled = true;
            this.color2.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Yellow",
            "Green",
            "Blue"});
            this.color2.Location = new System.Drawing.Point(352, 192);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(150, 24);
            this.color2.TabIndex = 13;
            this.color2.SelectedIndexChanged += new System.EventHandler(this.color2_SelectedIndexChanged);
            // 
            // color1
            // 
            this.color1.FormattingEnabled = true;
            this.color1.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Yellow",
            "Green",
            "Blue"});
            this.color1.Location = new System.Drawing.Point(352, 100);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(150, 24);
            this.color1.TabIndex = 14;
            this.color1.SelectedIndexChanged += new System.EventHandler(this.color1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter the board size (3-10)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 22;
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.player2Color);
            this.Controls.Add(this.player1Color);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pointsWin);
            this.Controls.Add(this.pointsToWin);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Name = "GameOptions";
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.pointsWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.Label pointsToWin;
        private System.Windows.Forms.NumericUpDown pointsWin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label player1Color;
        private System.Windows.Forms.Label player2Color;
        private System.Windows.Forms.ComboBox color2;
        private System.Windows.Forms.ComboBox color1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}