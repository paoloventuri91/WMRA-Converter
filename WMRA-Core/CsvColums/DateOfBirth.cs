using System;
using System.Globalization;

namespace WMRA_Core.CsvColums
{
    public class DateOfBirth : ICsvColumn
    {
        #region Properties

        public DateTime Date { get; set; } = DateTime.MinValue;
        
        public String RawValue
        {
            get => Date.ToString("dd/MM/yyyy");
            set => Date = DateTime.Parse(value);
        }
        
        #endregion

        #region Overidden Methods

        public override string ToString()
        {
            return RawValue;
        }

        #endregion
    }
}
