using System;

namespace WMRA_Core.CsvColums
{
    public class Position : ICsvColumn
    {
        #region Fields

        private Int32 _position = Int32.MinValue;

        #endregion

        #region Properties

        public String RawValue
        {
            get => _position.ToString();
            set => _position = Convert.ToInt32(value);
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
