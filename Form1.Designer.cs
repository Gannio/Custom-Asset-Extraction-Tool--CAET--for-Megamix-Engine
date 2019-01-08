namespace CAET
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
            this.textBoxProjectPath = new System.Windows.Forms.TextBox();
            this.buttonProjectPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.openFileDialogProjectPath = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProjectPath
            // 
            this.textBoxProjectPath.Location = new System.Drawing.Point(91, 12);
            this.textBoxProjectPath.Name = "textBoxProjectPath";
            this.textBoxProjectPath.Size = new System.Drawing.Size(100, 20);
            this.textBoxProjectPath.TabIndex = 0;
            this.textBoxProjectPath.TextChanged += new System.EventHandler(this.textBoxProjectPath_TextChanged);
            // 
            // buttonProjectPath
            // 
            this.buttonProjectPath.Location = new System.Drawing.Point(197, 12);
            this.buttonProjectPath.Name = "buttonProjectPath";
            this.buttonProjectPath.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectPath.TabIndex = 1;
            this.buttonProjectPath.Text = "Browse...";
            this.buttonProjectPath.UseVisualStyleBackColor = true;
            this.buttonProjectPath.Click += new System.EventHandler(this.buttonProjectPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Path:";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(100, 100);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOutput.TabIndex = 3;
            this.buttonOutput.Text = "Output!";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // openFileDialogProjectPath
            // 
            this.openFileDialogProjectPath.DefaultExt = "gmx";
            this.openFileDialogProjectPath.FileName = "openFileDialog1";
            this.openFileDialogProjectPath.Filter = "GMS Project Files|*.project.gmx|All files|*.*";
            this.openFileDialogProjectPath.Title = "Choose the \'.project.gmx\' file to get the folder directory.";
            this.openFileDialogProjectPath.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogProjectPath_FileOk);
            // 
            // saveFileDialogOutput
            // 
            this.saveFileDialogOutput.FileName = "NameFolderWillBeCalled";
            this.saveFileDialogOutput.Title = "Choose a place to save your seperated assets. The file name will become the folde" +
    "r they save to.";
            this.saveFileDialogOutput.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogOutput_FileOk);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(91, 38);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(12, 239);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(95, 13);
            this.labelCredits.TabIndex = 6;
            this.labelCredits.Text = "Created by Gannio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProjectPath);
            this.Controls.Add(this.textBoxProjectPath);
            this.Name = "Form1";
            this.Text = "Collect Assets Extraction Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProjectPath;
        private System.Windows.Forms.Button buttonProjectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialogProjectPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCredits;
    }
}

