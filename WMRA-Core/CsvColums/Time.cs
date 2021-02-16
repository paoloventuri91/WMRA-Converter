using System;
using System.Globalization;

namespace WMRA_Core.CsvColums
{
    public class Time : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "Time";
        private const String NameConst = "Tempo";

        private TimeSpan _time = TimeSpan.MinValue;

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue
        {
            get => _time.ToString("HH:mm:ss");
            set => _time = TimeSpan.ParseExact(value, "HH:mm:ss", CultureInfo.InvariantCulture);
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
