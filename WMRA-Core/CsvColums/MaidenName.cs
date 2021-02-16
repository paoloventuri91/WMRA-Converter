using System;

namespace WMRA_Core.CsvColums
{
    public class MaidenName : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "Maiden Name";
        private const String NameConst = "Nome da nubile";

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue { get; set; }

        public String Header => HeaderConst;

        public String Name => NameConst;

        #endregion
    }
}
