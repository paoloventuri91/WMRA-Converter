using System;
using System.Globalization;

namespace WMRA_Core.CsvColums
{
    public class Time : ICsvColumn, IComparable
    {
        #region Fields

        private TimeSpan TimeValue { get; set; }

        #endregion
        
        #region Properties
        
        public String RawValue
        {
            get => TimeValue == TimeSpan.MaxValue ? String.Empty : TimeValue.ToString("hh':'mm':'ss");
            set => TimeValue = TimeSpan.TryParse(value, out var parsedValue) ? parsedValue : TimeSpan.MaxValue;
        }

        #endregion

        #region Public Methods

        public Int32 CompareTo(Object obj)
        {
            var timeObj = (Time)obj;

            if (TimeValue < timeObj.TimeValue)
                return -1;

            if (TimeValue > timeObj.TimeValue)
                return 1;

            return 0;
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
