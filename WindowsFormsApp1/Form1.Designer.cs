namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.InputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.OutputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(21, 20);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(77, 32);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(27, 72);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(590, 38);
            this.InputTextbox.TabIndex = 1;
            this.InputTextbox.Text = "csv filepath";
            // 
            // InputOpenFileDialog
            // 
            this.InputOpenFileDialog.FileName = "input.csv";
            this.InputOpenFileDialog.Filter = "CSV Files (*.csv)|*csv";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(21, 156);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(100, 32);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(27, 219);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(590, 38);
            this.OutputTextbox.TabIndex = 3;
            this.OutputTextbox.Text = "html filepath";
            // 
            // OutputSaveFileDialog
            // 
            this.OutputSaveFileDialog.FileName = "output.html";
            this.OutputSaveFileDialog.Filter = "All Files (*.*)|*";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(27, 312);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(181, 66);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(623, 72);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(165, 59);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Select";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(623, 219);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(165, 57);
            this.SaveFileButton.TabIndex = 6;
            this.SaveFileButton.Text = "Select";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.InputLabel);
            this.Name = "Form1";
            this.Text = "CSV->HTML Table Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.OpenFileDialog InputOpenFileDialog;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.SaveFileDialog OutputSaveFileDialog;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
    }
}

