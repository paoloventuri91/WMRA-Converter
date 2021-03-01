using System;

namespace WMRA_Core.CsvColums
{
    public class LastName : ICsvColumn
    {
        #region Fields

        private String _lastName;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _lastName;
            set => _lastName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());

        }

        #endregion
    }
}
