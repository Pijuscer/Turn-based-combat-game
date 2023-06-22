
namespace Game3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HitButton = new System.Windows.Forms.Button();
            this.PierceButton = new System.Windows.Forms.Button();
            this.playerHealthBox = new System.Windows.Forms.ProgressBar();
            this.PotionsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinHealth1 = new System.Windows.Forms.Label();
            this.HealthMax1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinHealth2 = new System.Windows.Forms.Label();
            this.HealthMax2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enemyHealthBox = new System.Windows.Forms.ProgressBar();
            this.LevelBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game3.Properties.Resources.Enemy6;
            this.pictureBox1.Location = new System.Drawing.Point(795, 306);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Game3.Properties.Resources.Player3;
            this.pictureBox2.Location = new System.Drawing.Point(117, 300);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 311);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // HitButton
            // 
            this.HitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HitButton.Location = new System.Drawing.Point(56, 159);
            this.HitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(201, 55);
            this.HitButton.TabIndex = 2;
            this.HitButton.Text = "Attack Hit";
            this.HitButton.UseVisualStyleBackColor = false;
            this.HitButton.Click += new System.EventHandler(this.hitAttack);
            // 
            // PierceButton
            // 
            this.PierceButton.BackColor = System.Drawing.Color.SandyBrown;
            this.PierceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PierceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PierceButton.Location = new System.Drawing.Point(265, 159);
            this.PierceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PierceButton.Name = "PierceButton";
            this.PierceButton.Size = new System.Drawing.Size(197, 55);
            this.PierceButton.TabIndex = 3;
            this.PierceButton.Text = "Attack Pierce";
            this.PierceButton.UseVisualStyleBackColor = false;
            this.PierceButton.Click += new System.EventHandler(this.pierceAttack);
            // 
            // playerHealthBox
            // 
            this.playerHealthBox.BackColor = System.Drawing.SystemColors.Control;
            this.playerHealthBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.playerHealthBox.Location = new System.Drawing.Point(47, 46);
            this.playerHealthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerHealthBox.Name = "playerHealthBox";
            this.playerHealthBox.Size = new System.Drawing.Size(307, 28);
            this.playerHealthBox.TabIndex = 4;
            this.playerHealthBox.Value = 100;
            // 
            // PotionsButton
            // 
            this.PotionsButton.BackColor = System.Drawing.Color.SandyBrown;
            this.PotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PotionsButton.Location = new System.Drawing.Point(151, 234);
            this.PotionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PotionsButton.Name = "PotionsButton";
            this.PotionsButton.Size = new System.Drawing.Size(219, 55);
            this.PotionsButton.TabIndex = 5;
            this.PotionsButton.Text = "Potions Health";
            this.PotionsButton.UseVisualStyleBackColor = false;
            this.PotionsButton.Click += new System.EventHandler(this.PotionsHeal);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.MinHealth1);
            this.panel1.Controls.Add(this.HealthMax1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.playerHealthBox);
            this.panel1.Location = new System.Drawing.Point(56, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 116);
            this.panel1.TabIndex = 6;
            // 
            // MinHealth1
            // 
            this.MinHealth1.AutoSize = true;
            this.MinHealth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MinHealth1.ForeColor = System.Drawing.Color.Red;
            this.MinHealth1.Location = new System.Drawing.Point(41, 78);
            this.MinHealth1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinHealth1.Name = "MinHealth1";
            this.MinHealth1.Size = new System.Drawing.Size(48, 29);
            this.MinHealth1.TabIndex = 8;
            this.MinHealth1.Text = "0%";
            // 
            // HealthMax1
            // 
            this.HealthMax1.AutoSize = true;
            this.HealthMax1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HealthMax1.ForeColor = System.Drawing.Color.DarkGreen;
            this.HealthMax1.Location = new System.Drawing.Point(332, 78);
            this.HealthMax1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthMax1.Name = "HealthMax1";
            this.HealthMax1.Size = new System.Drawing.Size(74, 29);
            this.HealthMax1.TabIndex = 7;
            this.HealthMax1.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(296, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.MinHealth2);
            this.panel2.Controls.Add(this.HealthMax2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.enemyHealthBox);
            this.panel2.Location = new System.Drawing.Point(795, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 116);
            this.panel2.TabIndex = 10;
            // 
            // MinHealth2
            // 
            this.MinHealth2.AutoSize = true;
            this.MinHealth2.BackColor = System.Drawing.Color.Transparent;
            this.MinHealth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MinHealth2.ForeColor = System.Drawing.Color.Red;
            this.MinHealth2.Location = new System.Drawing.Point(51, 78);
            this.MinHealth2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinHealth2.Name = "MinHealth2";
            this.MinHealth2.Size = new System.Drawing.Size(48, 29);
            this.MinHealth2.TabIndex = 9;
            this.MinHealth2.Text = "0%";
            // 
            // HealthMax2
            // 
            this.HealthMax2.AutoSize = true;
            this.HealthMax2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HealthMax2.ForeColor = System.Drawing.Color.DarkGreen;
            this.HealthMax2.Location = new System.Drawing.Point(332, 78);
            this.HealthMax2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthMax2.Name = "HealthMax2";
            this.HealthMax2.Size = new System.Drawing.Size(74, 29);
            this.HealthMax2.TabIndex = 8;
            this.HealthMax2.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(296, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Health";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "Enemy";
            // 
            // enemyHealthBox
            // 
            this.enemyHealthBox.BackColor = System.Drawing.SystemColors.Control;
            this.enemyHealthBox.ForeColor = System.Drawing.Color.Red;
            this.enemyHealthBox.Location = new System.Drawing.Point(56, 46);
            this.enemyHealthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enemyHealthBox.Name = "enemyHealthBox";
            this.enemyHealthBox.Size = new System.Drawing.Size(300, 28);
            this.enemyHealthBox.TabIndex = 4;
            this.enemyHealthBox.Value = 100;
            // 
            // LevelBox
            // 
            this.LevelBox.AutoSize = true;
            this.LevelBox.BackColor = System.Drawing.Color.Transparent;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LevelBox.ForeColor = System.Drawing.Color.White;
            this.LevelBox.Location = new System.Drawing.Point(581, 39);
            this.LevelBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(114, 39);
            this.LevelBox.TabIndex = 12;
            this.LevelBox.Text = "Level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game3.Properties.Resources.Battle6;
            this.ClientSize = new System.Drawing.Size(1239, 624);
            this.Controls.Add(this.LevelBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PotionsButton);
            this.Controls.Add(this.PierceButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button PierceButton;
        private System.Windows.Forms.ProgressBar playerHealthBox;
        private System.Windows.Forms.Button PotionsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar enemyHealthBox;
        private System.Windows.Forms.Label LevelBox;
        private System.Windows.Forms.Label MinHealth1;
        private System.Windows.Forms.Label HealthMax1;
        private System.Windows.Forms.Label MinHealth2;
        private System.Windows.Forms.Label HealthMax2;
    }
}

