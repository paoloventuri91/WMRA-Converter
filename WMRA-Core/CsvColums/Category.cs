using System;

namespace WMRA_Core.CsvColums
{
    public class Category : ICsvColumn, IOutputColumn
    {
        #region Fields

        private const String HeaderConst = "Category";
        private const String NameConst = "Categoria";

        private CategoryEnum _categoryEnum = CategoryEnum.None;

        #endregion

        #region Properties

        public Int32 ColumnIndex { get; set; }

        public String RawValue
        {
            get => _categoryEnum.ToString().ToUpper();
            set => _categoryEnum = ParseCategory(value);
        }
        
        public String Header => HeaderConst;

        public String Name => NameConst;

        #endregion

        #region Private Methods

        private static CategoryEnum ParseCategory(String value)
        {
            switch (value.ToUpper())
            {
                case "MEN":
                case "M":
                    return CategoryEnum.Men;

                case "WOMEN":
                case "W":
                    return CategoryEnum.Women;

                default:
                    return CategoryEnum.None;
            }
        }

        #endregion
    }

    internal enum CategoryEnum
    {
        None,
        Men,
        Women
    }
}
