using System;

namespace WMRA_Core.CsvColums
{
    public class Position : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "Position";
        private const String NameConst = "Posizione";

        private Int32 _position = Int32.MinValue;

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue
        {
            get => _position.ToString();
            set => _position = Convert.ToInt32(value);
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
