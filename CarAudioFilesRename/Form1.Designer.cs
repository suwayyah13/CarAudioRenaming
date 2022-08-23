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
            this.button1 = new System.Windows.Forms.Button();
            this.labelFileTypes = new System.Windows.Forms.Label();
            this.textFileTypes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonChooseFolderIn
            // 
            this.buttonChooseFolderIn.Location = new System.Drawing.Point(400, 40);
            this.buttonChooseFolderIn.Name = "buttonChooseFolderIn";
            this.buttonChooseFolderIn.Size = new System.Drawing.Size(90, 20);
            this.buttonChooseFolderIn.TabIndex = 0;
            this.buttonChooseFolderIn.Text = "Choose folder";
            this.buttonChooseFolderIn.UseVisualStyleBackColor = true;
            this.buttonChooseFolderIn.Click += new System.EventHandler(this.ChooseFolderIn);
            // 
            // textFolderIn
            // 
            this.textFolderIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFolderIn.Location = new System.Drawing.Point(90, 40);
            this.textFolderIn.Name = "textFolderIn";
            this.textFolderIn.ReadOnly = true;
            this.textFolderIn.Size = new System.Drawing.Size(300, 20);
            this.textFolderIn.TabIndex = 1;
            // 
            // labelFolderIn
            // 
            this.labelFolderIn.Location = new System.Drawing.Point(10, 40);
            this.labelFolderIn.Name = "labelFolderIn";
            this.labelFolderIn.Size = new System.Drawing.Size(70, 20);
            this.labelFolderIn.TabIndex = 2;
            this.labelFolderIn.Text = "Source folder";
            this.labelFolderIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFolderOut
            // 
            this.labelFolderOut.Location = new System.Drawing.Point(10, 70);
            this.labelFolderOut.Name = "labelFolderOut";
            this.labelFolderOut.Size = new System.Drawing.Size(70, 20);
            this.labelFolderOut.TabIndex = 3;
            this.labelFolderOut.Text = "Result folder";
            this.labelFolderOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFolderOut
            // 
            this.textFolderOut.Location = new System.Drawing.Point(90, 70);
            this.textFolderOut.Name = "textFolderOut";
            this.textFolderOut.ReadOnly = true;
            this.textFolderOut.Size = new System.Drawing.Size(300, 20);
            this.textFolderOut.TabIndex = 4;
            // 
            // buttonChooseFolderOut
            // 
            this.buttonChooseFolderOut.Location = new System.Drawing.Point(400, 70);
            this.buttonChooseFolderOut.Name = "buttonChooseFolderOut";
            this.buttonChooseFolderOut.Size = new System.Drawing.Size(90, 20);
            this.buttonChooseFolderOut.TabIndex = 5;
            this.buttonChooseFolderOut.Text = "Choose folder";
            this.buttonChooseFolderOut.UseVisualStyleBackColor = true;
            this.buttonChooseFolderOut.Click += new System.EventHandler(this.ChooseFolderOut);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy && rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RenameAndCopyFiles);
            // 
            // labelFileTypes
            // 
            this.labelFileTypes.Location = new System.Drawing.Point(10, 10);
            this.labelFileTypes.Name = "labelFileTypes";
            this.labelFileTypes.Size = new System.Drawing.Size(70, 20);
            this.labelFileTypes.TabIndex = 7;
            this.labelFileTypes.Text = "File types";
            this.labelFileTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFileTypes
            // 
            this.textFileTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileTypes.Location = new System.Drawing.Point(90, 10);
            this.textFileTypes.Name = "textFileTypes";
            this.textFileTypes.Size = new System.Drawing.Size(300, 20);
            this.textFileTypes.TabIndex = 8;
            this.textFileTypes.Text = "*.mp3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 134);
            this.Controls.Add(this.textFileTypes);
            this.Controls.Add(this.labelFileTypes);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFileTypes;
        private System.Windows.Forms.TextBox textFileTypes;
    }
}

