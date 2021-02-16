using System;
using System.Globalization;

namespace WMRA_Core.CsvColums
{
    public class DateOfBirth : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "DOB";
        private const String NameConst = "Data di nascita";

        private DateTime _date = DateTime.MinValue;

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue
        {
            get => _date.ToString("dd/MM/yyyy");
            set => _date = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
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
