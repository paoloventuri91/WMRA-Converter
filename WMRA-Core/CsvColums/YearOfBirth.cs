using System;

namespace WMRA_Core.CsvColums
{
    public class YearOfBirth : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "YOB";
        private const String NameConst = "Anno di nascita";

        private Int32 _year = DateTime.MinValue.Year;

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue
        {
            get => _year.ToString();
            set => _year = Convert.ToInt32(value);
        }

        public String Header => HeaderConst;
        
        public String Name => NameConst;

        #endregion

        #region Overidden Methods

        public override string ToString()
        {
            return RawValue;
        }

        #endregion
    }
}
