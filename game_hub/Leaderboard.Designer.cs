﻿namespace game_hub
{
    partial class Leaderboard
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
            this.first_place = new System.Windows.Forms.Label();
            this.third_place = new System.Windows.Forms.Label();
            this.second_place = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_place
            // 
            this.first_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.first_place.Location = new System.Drawing.Point(153, 22);
            this.first_place.Name = "first_place";
            this.first_place.Size = new System.Drawing.Size(151, 42);
            this.first_place.TabIndex = 0;
            this.first_place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // third_place
            // 
            this.third_place.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.third_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.third_place.Location = new System.Drawing.Point(301, 100);
            this.third_place.Name = "third_place";
            this.third_place.Size = new System.Drawing.Size(116, 39);
            this.third_place.TabIndex = 1;
            this.third_place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // second_place
            // 
            this.second_place.BackColor = System.Drawing.Color.Cyan;
            this.second_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.second_place.Location = new System.Drawing.Point(39, 100);
            this.second_place.Name = "second_place";
            this.second_place.Size = new System.Drawing.Size(116, 39);
            this.second_place.TabIndex = 2;
            this.second_place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 182);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zoradiť podľa hry1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zoradiť podľa hry2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Zoradiť podľa hry3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Zoradiť podľa hry4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "podla total";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(641, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "Exit to menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::game_hub.Properties.Resources.podium3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(301, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 75);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::game_hub.Properties.Resources.podium2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(38, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 75);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::game_hub.Properties.Resources.podium1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(154, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 150);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.second_place);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.third_place);
            this.Controls.Add(this.first_place);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label first_place;
        private System.Windows.Forms.Label third_place;
        private System.Windows.Forms.Label second_place;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}