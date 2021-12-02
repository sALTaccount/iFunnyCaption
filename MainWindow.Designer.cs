
namespace iFunnyCaptionGUI
{
    partial class MainWindow
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
            this.openInputGif = new System.Windows.Forms.OpenFileDialog();
            this.openOutputGif = new System.Windows.Forms.SaveFileDialog();
            this.RenderButton = new System.Windows.Forms.Button();
            this.InGifPicker = new System.Windows.Forms.Button();
            this.OutDirPicker = new System.Windows.Forms.Button();
            this.InputGifDir = new System.Windows.Forms.TextBox();
            this.OutputGifDir = new System.Windows.Forms.TextBox();
            this.CaptionText = new System.Windows.Forms.TextBox();
            this.SpeedDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RenderProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openInputGif
            // 
            this.openInputGif.FileName = "openInputGif";
            // 
            // RenderButton
            // 
            this.RenderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderButton.Location = new System.Drawing.Point(0, 105);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(588, 23);
            this.RenderButton.TabIndex = 0;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // InGifPicker
            // 
            this.InGifPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InGifPicker.Location = new System.Drawing.Point(513, 3);
            this.InGifPicker.Name = "InGifPicker";
            this.InGifPicker.Size = new System.Drawing.Size(75, 23);
            this.InGifPicker.TabIndex = 1;
            this.InGifPicker.Text = "Open";
            this.InGifPicker.UseVisualStyleBackColor = true;
            this.InGifPicker.Click += new System.EventHandler(this.InGifPicker_Click);
            // 
            // OutDirPicker
            // 
            this.OutDirPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutDirPicker.Location = new System.Drawing.Point(513, 28);
            this.OutDirPicker.Name = "OutDirPicker";
            this.OutDirPicker.Size = new System.Drawing.Size(75, 23);
            this.OutDirPicker.TabIndex = 2;
            this.OutDirPicker.Text = "Open";
            this.OutDirPicker.UseVisualStyleBackColor = true;
            this.OutDirPicker.Click += new System.EventHandler(this.OutDirPicker_Click);
            // 
            // InputGifDir
            // 
            this.InputGifDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputGifDir.Location = new System.Drawing.Point(68, 3);
            this.InputGifDir.Name = "InputGifDir";
            this.InputGifDir.Size = new System.Drawing.Size(439, 20);
            this.InputGifDir.TabIndex = 3;
            // 
            // OutputGifDir
            // 
            this.OutputGifDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGifDir.Location = new System.Drawing.Point(68, 30);
            this.OutputGifDir.Name = "OutputGifDir";
            this.OutputGifDir.Size = new System.Drawing.Size(439, 20);
            this.OutputGifDir.TabIndex = 4;
            // 
            // CaptionText
            // 
            this.CaptionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptionText.Location = new System.Drawing.Point(68, 56);
            this.CaptionText.Multiline = true;
            this.CaptionText.Name = "CaptionText";
            this.CaptionText.Size = new System.Drawing.Size(520, 19);
            this.CaptionText.TabIndex = 5;
            // 
            // SpeedDropdown
            // 
            this.SpeedDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedDropdown.FormattingEnabled = true;
            this.SpeedDropdown.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "175%",
            "200%",
            "225%",
            "250%",
            "275%",
            "300%"});
            this.SpeedDropdown.Location = new System.Drawing.Point(530, 81);
            this.SpeedDropdown.Name = "SpeedDropdown";
            this.SpeedDropdown.Size = new System.Drawing.Size(58, 21);
            this.SpeedDropdown.TabIndex = 6;
            this.SpeedDropdown.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input Gif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Gif";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Caption";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SpeedDropdown);
            this.panel1.Controls.Add(this.CaptionText);
            this.panel1.Controls.Add(this.OutputGifDir);
            this.panel1.Controls.Add(this.InputGifDir);
            this.panel1.Controls.Add(this.OutDirPicker);
            this.panel1.Controls.Add(this.InGifPicker);
            this.panel1.Controls.Add(this.RenderButton);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 157);
            this.panel1.TabIndex = 0;
            // 
            // RenderProgressBar
            // 
            this.RenderProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderProgressBar.Location = new System.Drawing.Point(8, 146);
            this.RenderProgressBar.Name = "RenderProgressBar";
            this.RenderProgressBar.Size = new System.Drawing.Size(588, 23);
            this.RenderProgressBar.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 174);
            this.Controls.Add(this.RenderProgressBar);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 213);
            this.MinimumSize = new System.Drawing.Size(220, 184);
            this.Name = "MainWindow";
            this.Text = "iFunny Caption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openInputGif;
        private System.Windows.Forms.SaveFileDialog openOutputGif;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.Button InGifPicker;
        private System.Windows.Forms.Button OutDirPicker;
        private System.Windows.Forms.TextBox InputGifDir;
        private System.Windows.Forms.TextBox OutputGifDir;
        private System.Windows.Forms.TextBox CaptionText;
        private System.Windows.Forms.ComboBox SpeedDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar RenderProgressBar;
    }
}

