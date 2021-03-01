using System;

namespace WMRA_Core.CsvColums
{
    public class FirstName : ICsvColumn
    {
        #region Fields

        private String _firstName;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _firstName;
            set => _firstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());

        }

        #endregion
    }
}
