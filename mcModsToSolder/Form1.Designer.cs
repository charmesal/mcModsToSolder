namespace mcModsToSolder
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnChooseInitialFolder = new System.Windows.Forms.Button();
            this.lbFoudMods = new System.Windows.Forms.ListBox();
            this.lblFoudMods = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(997, 190);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(539, 94);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "button1";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnChooseInitialFolder
            // 
            this.btnChooseInitialFolder.Location = new System.Drawing.Point(12, 12);
            this.btnChooseInitialFolder.Name = "btnChooseInitialFolder";
            this.btnChooseInitialFolder.Size = new System.Drawing.Size(85, 23);
            this.btnChooseInitialFolder.TabIndex = 2;
            this.btnChooseInitialFolder.Text = "Choose folder";
            this.btnChooseInitialFolder.UseVisualStyleBackColor = true;
            this.btnChooseInitialFolder.Click += new System.EventHandler(this.btnChooseInitialFolder_Click);
            // 
            // lbFoudMods
            // 
            this.lbFoudMods.FormattingEnabled = true;
            this.lbFoudMods.Location = new System.Drawing.Point(12, 103);
            this.lbFoudMods.Name = "lbFoudMods";
            this.lbFoudMods.Size = new System.Drawing.Size(120, 95);
            this.lbFoudMods.TabIndex = 3;
            // 
            // lblFoudMods
            // 
            this.lblFoudMods.AutoSize = true;
            this.lblFoudMods.Location = new System.Drawing.Point(12, 87);
            this.lblFoudMods.Name = "lblFoudMods";
            this.lblFoudMods.Size = new System.Drawing.Size(59, 13);
            this.lblFoudMods.TabIndex = 4;
            this.lblFoudMods.Text = "Foud mods";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 624);
            this.Controls.Add(this.lblFoudMods);
            this.Controls.Add(this.lbFoudMods);
            this.Controls.Add(this.btnChooseInitialFolder);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnChooseInitialFolder;
        private System.Windows.Forms.ListBox lbFoudMods;
        private System.Windows.Forms.Label lblFoudMods;


    }
}

