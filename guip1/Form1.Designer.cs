namespace guip1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.goodButton = new System.Windows.Forms.Button();
            this.badButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goodBox = new System.Windows.Forms.PictureBox();
            this.Badbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Badbox)).BeginInit();
            this.SuspendLayout();
            // 
            // goodButton
            // 
            this.goodButton.Location = new System.Drawing.Point(37, 415);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(75, 23);
            this.goodButton.TabIndex = 0;
            this.goodButton.Text = "Good";
            this.goodButton.UseVisualStyleBackColor = true;
            this.goodButton.Click += new System.EventHandler(this.goodButton_Click);
            // 
            // badButton
            // 
            this.badButton.Location = new System.Drawing.Point(628, 415);
            this.badButton.Name = "badButton";
            this.badButton.Size = new System.Drawing.Size(75, 23);
            this.badButton.TabIndex = 1;
            this.badButton.Text = "Bad";
            this.badButton.UseVisualStyleBackColor = true;
            this.badButton.Click += new System.EventHandler(this.badButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "What do you want to see:\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // goodBox
            // 
            this.goodBox.Image = ((System.Drawing.Image)(resources.GetObject("goodBox.Image")));
            this.goodBox.Location = new System.Drawing.Point(230, 48);
            this.goodBox.Name = "goodBox";
            this.goodBox.Size = new System.Drawing.Size(431, 361);
            this.goodBox.TabIndex = 3;
            this.goodBox.TabStop = false;
            this.goodBox.Visible = false;
            this.goodBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // Badbox
            // 
            this.Badbox.Image = ((System.Drawing.Image)(resources.GetObject("Badbox.Image")));
            this.Badbox.Location = new System.Drawing.Point(230, 48);
            this.Badbox.Name = "Badbox";
            this.Badbox.Size = new System.Drawing.Size(431, 361);
            this.Badbox.TabIndex = 4;
            this.Badbox.TabStop = false;
            this.Badbox.Visible = false;
            this.Badbox.Click += new System.EventHandler(this.Badbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Badbox);
            this.Controls.Add(this.goodBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.badButton);
            this.Controls.Add(this.goodButton);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Badbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goodButton;
        private System.Windows.Forms.Button badButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox goodBox;
        private System.Windows.Forms.PictureBox Badbox;
    }
}

