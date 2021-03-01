using System;

namespace WMRA_Core.CsvColums
{
    public class MaidenName : ICsvColumn
    {
        #region Fields

        private String _maidenName;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _maidenName;
            set => _maidenName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());

        }

        #endregion
    }
}
