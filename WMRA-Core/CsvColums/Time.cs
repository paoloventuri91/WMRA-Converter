using System;
using System.Globalization;

namespace WMRA_Core.CsvColums
{
    public class Time : ICsvColumn
    {
        #region Fields

        private TimeSpan _time = TimeSpan.MinValue;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _time == TimeSpan.MinValue ? String.Empty : _time.ToString("hh':'mm':'ss");
            set => _time = TimeSpan.ParseExact(value, "h':'mm':'ss", CultureInfo.InvariantCulture);
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
