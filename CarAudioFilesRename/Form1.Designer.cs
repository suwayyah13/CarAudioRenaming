namespace CarAudioFilesRename
{
    partial class MainForm
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
            this.buttonChooseFolderIn = new System.Windows.Forms.Button();
            this.FolderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.textFolderIn = new System.Windows.Forms.TextBox();
            this.labelFolderIn = new System.Windows.Forms.Label();
            this.labelFolderOut = new System.Windows.Forms.Label();
            this.textFolderOut = new System.Windows.Forms.TextBox();
            this.buttonChooseFolderOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChooseFolderIn
            // 
            this.buttonChooseFolderIn.Location = new System.Drawing.Point(472, 26);
            this.buttonChooseFolderIn.Name = "buttonChooseFolderIn";
            this.buttonChooseFolderIn.Size = new System.Drawing.Size(90, 20);
            this.buttonChooseFolderIn.TabIndex = 0;
            this.buttonChooseFolderIn.Text = "Choose folder";
            this.buttonChooseFolderIn.UseVisualStyleBackColor = true;
            this.buttonChooseFolderIn.Click += new System.EventHandler(this.ChooseFolderIn);
            // 
            // textFolderIn
            // 
            this.textFolderIn.Location = new System.Drawing.Point(159, 26);
            this.textFolderIn.Name = "textFolderIn";
            this.textFolderIn.ReadOnly = true;
            this.textFolderIn.Size = new System.Drawing.Size(286, 20);
            this.textFolderIn.TabIndex = 1;
            // 
            // labelFolderIn
            // 
            this.labelFolderIn.AutoSize = true;
            this.labelFolderIn.Location = new System.Drawing.Point(12, 29);
            this.labelFolderIn.Name = "labelFolderIn";
            this.labelFolderIn.Size = new System.Drawing.Size(70, 13);
            this.labelFolderIn.TabIndex = 2;
            this.labelFolderIn.Text = "Source folder";
            // 
            // labelFolderOut
            // 
            this.labelFolderOut.AutoSize = true;
            this.labelFolderOut.Location = new System.Drawing.Point(12, 61);
            this.labelFolderOut.Name = "labelFolderOut";
            this.labelFolderOut.Size = new System.Drawing.Size(66, 13);
            this.labelFolderOut.TabIndex = 3;
            this.labelFolderOut.Text = "Result folder";
            // 
            // textFolderOut
            // 
            this.textFolderOut.Location = new System.Drawing.Point(159, 61);
            this.textFolderOut.Name = "textFolderOut";
            this.textFolderOut.ReadOnly = true;
            this.textFolderOut.Size = new System.Drawing.Size(286, 20);
            this.textFolderOut.TabIndex = 4;
            // 
            // buttonChooseFolderOut
            // 
            this.buttonChooseFolderOut.Location = new System.Drawing.Point(472, 61);
            this.buttonChooseFolderOut.Name = "buttonChooseFolderOut";
            this.buttonChooseFolderOut.Size = new System.Drawing.Size(90, 20);
            this.buttonChooseFolderOut.TabIndex = 5;
            this.buttonChooseFolderOut.Text = "Chooser folder";
            this.buttonChooseFolderOut.UseVisualStyleBackColor = true;
            this.buttonChooseFolderOut.Click += new System.EventHandler(this.ChooseFolderOut);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChooseFolderOut);
            this.Controls.Add(this.textFolderOut);
            this.Controls.Add(this.labelFolderOut);
            this.Controls.Add(this.labelFolderIn);
            this.Controls.Add(this.textFolderIn);
            this.Controls.Add(this.buttonChooseFolderIn);
            this.Name = "MainForm";
            this.Text = "Rename audio files for car player sorting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseFolderIn;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogInput;
        private System.Windows.Forms.TextBox textFolderIn;
        private System.Windows.Forms.Label labelFolderIn;
        private System.Windows.Forms.Label labelFolderOut;
        private System.Windows.Forms.TextBox textFolderOut;
        private System.Windows.Forms.Button buttonChooseFolderOut;
    }
}

