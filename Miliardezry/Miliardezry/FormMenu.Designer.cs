namespace Miliardezry
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.textBoxEnterNick = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonTop10 = new System.Windows.Forms.Button();
            this.labelNick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEnterNick
            // 
            this.textBoxEnterNick.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxEnterNick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEnterNick.Location = new System.Drawing.Point(303, 125);
            this.textBoxEnterNick.Multiline = true;
            this.textBoxEnterNick.Name = "textBoxEnterNick";
            this.textBoxEnterNick.Size = new System.Drawing.Size(186, 32);
            this.textBoxEnterNick.TabIndex = 0;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPlay.Location = new System.Drawing.Point(511, 125);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(98, 32);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Graj!\r\n";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonRules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRules.Location = new System.Drawing.Point(511, 278);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(98, 64);
            this.buttonRules.TabIndex = 2;
            this.buttonRules.Text = "Zasady";
            this.buttonRules.UseVisualStyleBackColor = false;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // buttonTop10
            // 
            this.buttonTop10.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTop10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTop10.Location = new System.Drawing.Point(87, 291);
            this.buttonTop10.Name = "buttonTop10";
            this.buttonTop10.Size = new System.Drawing.Size(108, 51);
            this.buttonTop10.TabIndex = 3;
            this.buttonTop10.Text = "Lista graczy";
            this.buttonTop10.UseVisualStyleBackColor = false;
            this.buttonTop10.Click += new System.EventHandler(this.buttonTop10_Click);
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.BackColor = System.Drawing.Color.Black;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNick.Location = new System.Drawing.Point(303, 87);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(116, 20);
            this.labelNick.TabIndex = 4;
            this.labelNick.Text = "Podaj swój nick";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 455);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.buttonTop10);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxEnterNick);
            this.Name = "FormMenu";
            this.Text = "Zapisywanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnterNick;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonTop10;
        private System.Windows.Forms.Label labelNick;
    }
}

