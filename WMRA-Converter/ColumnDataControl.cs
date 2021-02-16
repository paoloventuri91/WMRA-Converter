using System;
using System.Linq;
using System.Windows.Forms;
using WMRA_Core;

namespace WMRA_Converter
{
    public partial class ColumnDataControl : UserControl
    {
        #region Properties

        public Int32 Column { get; set; }

        public CsvColumnType Type { get; set; }

        #endregion
        
        public ColumnDataControl(Int32 column, CsvColumnType type)
        {
            InitializeComponent();
            AddComboValues();

            Column = column;
            Type = type;
            ColumnUpDown.Value = column;

            if (type != null)
            {                
                TypeComboBox.SelectedIndex = TypeComboBox.FindStringExact(type.ToString().Replace("_", " "));
            }            
        }

        #region Private Methods

        private void AddComboValues()
        {
            foreach (CsvColumnType type in Enum.GetValues(typeof(CsvColumnType)))
            {
                TypeComboBox.Items.Add(new TypeComboBoxItem
                {
                    Text = type.ToString().Replace("_", " "),
                    Value = type
                }); ;
            }
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            var parent = (WmraConverter)Parent.Parent;
            parent.RemoveColumnDataControl(this);
        }

        private void ColumnUpDown_ValueChanged(object sender, EventArgs e)
        {
            Column = Convert.ToInt32(ColumnUpDown.Value);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var typeItem = (TypeComboBoxItem) TypeComboBox.SelectedItem;
            Type = typeItem.Value;
        }

        #endregion
    }
}