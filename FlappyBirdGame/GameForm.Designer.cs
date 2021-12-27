namespace FlappyBirdGame
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pipe1 = new System.Windows.Forms.PictureBox();
            this.Pipe2 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FinalScoreLabel = new System.Windows.Forms.Label();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GroundPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.panel1.SuspendLayout();
            this.GameOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1524, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(944, 677);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pipe1
            // 
            this.Pipe1.BackColor = System.Drawing.Color.Transparent;
            this.Pipe1.Image = ((System.Drawing.Image)(resources.GetObject("Pipe1.Image")));
            this.Pipe1.Location = new System.Drawing.Point(494, -38);
            this.Pipe1.Name = "Pipe1";
            this.Pipe1.Size = new System.Drawing.Size(97, 213);
            this.Pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe1.TabIndex = 1;
            this.Pipe1.TabStop = false;
            // 
            // Pipe2
            // 
            this.Pipe2.BackColor = System.Drawing.Color.Transparent;
            this.Pipe2.Image = ((System.Drawing.Image)(resources.GetObject("Pipe2.Image")));
            this.Pipe2.Location = new System.Drawing.Point(321, 278);
            this.Pipe2.Name = "Pipe2";
            this.Pipe2.Size = new System.Drawing.Size(86, 204);
            this.Pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe2.TabIndex = 2;
            this.Pipe2.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(92, 158);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(50, 38);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 3;
            this.Bird.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(71, 24);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score:";
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Transparent;
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-91, -26);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1024, 95);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 5;
            this.Ground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Ground);
            this.panel1.Location = new System.Drawing.Point(-1, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 72);
            this.panel1.TabIndex = 6;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverPanel.Controls.Add(this.panel4);
            this.GameOverPanel.Controls.Add(this.GroundPanel);
            this.GameOverPanel.Controls.Add(this.panel3);
            this.GameOverPanel.Controls.Add(this.PlayAgainButton);
            this.GameOverPanel.Controls.Add(this.FinalScoreLabel);
            this.GameOverPanel.Controls.Add(this.panel2);
            this.GameOverPanel.Controls.Add(this.pictureBox2);
            this.GameOverPanel.Controls.Add(this.label1);
            this.GameOverPanel.Controls.Add(this.CloseButton);
            this.GameOverPanel.Location = new System.Drawing.Point(-1, -2);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(684, 427);
            this.GameOverPanel.TabIndex = 7;
            this.GameOverPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(270, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(93, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 1);
            this.panel2.TabIndex = 2;
            // 
            // FinalScoreLabel
            // 
            this.FinalScoreLabel.AutoSize = true;
            this.FinalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreLabel.ForeColor = System.Drawing.Color.White;
            this.FinalScoreLabel.Location = new System.Drawing.Point(273, 238);
            this.FinalScoreLabel.Name = "FinalScoreLabel";
            this.FinalScoreLabel.Size = new System.Drawing.Size(126, 25);
            this.FinalScoreLabel.TabIndex = 3;
            this.FinalScoreLabel.Text = "Your Score:";
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.FlatAppearance.BorderSize = 0;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.White;
            this.PlayAgainButton.Location = new System.Drawing.Point(296, 310);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(138, 40);
            this.PlayAgainButton.TabIndex = 4;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(301, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 1);
            this.panel3.TabIndex = 5;
            // 
            // GroundPanel
            // 
            this.GroundPanel.Location = new System.Drawing.Point(3, 415);
            this.GroundPanel.Name = "GroundPanel";
            this.GroundPanel.Size = new System.Drawing.Size(830, 100);
            this.GroundPanel.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(648, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 1);
            this.panel4.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(637, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(44, 31);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 457);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Pipe2);
            this.Controls.Add(this.Pipe1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlappyBird";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsReleased);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pipe1;
        private System.Windows.Forms.PictureBox Pipe2;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label FinalScoreLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GroundPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button CloseButton;
    }
}

