using System;
using WMRA_Core;

namespace WMRA_Converter
{
    public class TypeComboBoxItem
    {
        #region Properties
        public String Text { get; set; }

        public CsvColumnType Value { get; set; }

        #endregion
        
        public override string ToString()
        {
            return Text;
        }
    }
}