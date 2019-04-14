namespace Miliardezry
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.labelOdp = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.labelActuallMoney = new System.Windows.Forms.Label();
            this.labelEnsureMoney = new System.Windows.Forms.Label();
            this.textBoxActuallMoney = new System.Windows.Forms.TextBox();
            this.textBoxEnsureMoney = new System.Windows.Forms.TextBox();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.labelNick = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.Black;
            this.textBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer.Location = new System.Drawing.Point(87, 381);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(205, 38);
            this.textBoxAnswer.TabIndex = 11;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.BackColor = System.Drawing.Color.Black;
            this.buttonAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer.Location = new System.Drawing.Point(308, 381);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(89, 38);
            this.buttonAnswer.TabIndex = 12;
            this.buttonAnswer.Text = "Zatwierdzam\r\n\r\n\r\n";
            this.buttonAnswer.UseVisualStyleBackColor = false;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // labelOdp
            // 
            this.labelOdp.AutoSize = true;
            this.labelOdp.BackColor = System.Drawing.Color.Black;
            this.labelOdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelOdp.ForeColor = System.Drawing.Color.White;
            this.labelOdp.Location = new System.Drawing.Point(87, 362);
            this.labelOdp.Name = "labelOdp";
            this.labelOdp.Size = new System.Drawing.Size(246, 13);
            this.labelOdp.TabIndex = 13;
            this.labelOdp.Text = "Wpisz swoją odpowiedź (a,b,c,d) i naciśnij przycisk";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.Black;
            this.textBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.textBoxQuestion.Location = new System.Drawing.Point(44, 92);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(580, 45);
            this.textBoxQuestion.TabIndex = 24;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Black;
            this.textBoxA.ForeColor = System.Drawing.Color.White;
            this.textBoxA.Location = new System.Drawing.Point(44, 178);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(217, 38);
            this.textBoxA.TabIndex = 25;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.Black;
            this.textBoxB.ForeColor = System.Drawing.Color.White;
            this.textBoxB.Location = new System.Drawing.Point(363, 176);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(217, 38);
            this.textBoxB.TabIndex = 26;
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.Color.Black;
            this.textBoxC.ForeColor = System.Drawing.Color.White;
            this.textBoxC.Location = new System.Drawing.Point(44, 280);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(216, 38);
            this.textBoxC.TabIndex = 27;
            // 
            // textBoxD
            // 
            this.textBoxD.BackColor = System.Drawing.Color.Black;
            this.textBoxD.ForeColor = System.Drawing.Color.White;
            this.textBoxD.Location = new System.Drawing.Point(363, 278);
            this.textBoxD.Multiline = true;
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(217, 38);
            this.textBoxD.TabIndex = 28;
            // 
            // labelActuallMoney
            // 
            this.labelActuallMoney.AutoSize = true;
            this.labelActuallMoney.BackColor = System.Drawing.Color.Black;
            this.labelActuallMoney.ForeColor = System.Drawing.Color.White;
            this.labelActuallMoney.Location = new System.Drawing.Point(654, 56);
            this.labelActuallMoney.Name = "labelActuallMoney";
            this.labelActuallMoney.Size = new System.Drawing.Size(92, 13);
            this.labelActuallMoney.TabIndex = 29;
            this.labelActuallMoney.Text = "Aktualna wygrana";
            // 
            // labelEnsureMoney
            // 
            this.labelEnsureMoney.AutoSize = true;
            this.labelEnsureMoney.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelEnsureMoney.Location = new System.Drawing.Point(654, 124);
            this.labelEnsureMoney.Name = "labelEnsureMoney";
            this.labelEnsureMoney.Size = new System.Drawing.Size(123, 13);
            this.labelEnsureMoney.TabIndex = 30;
            this.labelEnsureMoney.Text = "Wygrana gwarantowana";
            // 
            // textBoxActuallMoney
            // 
            this.textBoxActuallMoney.BackColor = System.Drawing.Color.Black;
            this.textBoxActuallMoney.ForeColor = System.Drawing.Color.White;
            this.textBoxActuallMoney.Location = new System.Drawing.Point(657, 72);
            this.textBoxActuallMoney.Name = "textBoxActuallMoney";
            this.textBoxActuallMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxActuallMoney.TabIndex = 31;
            this.textBoxActuallMoney.Text = "0 zł";
            // 
            // textBoxEnsureMoney
            // 
            this.textBoxEnsureMoney.BackColor = System.Drawing.Color.Black;
            this.textBoxEnsureMoney.ForeColor = System.Drawing.Color.White;
            this.textBoxEnsureMoney.Location = new System.Drawing.Point(657, 140);
            this.textBoxEnsureMoney.Name = "textBoxEnsureMoney";
            this.textBoxEnsureMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnsureMoney.TabIndex = 32;
            this.textBoxEnsureMoney.Text = "0 zł";
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.BackColor = System.Drawing.Color.Black;
            this.buttonNextQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonNextQuestion.Location = new System.Drawing.Point(479, 381);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(89, 38);
            this.buttonNextQuestion.TabIndex = 33;
            this.buttonNextQuestion.Text = "Losuj pytanie\r\n";
            this.buttonNextQuestion.UseVisualStyleBackColor = false;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelNick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNick.Location = new System.Drawing.Point(56, 16);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(29, 13);
            this.labelNick.TabIndex = 34;
            this.labelNick.Text = "Nick";
            // 
            // textBoxNick
            // 
            this.textBoxNick.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNick.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNick.Location = new System.Drawing.Point(103, 13);
            this.textBoxNick.Multiline = true;
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(157, 20);
            this.textBoxNick.TabIndex = 35;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.textBoxEnsureMoney);
            this.Controls.Add(this.textBoxActuallMoney);
            this.Controls.Add(this.labelEnsureMoney);
            this.Controls.Add(this.labelActuallMoney);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelOdp);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gra";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Label labelOdp;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelActuallMoney;
        private System.Windows.Forms.Label labelEnsureMoney;
        private System.Windows.Forms.TextBox textBoxActuallMoney;
        private System.Windows.Forms.TextBox textBoxEnsureMoney;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.TextBox textBoxNick;
    }
}