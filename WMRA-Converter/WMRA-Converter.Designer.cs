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
            this.FromRowUpDown = new System.Windows.Forms.NumericUpDown();
            this.FromRowLabel = new System.Windows.Forms.Label();
            this.ColumnDataLabel = new System.Windows.Forms.Label();
            this.NewColumnDataButton = new System.Windows.Forms.Button();
            this.ColumnControlPanel = new System.Windows.Forms.Panel();
            this.ExecuteButton = new System.Windows.Forms.Button();
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
            this.LoadOptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadOptionsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadOptionsButton.Location = new System.Drawing.Point(12, 480);
            this.LoadOptionsButton.Name = "LoadOptionsButton";
            this.LoadOptionsButton.Size = new System.Drawing.Size(117, 37);
            this.LoadOptionsButton.TabIndex = 6;
            this.LoadOptionsButton.Text = "Carica Opzioni";
            this.LoadOptionsButton.UseVisualStyleBackColor = true;
            this.LoadOptionsButton.Click += new System.EventHandler(this.LoadOptionsButton_Click);
            // 
            // SaveOptionsButton
            // 
            this.SaveOptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveOptionsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOptionsButton.Location = new System.Drawing.Point(135, 480);
            this.SaveOptionsButton.Name = "SaveOptionsButton";
            this.SaveOptionsButton.Size = new System.Drawing.Size(117, 37);
            this.SaveOptionsButton.TabIndex = 7;
            this.SaveOptionsButton.Text = "Salva Opzioni";
            this.SaveOptionsButton.UseVisualStyleBackColor = true;
            this.SaveOptionsButton.Click += new System.EventHandler(this.SaveOptionsButton_Click);
            // 
            // FromRowUpDown
            // 
            this.FromRowUpDown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromRowUpDown.Location = new System.Drawing.Point(16, 146);
            this.FromRowUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromRowUpDown.Name = "FromRowUpDown";
            this.FromRowUpDown.Size = new System.Drawing.Size(74, 23);
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
            this.FromRowLabel.Location = new System.Drawing.Point(16, 124);
            this.FromRowLabel.Name = "FromRowLabel";
            this.FromRowLabel.Size = new System.Drawing.Size(251, 19);
            this.FromRowLabel.TabIndex = 13;
            this.FromRowLabel.Text = "Dalla riga (escludere le intestazioni)";
            // 
            // ColumnDataLabel
            // 
            this.ColumnDataLabel.AutoSize = true;
            this.ColumnDataLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnDataLabel.Location = new System.Drawing.Point(12, 176);
            this.ColumnDataLabel.Name = "ColumnDataLabel";
            this.ColumnDataLabel.Size = new System.Drawing.Size(162, 19);
            this.ColumnDataLabel.TabIndex = 15;
            this.ColumnDataLabel.Text = "Composizione colonne";
            // 
            // NewColumnDataButton
            // 
            this.NewColumnDataButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewColumnDataButton.Location = new System.Drawing.Point(180, 173);
            this.NewColumnDataButton.Name = "NewColumnDataButton";
            this.NewColumnDataButton.Size = new System.Drawing.Size(146, 27);
            this.NewColumnDataButton.TabIndex = 16;
            this.NewColumnDataButton.Text = "Aggiungi colonna";
            this.NewColumnDataButton.UseVisualStyleBackColor = true;
            this.NewColumnDataButton.Click += new System.EventHandler(this.NewColumnDataButton_Click);
            // 
            // ColumnControlPanel
            // 
            this.ColumnControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnControlPanel.Location = new System.Drawing.Point(12, 206);
            this.ColumnControlPanel.Name = "ColumnControlPanel";
            this.ColumnControlPanel.Size = new System.Drawing.Size(708, 268);
            this.ColumnControlPanel.TabIndex = 17;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(603, 480);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(117, 37);
            this.ExecuteButton.TabIndex = 18;
            this.ExecuteButton.Text = "Elabora";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // WmraConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 523);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ColumnControlPanel);
            this.Controls.Add(this.NewColumnDataButton);
            this.Controls.Add(this.ColumnDataLabel);
            this.Controls.Add(this.FromRowUpDown);
            this.Controls.Add(this.FromRowLabel);
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
        private System.Windows.Forms.NumericUpDown FromRowUpDown;
        private System.Windows.Forms.Label FromRowLabel;
        private System.Windows.Forms.Label ColumnDataLabel;
        private System.Windows.Forms.Button NewColumnDataButton;
        private System.Windows.Forms.Panel ColumnControlPanel;
        private System.Windows.Forms.Button ExecuteButton;
    }
}

