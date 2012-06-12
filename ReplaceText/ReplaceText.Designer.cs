namespace ReplaceText
{
    partial class ReplaceText
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
            if (disposing && (components != null)) {
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
            this.lbl_SourceDirectory = new System.Windows.Forms.Label();
            this.lbl_TargetDirectory = new System.Windows.Forms.Label();
            this.txt_SourceDirectory = new System.Windows.Forms.TextBox();
            this.txt_TargetDirectory = new System.Windows.Forms.TextBox();
            this.btn_SourceDirectory = new System.Windows.Forms.Button();
            this.btn_TargetDirectory = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lst_Logger = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SourceDirectory
            // 
            this.lbl_SourceDirectory.AutoSize = true;
            this.lbl_SourceDirectory.Location = new System.Drawing.Point(17, 203);
            this.lbl_SourceDirectory.Name = "lbl_SourceDirectory";
            this.lbl_SourceDirectory.Size = new System.Drawing.Size(89, 13);
            this.lbl_SourceDirectory.TabIndex = 0;
            this.lbl_SourceDirectory.Text = "Source Directory:";
            // 
            // lbl_TargetDirectory
            // 
            this.lbl_TargetDirectory.AutoSize = true;
            this.lbl_TargetDirectory.Location = new System.Drawing.Point(17, 235);
            this.lbl_TargetDirectory.Name = "lbl_TargetDirectory";
            this.lbl_TargetDirectory.Size = new System.Drawing.Size(86, 13);
            this.lbl_TargetDirectory.TabIndex = 1;
            this.lbl_TargetDirectory.Text = "Target Directory:";
            // 
            // txt_SourceDirectory
            // 
            this.txt_SourceDirectory.Location = new System.Drawing.Point(113, 203);
            this.txt_SourceDirectory.Name = "txt_SourceDirectory";
            this.txt_SourceDirectory.Size = new System.Drawing.Size(226, 20);
            this.txt_SourceDirectory.TabIndex = 2;
            // 
            // txt_TargetDirectory
            // 
            this.txt_TargetDirectory.Location = new System.Drawing.Point(113, 235);
            this.txt_TargetDirectory.Name = "txt_TargetDirectory";
            this.txt_TargetDirectory.Size = new System.Drawing.Size(226, 20);
            this.txt_TargetDirectory.TabIndex = 3;
            // 
            // btn_SourceDirectory
            // 
            this.btn_SourceDirectory.Location = new System.Drawing.Point(345, 203);
            this.btn_SourceDirectory.Name = "btn_SourceDirectory";
            this.btn_SourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_SourceDirectory.TabIndex = 4;
            this.btn_SourceDirectory.Text = "Browse";
            this.btn_SourceDirectory.UseVisualStyleBackColor = true;
            this.btn_SourceDirectory.Click += new System.EventHandler(this.btn_SourceDirectory_Click);
            // 
            // btn_TargetDirectory
            // 
            this.btn_TargetDirectory.Location = new System.Drawing.Point(344, 235);
            this.btn_TargetDirectory.Name = "btn_TargetDirectory";
            this.btn_TargetDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_TargetDirectory.TabIndex = 5;
            this.btn_TargetDirectory.Text = "Browse";
            this.btn_TargetDirectory.UseVisualStyleBackColor = true;
            this.btn_TargetDirectory.Click += new System.EventHandler(this.btn_TargetDirectory_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Replace Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Extension:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lst_Logger
            // 
            this.lst_Logger.FormattingEnabled = true;
            this.lst_Logger.Location = new System.Drawing.Point(-3, -1);
            this.lst_Logger.Name = "lst_Logger";
            this.lst_Logger.Size = new System.Drawing.Size(443, 186);
            this.lst_Logger.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Begin Replace";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReplaceText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_Logger);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_TargetDirectory);
            this.Controls.Add(this.btn_SourceDirectory);
            this.Controls.Add(this.txt_TargetDirectory);
            this.Controls.Add(this.txt_SourceDirectory);
            this.Controls.Add(this.lbl_TargetDirectory);
            this.Controls.Add(this.lbl_SourceDirectory);
            this.Name = "ReplaceText";
            this.Text = "ReplaceText";
            this.Load += new System.EventHandler(this.ReplaceText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SourceDirectory;
        private System.Windows.Forms.Label lbl_TargetDirectory;
        private System.Windows.Forms.TextBox txt_SourceDirectory;
        private System.Windows.Forms.TextBox txt_TargetDirectory;
        private System.Windows.Forms.Button btn_SourceDirectory;
        private System.Windows.Forms.Button btn_TargetDirectory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lst_Logger;
        private System.Windows.Forms.Button button1;
    }
}