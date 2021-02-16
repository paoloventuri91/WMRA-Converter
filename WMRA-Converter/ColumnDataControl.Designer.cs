namespace WMRA_Converter
{
    partial class ColumnDataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColumnUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnUpDown
            // 
            this.ColumnUpDown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnUpDown.Location = new System.Drawing.Point(60, 3);
            this.ColumnUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnUpDown.Name = "ColumnUpDown";
            this.ColumnUpDown.Size = new System.Drawing.Size(68, 23);
            this.ColumnUpDown.TabIndex = 0;
            this.ColumnUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnUpDown.ValueChanged += new System.EventHandler(this.ColumnUpDown_ValueChanged);
            // 
            // TypeComboBoxItem
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(219, 3);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(208, 23);
            this.TypeComboBox.Sorted = true;
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnLabel.Location = new System.Drawing.Point(3, 6);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(51, 15);
            this.ColumnLabel.TabIndex = 2;
            this.ColumnLabel.Text = "Colonna";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(158, 6);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(55, 15);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Tipologia";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(446, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(58, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Elimina";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ColumnDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.ColumnUpDown);
            this.Name = "ColumnDataControl";
            this.Size = new System.Drawing.Size(505, 33);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ColumnUpDown;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}
