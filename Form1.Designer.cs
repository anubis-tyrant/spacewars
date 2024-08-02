namespace Spaceshootergame_dotnetassignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            alien = new PictureBox();
            ship = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            llb_score = new Label();
            lbl_over = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ship).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.player_img;
            player.Location = new Point(187, 359);
            player.Name = "player";
            player.Size = new Size(46, 45);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // alien
            // 
            alien.BackColor = Color.Transparent;
            alien.Image = Properties.Resources.alien_gif;
            alien.Location = new Point(49, 57);
            alien.Name = "alien";
            alien.Size = new Size(60, 60);
            alien.SizeMode = PictureBoxSizeMode.AutoSize;
            alien.TabIndex = 1;
            alien.TabStop = false;
            alien.Tag = "enemy";
            // 
            // ship
            // 
            ship.BackColor = Color.Transparent;
            ship.Image = Properties.Resources.ship_gif;
            ship.Location = new Point(362, 90);
            ship.Name = "ship";
            ship.Size = new Size(50, 27);
            ship.SizeMode = PictureBoxSizeMode.AutoSize;
            ship.TabIndex = 2;
            ship.TabStop = false;
            ship.Tag = "enemy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Stars_img;
            pictureBox1.Location = new Point(1, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "stars";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Stars_img;
            pictureBox2.Location = new Point(1, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(481, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "stars";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Stars_img;
            pictureBox3.Location = new Point(1, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(481, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "stars";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Stars_img;
            pictureBox4.Location = new Point(1, 321);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(481, 83);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "stars";
            // 
            // llb_score
            // 
            llb_score.AutoSize = true;
            llb_score.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llb_score.ForeColor = Color.FromArgb(128, 255, 255);
            llb_score.Location = new Point(1, 2);
            llb_score.Name = "llb_score";
            llb_score.Size = new Size(143, 33);
            llb_score.TabIndex = 7;
            llb_score.Text = "Score: 0";
            llb_score.Click += label1_Click;
            // 
            // lbl_over
            // 
            lbl_over.AutoSize = true;
            lbl_over.Font = new Font("Microsoft Uighur", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_over.ForeColor = Color.FromArgb(128, 255, 128);
            lbl_over.Location = new Point(120, 183);
            lbl_over.Name = "lbl_over";
            lbl_over.Size = new Size(237, 72);
            lbl_over.TabIndex = 8;
            lbl_over.Text = "Game Over";
            lbl_over.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(218, 7);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 9;
            label1.Text = "ADWIN-211211101006";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(482, 453);
            Controls.Add(label1);
            Controls.Add(llb_score);
            Controls.Add(ship);
            Controls.Add(alien);
            Controls.Add(player);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(lbl_over);
            ForeColor = Color.RosyBrown;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien).EndInit();
            ((System.ComponentModel.ISupportInitialize)ship).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private PictureBox alien;
        private PictureBox ship;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label llb_score;
        private Label lbl_over;
        private Label label1;
    }
}
