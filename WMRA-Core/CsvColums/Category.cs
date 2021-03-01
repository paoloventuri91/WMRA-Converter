using System;

namespace WMRA_Core.CsvColums
{
    public class Category : ICsvColumn
    {
        #region Fields

        private CategoryEnum _categoryEnum = CategoryEnum.None;


        #endregion

        #region Properties
        
        public String RawValue
        {
            get => _categoryEnum.ToString();
            set => _categoryEnum = ParseCategory(value);
        }

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
                case "F":
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
