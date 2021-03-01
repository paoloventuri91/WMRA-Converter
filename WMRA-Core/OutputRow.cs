using System;
using WMRA_Core.CsvColums;

namespace WMRA_Core
{
    public class OutputRow
    {
        #region Properties

        private LastName LastName { get; set; } = new LastName();
        private FirstName FirstName { get; set; } = new FirstName();
        private MaidenName MaidenName { get; set; } = new MaidenName();
        private DateOfBirth DateOfBirth { get; set; } = new DateOfBirth();
        private YearOfBirth YearOfBirth { get; set; } = new YearOfBirth();
        private Country Country { get; set; } = new Country();
        private Category Category { get; set; } = new Category();
        private Position Position { get; set; } = new Position();
        private Time Time { get; set; } = new Time();

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
