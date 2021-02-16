using System;

namespace WMRA_Core.CsvColums
{
    public class LastName : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "Last Name";
        private const String NameConst = "Cognome";

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue { get; set; }

        public String Header => HeaderConst;
        public String Name => NameConst;

        #endregion
    }
}
