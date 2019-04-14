namespace Miliardezry
{
    partial class FromTop10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromTop10));
            this.dataGridViewTop10 = new System.Windows.Forms.DataGridView();
            this.buttonTop10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTop10
            // 
            this.dataGridViewTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop10.Location = new System.Drawing.Point(26, 12);
            this.dataGridViewTop10.Name = "dataGridViewTop10";
            this.dataGridViewTop10.Size = new System.Drawing.Size(244, 426);
            this.dataGridViewTop10.TabIndex = 0;
            // 
            // buttonTop10
            // 
            this.buttonTop10.Location = new System.Drawing.Point(285, 12);
            this.buttonTop10.Name = "buttonTop10";
            this.buttonTop10.Size = new System.Drawing.Size(171, 23);
            this.buttonTop10.TabIndex = 1;
            this.buttonTop10.Text = "Pokaż wyniki graczy";
            this.buttonTop10.UseVisualStyleBackColor = true;
            this.buttonTop10.Click += new System.EventHandler(this.buttonTop10_Click);
            // 
            // FromTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTop10);
            this.Controls.Add(this.dataGridViewTop10);
            this.Name = "FromTop10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Top10";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTop10;
        private System.Windows.Forms.Button buttonTop10;
    }
}