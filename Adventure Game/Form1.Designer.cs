namespace Adventure_Game
{
    partial class AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureGame));
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(467, 38);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(15, 266);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 23);
            this.option2Button.TabIndex = 3;
            this.option2Button.Text = "button2";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.option1Label.Location = new System.Drawing.Point(96, 226);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(383, 23);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "label1";
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.option2Label.Location = new System.Drawing.Point(96, 266);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(383, 23);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "label2";
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(15, 226);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 23);
            this.option1Button.TabIndex = 6;
            this.option1Button.Text = "button1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(491, 301);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Name = "AdventureGame";
            this.Text = "Racing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option1Button;
    }
}

