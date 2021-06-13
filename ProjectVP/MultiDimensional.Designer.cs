
namespace ProjectVP
{
    partial class MultiDimensional
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.whichTurn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.firstPlayer = new System.Windows.Forms.Label();
            this.secondPlayer = new System.Windows.Forms.Label();
            this.timerPlayer1 = new System.Windows.Forms.Timer(this.components);
            this.timerPlayer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pointsP1 = new System.Windows.Forms.Label();
            this.pointsP2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 389);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(487, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Turn:";
            // 
            // whichTurn
            // 
            this.whichTurn.AutoSize = true;
            this.whichTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Bold);
            this.whichTurn.Location = new System.Drawing.Point(650, 37);
            this.whichTurn.Name = "whichTurn";
            this.whichTurn.Size = new System.Drawing.Size(112, 39);
            this.whichTurn.TabIndex = 14;
            this.whichTurn.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(490, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Time left:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(494, 214);
            this.progressBar1.Maximum = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 23);
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Value = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(791, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Time left:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(795, 214);
            this.progressBar2.Maximum = 15;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(207, 23);
            this.progressBar2.TabIndex = 24;
            this.progressBar2.Value = 15;
            // 
            // firstPlayer
            // 
            this.firstPlayer.AutoSize = true;
            this.firstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.firstPlayer.Location = new System.Drawing.Point(490, 124);
            this.firstPlayer.Name = "firstPlayer";
            this.firstPlayer.Size = new System.Drawing.Size(67, 20);
            this.firstPlayer.TabIndex = 27;
            this.firstPlayer.Text = "Name1";
            // 
            // secondPlayer
            // 
            this.secondPlayer.AutoSize = true;
            this.secondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.secondPlayer.Location = new System.Drawing.Point(791, 124);
            this.secondPlayer.Name = "secondPlayer";
            this.secondPlayer.Size = new System.Drawing.Size(67, 20);
            this.secondPlayer.TabIndex = 28;
            this.secondPlayer.Text = "Name1";
            // 
            // timerPlayer1
            // 
            this.timerPlayer1.Interval = 1000;
            this.timerPlayer1.Tick += new System.EventHandler(this.timerPlayer1_Tick);
            // 
            // timerPlayer2
            // 
            this.timerPlayer2.Interval = 1000;
            this.timerPlayer2.Tick += new System.EventHandler(this.timerPlayer2_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLabel2,
            this.statusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 26);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(207, 20);
            this.statusLabel1.Text = "Points to win the game:";
            // 
            // statusLabel2
            // 
            this.statusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(132, 20);
            this.statusLabel2.Text = "Game number:";
            // 
            // statusLabel3
            // 
            this.statusLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.statusLabel3.Name = "statusLabel3";
            this.statusLabel3.Size = new System.Drawing.Size(51, 20);
            this.statusLabel3.Text = "Ties:";
            // 
            // pointsP1
            // 
            this.pointsP1.AutoSize = true;
            this.pointsP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.pointsP1.Location = new System.Drawing.Point(490, 275);
            this.pointsP1.Name = "pointsP1";
            this.pointsP1.Size = new System.Drawing.Size(84, 20);
            this.pointsP1.TabIndex = 30;
            this.pointsP1.Text = "Points: 0";
            // 
            // pointsP2
            // 
            this.pointsP2.AutoSize = true;
            this.pointsP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.pointsP2.Location = new System.Drawing.Point(791, 275);
            this.pointsP2.Name = "pointsP2";
            this.pointsP2.Size = new System.Drawing.Size(84, 20);
            this.pointsP2.TabIndex = 31;
            this.pointsP2.Text = "Points: 0";
            // 
            // MultiDimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 463);
            this.Controls.Add(this.pointsP2);
            this.Controls.Add(this.pointsP1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.secondPlayer);
            this.Controls.Add(this.firstPlayer);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.whichTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MultiDimensional";
            this.Text = "MultiDimensional";
            this.Load += new System.EventHandler(this.MultiDimensional_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label whichTurn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label firstPlayer;
        private System.Windows.Forms.Label secondPlayer;
        private System.Windows.Forms.Timer timerPlayer1;
        private System.Windows.Forms.Timer timerPlayer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel3;
        private System.Windows.Forms.Label pointsP1;
        private System.Windows.Forms.Label pointsP2;
    }
}