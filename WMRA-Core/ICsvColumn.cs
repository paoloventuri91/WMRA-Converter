using System;

namespace WMRA_Core
{
    public interface ICsvColumn
    {
        #region Properties

        Int32 ColumnIndex { get; set; }

        String RawValue { get; set; }

        String Name { get; }
        
        #endregion
    }
}
