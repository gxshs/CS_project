namespace CS_app
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStrengthText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarStrength = new System.Windows.Forms.ProgressBar();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxRecommendations = new System.Windows.Forms.ListBox();
            this.buttonTogglePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проверка надежности пароля";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(192, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelStrengthText
            // 
            this.labelStrengthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStrengthText.Location = new System.Drawing.Point(1202, 202);
            this.labelStrengthText.Name = "labelStrengthText";
            this.labelStrengthText.Size = new System.Drawing.Size(281, 37);
            this.labelStrengthText.TabIndex = 2;
            this.labelStrengthText.Text = "Надежность:";
            this.labelStrengthText.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1187, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рекомендации:";
            // 
            // progressBarStrength
            // 
            this.progressBarStrength.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarStrength.Location = new System.Drawing.Point(960, 264);
            this.progressBarStrength.Name = "progressBarStrength";
            this.progressBarStrength.Size = new System.Drawing.Size(671, 46);
            this.progressBarStrength.TabIndex = 5;
            this.progressBarStrength.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(367, 29);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonCheck.Location = new System.Drawing.Point(3, 3);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(408, 82);
            this.buttonCheck.TabIndex = 7;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(113, 261);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(374, 35);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.buttonCheck);
            this.panel2.Location = new System.Drawing.Point(117, 442);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(413, 87);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(-251, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2178, 5);
            this.label6.TabIndex = 8;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // listBoxRecommendations
            // 
            this.listBoxRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRecommendations.FormattingEnabled = true;
            this.listBoxRecommendations.ItemHeight = 25;
            this.listBoxRecommendations.Location = new System.Drawing.Point(960, 444);
            this.listBoxRecommendations.Name = "listBoxRecommendations";
            this.listBoxRecommendations.Size = new System.Drawing.Size(671, 329);
            this.listBoxRecommendations.TabIndex = 10;
            this.listBoxRecommendations.SelectedIndexChanged += new System.EventHandler(this.listBoxRecommendations_SelectedIndexChanged);
            // 
            // buttonTogglePassword
            // 
            this.buttonTogglePassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTogglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTogglePassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonTogglePassword.Location = new System.Drawing.Point(493, 254);
            this.buttonTogglePassword.Name = "buttonTogglePassword";
            this.buttonTogglePassword.Size = new System.Drawing.Size(49, 46);
            this.buttonTogglePassword.TabIndex = 8;
            this.buttonTogglePassword.Text = "👁";
            this.buttonTogglePassword.UseVisualStyleBackColor = false;
            this.buttonTogglePassword.Click += new System.EventHandler(this.buttonTogglePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonTogglePassword);
            this.Controls.Add(this.listBoxRecommendations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBarStrength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelStrengthText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStrengthText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarStrength;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxRecommendations;
        private System.Windows.Forms.Button buttonTogglePassword;
    }
}

