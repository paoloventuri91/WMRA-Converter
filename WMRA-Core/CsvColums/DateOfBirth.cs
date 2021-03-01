using System;
using System.Globalization;

namespace WMRA_Core.CsvColums
{
    public class DateOfBirth : ICsvColumn
    {
        #region Fields

        private DateTime _date = DateTime.MinValue;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _date.ToString("dd/MM/yyyy");
            set => _date = DateTime.Parse(value);
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
