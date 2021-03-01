using System;
using WMRA_Core.CsvColums;

namespace WMRA_Core
{
    public class OutputRow
    {
        #region Properties

        public LastName LastName { get; set; } = new LastName();
        public FirstName FirstName { get; set; } = new FirstName();
        public MaidenName MaidenName { get; set; } = new MaidenName();
        public DateOfBirth DateOfBirth { get; set; } = new DateOfBirth();
        public YearOfBirth YearOfBirth { get; set; } = new YearOfBirth();
        public Country Country { get; set; } = new Country();
        public Category Category { get; set; } = new Category();
        public Position Position { get; set; } = new Position();
        public Time Time { get; set; } = new Time();

        #endregion

        #region Public Methods

        public void AddColumn(CsvColumnType type, String value)
        {
            switch (type)
            {
                case CsvColumnType._:
                    break;

                case CsvColumnType.Categoria:
                    Category = new Category {RawValue = value};
                    break;

                case CsvColumnType.Nazione:
                    Country = new Country { RawValue = value };
                    break;

                case CsvColumnType.Data_di_nascita:
                    DateOfBirth = new DateOfBirth { RawValue = value };
                    break;

                case CsvColumnType.Nome:
                    FirstName = new FirstName { RawValue = value };
                    break;

                case CsvColumnType.Cognome:
                    LastName = new LastName { RawValue = value };
                    break;

                case CsvColumnType.Nome_da_nubile:
                    MaidenName = new MaidenName { RawValue = value };
                    break;

                case CsvColumnType.Posizione:
                    Position = new Position { RawValue = value };
                    break;

                case CsvColumnType.Tempo:
                    Time = new Time { RawValue = value };
                    break;

                case CsvColumnType.Anno_di_nascita:
                    YearOfBirth = new YearOfBirth { RawValue = value };
                    break;
            }
        }

        public String GetHeader()
        {
            return "Last Name,First Name,Maiden Name,DOB,YOB,Country,Category,Position,Time";
        }

        #endregion

        #region Overridden Methods

        public override string ToString()
        {
            return $"{LastName.RawValue},{FirstName.RawValue},{MaidenName.RawValue},{DateOfBirth.RawValue},{YearOfBirth.RawValue},{Country.RawValue},{Category.RawValue},{Position.RawValue},{Time.RawValue}";
        }

        #endregion

        
    }
}
