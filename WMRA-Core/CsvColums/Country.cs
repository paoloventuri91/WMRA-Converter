using System;

namespace WMRA_Core.CsvColums
{
    public class Country : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "Country";
        private const String NameConst = "Nazionalità";

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue { get; set; }

        public String Header => HeaderConst;

        public String Name => NameConst;

        #endregion
    }
}
