using System;

namespace WMRA_Core.CsvColums
{
    public class YearOfBirth : ICsvColumn
    {
        #region Fields
        
        private Int32 _year = DateTime.MinValue.Year;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _year.ToString();
            set => _year = Convert.ToInt32(value);
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
