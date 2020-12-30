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
            this.FileSelecionLabel = new System.Windows.Forms.Label();
            this.FileSelectionTextBox = new System.Windows.Forms.TextBox();
            this.FileSelectionButton = new System.Windows.Forms.Button();
            this.FileExportButton = new System.Windows.Forms.Button();
            this.FileExportTextBox = new System.Windows.Forms.TextBox();
            this.FileExportLabel = new System.Windows.Forms.Label();
            this.LoadOptionsButton = new System.Windows.Forms.Button();
            this.SaveOptionsButton = new System.Windows.Forms.Button();
            this.FromSheetUpDown = new System.Windows.Forms.NumericUpDown();
            this.FromSheetLabel = new System.Windows.Forms.Label();
            this.ToSheetLabel = new System.Windows.Forms.Label();
            this.ToSheetUpDown = new System.Windows.Forms.NumericUpDown();
            this.FromRowUpDown = new System.Windows.Forms.NumericUpDown();
            this.FromRowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FromSheetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSheetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromRowUpDown)).BeginInit();
            this.SuspendLayout();
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
            // LoadOptionsButton
            // 
            this.LoadOptionsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadOptionsButton.Location = new System.Drawing.Point(12, 401);
            this.LoadOptionsButton.Name = "LoadOptionsButton";
            this.LoadOptionsButton.Size = new System.Drawing.Size(117, 37);
            this.LoadOptionsButton.TabIndex = 6;
            this.LoadOptionsButton.Text = "Carica Opzioni";
            this.LoadOptionsButton.UseVisualStyleBackColor = true;
            this.LoadOptionsButton.Click += new System.EventHandler(this.LoadOptionsButton_Click);
            // 
            // SaveOptionsButton
            // 
            this.SaveOptionsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOptionsButton.Location = new System.Drawing.Point(135, 401);
            this.SaveOptionsButton.Name = "SaveOptionsButton";
            this.SaveOptionsButton.Size = new System.Drawing.Size(117, 37);
            this.SaveOptionsButton.TabIndex = 7;
            this.SaveOptionsButton.Text = "Salva Opzioni";
            this.SaveOptionsButton.UseVisualStyleBackColor = true;
            this.SaveOptionsButton.Click += new System.EventHandler(this.SaveOptionsButton_Click);
            // 
            // FromSheetUpDown
            // 
            this.FromSheetUpDown.Location = new System.Drawing.Point(16, 146);
            this.FromSheetUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromSheetUpDown.Name = "FromSheetUpDown";
            this.FromSheetUpDown.Size = new System.Drawing.Size(74, 20);
            this.FromSheetUpDown.TabIndex = 9;
            this.FromSheetUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromSheetUpDown.ValueChanged += new System.EventHandler(this.FromSheetUpDown_ValueChanged);
            // 
            // FromSheetLabel
            // 
            this.FromSheetLabel.AutoSize = true;
            this.FromSheetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromSheetLabel.Location = new System.Drawing.Point(12, 124);
            this.FromSheetLabel.Name = "FromSheetLabel";
            this.FromSheetLabel.Size = new System.Drawing.Size(74, 19);
            this.FromSheetLabel.TabIndex = 10;
            this.FromSheetLabel.Text = "Dal foglio";
            // 
            // ToSheetLabel
            // 
            this.ToSheetLabel.AutoSize = true;
            this.ToSheetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToSheetLabel.Location = new System.Drawing.Point(163, 124);
            this.ToSheetLabel.Name = "ToSheetLabel";
            this.ToSheetLabel.Size = new System.Drawing.Size(66, 19);
            this.ToSheetLabel.TabIndex = 11;
            this.ToSheetLabel.Text = "Al foglio";
            // 
            // ToSheetUpDown
            // 
            this.ToSheetUpDown.Location = new System.Drawing.Point(163, 146);
            this.ToSheetUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ToSheetUpDown.Name = "ToSheetUpDown";
            this.ToSheetUpDown.Size = new System.Drawing.Size(74, 20);
            this.ToSheetUpDown.TabIndex = 12;
            this.ToSheetUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ToSheetUpDown.ValueChanged += new System.EventHandler(this.ToSheetUpDown_ValueChanged);
            // 
            // FromRowUpDown
            // 
            this.FromRowUpDown.Location = new System.Drawing.Point(325, 146);
            this.FromRowUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromRowUpDown.Name = "FromRowUpDown";
            this.FromRowUpDown.Size = new System.Drawing.Size(74, 20);
            this.FromRowUpDown.TabIndex = 14;
            this.FromRowUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromRowUpDown.ValueChanged += new System.EventHandler(this.FromRowUpDown_ValueChanged);
            // 
            // FromRowLabel
            // 
            this.FromRowLabel.AutoSize = true;
            this.FromRowLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromRowLabel.Location = new System.Drawing.Point(325, 124);
            this.FromRowLabel.Name = "FromRowLabel";
            this.FromRowLabel.Size = new System.Drawing.Size(251, 19);
            this.FromRowLabel.TabIndex = 13;
            this.FromRowLabel.Text = "Dalla riga (escludere le intestazioni)";
            // 
            // WmraConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.FromRowUpDown);
            this.Controls.Add(this.FromRowLabel);
            this.Controls.Add(this.ToSheetUpDown);
            this.Controls.Add(this.ToSheetLabel);
            this.Controls.Add(this.FromSheetLabel);
            this.Controls.Add(this.FromSheetUpDown);
            this.Controls.Add(this.SaveOptionsButton);
            this.Controls.Add(this.LoadOptionsButton);
            this.Controls.Add(this.FileExportButton);
            this.Controls.Add(this.FileExportTextBox);
            this.Controls.Add(this.FileExportLabel);
            this.Controls.Add(this.FileSelectionButton);
            this.Controls.Add(this.FileSelectionTextBox);
            this.Controls.Add(this.FileSelecionLabel);
            this.Name = "WmraConverter";
            this.Text = "WMRA Converter";
            ((System.ComponentModel.ISupportInitialize)(this.FromSheetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSheetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromRowUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FileSelecionLabel;
        private System.Windows.Forms.TextBox FileSelectionTextBox;
        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.Button FileExportButton;
        private System.Windows.Forms.TextBox FileExportTextBox;
        private System.Windows.Forms.Label FileExportLabel;
        private System.Windows.Forms.Button LoadOptionsButton;
        private System.Windows.Forms.Button SaveOptionsButton;
        private System.Windows.Forms.NumericUpDown FromSheetUpDown;
        private System.Windows.Forms.Label FromSheetLabel;
        private System.Windows.Forms.Label ToSheetLabel;
        private System.Windows.Forms.NumericUpDown ToSheetUpDown;
        private System.Windows.Forms.NumericUpDown FromRowUpDown;
        private System.Windows.Forms.Label FromRowLabel;
    }
}

