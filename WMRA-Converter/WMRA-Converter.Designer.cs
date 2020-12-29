namespace WMRA_Converter
{
    partial class WmraConverter
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FileSelecionLabel = new System.Windows.Forms.Label();
            this.FileSelectionTextBox = new System.Windows.Forms.TextBox();
            this.FileSelectionButton = new System.Windows.Forms.Button();
            this.FileExportButton = new System.Windows.Forms.Button();
            this.FileExportTextBox = new System.Windows.Forms.TextBox();
            this.FileExportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FileSelecionLabel
            // 
            this.FileSelecionLabel.AutoSize = true;
            this.FileSelecionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSelecionLabel.Location = new System.Drawing.Point(12, 9);
            this.FileSelecionLabel.Name = "FileSelecionLabel";
            this.FileSelecionLabel.Size = new System.Drawing.Size(123, 19);
            this.FileSelecionLabel.TabIndex = 0;
            this.FileSelecionLabel.Text = "File da elaborare";
            // 
            // FileSelectionTextBox
            // 
            this.FileSelectionTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSelectionTextBox.Location = new System.Drawing.Point(16, 31);
            this.FileSelectionTextBox.Name = "FileSelectionTextBox";
            this.FileSelectionTextBox.Size = new System.Drawing.Size(640, 27);
            this.FileSelectionTextBox.TabIndex = 1;
            // 
            // FileSelectionButton
            // 
            this.FileSelectionButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSelectionButton.Location = new System.Drawing.Point(662, 31);
            this.FileSelectionButton.Name = "FileSelectionButton";
            this.FileSelectionButton.Size = new System.Drawing.Size(58, 27);
            this.FileSelectionButton.TabIndex = 2;
            this.FileSelectionButton.Text = "Cerca";
            this.FileSelectionButton.UseVisualStyleBackColor = true;
            this.FileSelectionButton.Click += new System.EventHandler(this.FileSelectionButton_Click);
            // 
            // FileExportButton
            // 
            this.FileExportButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExportButton.Location = new System.Drawing.Point(662, 88);
            this.FileExportButton.Name = "FileExportButton";
            this.FileExportButton.Size = new System.Drawing.Size(58, 27);
            this.FileExportButton.TabIndex = 5;
            this.FileExportButton.Text = "Cerca";
            this.FileExportButton.UseVisualStyleBackColor = true;
            this.FileExportButton.Click += new System.EventHandler(this.FileExportButton_Click);
            // 
            // FileExportTextBox
            // 
            this.FileExportTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExportTextBox.Location = new System.Drawing.Point(16, 88);
            this.FileExportTextBox.Name = "FileExportTextBox";
            this.FileExportTextBox.Size = new System.Drawing.Size(640, 27);
            this.FileExportTextBox.TabIndex = 4;
            // 
            // FileExportLabel
            // 
            this.FileExportLabel.AutoSize = true;
            this.FileExportLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExportLabel.Location = new System.Drawing.Point(12, 66);
            this.FileExportLabel.Name = "FileExportLabel";
            this.FileExportLabel.Size = new System.Drawing.Size(123, 19);
            this.FileExportLabel.TabIndex = 3;
            this.FileExportLabel.Text = "File da esportare";
            // 
            // WmraConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.FileExportButton);
            this.Controls.Add(this.FileExportTextBox);
            this.Controls.Add(this.FileExportLabel);
            this.Controls.Add(this.FileSelectionButton);
            this.Controls.Add(this.FileSelectionTextBox);
            this.Controls.Add(this.FileSelecionLabel);
            this.Name = "WmraConverter";
            this.Text = "WMRA Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label FileSelecionLabel;
        private System.Windows.Forms.TextBox FileSelectionTextBox;
        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.Button FileExportButton;
        private System.Windows.Forms.TextBox FileExportTextBox;
        private System.Windows.Forms.Label FileExportLabel;
    }
}

