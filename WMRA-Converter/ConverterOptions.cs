using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using WMRA_Core;

namespace WMRA_Converter
{
    public class ConverterOptions
    {
        #region Properties

        public String InputFile { get; set; }

        public String OutputFile { get; set; }

        public Int32 FromSheetNumber { get; set; }

        public Int32 ToSheetNumber { get; set; }

        public Int32 FromRow { get; set; }

        public List<Tuple<Int32, CsvColumnType>> Columns { get; set; }

        #endregion

        public ConverterOptions()
        {
            InputFile = String.Empty;
            OutputFile = String.Empty;
            FromSheetNumber = 1;
            ToSheetNumber = 1;
            FromRow = 1;
            Columns = new List<Tuple<Int32, CsvColumnType>>();
        }

        #region Public Methods

        public void Save()
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(saveFileDialog1.FileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this);
            }
        }

        public void Load()
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath),
                Filter = @"JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (file.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var value = File.ReadAllText(file.FileName);
                var loadOptions = JsonConvert.DeserializeObject<ConverterOptions>(value);

                foreach (var property in typeof(ConverterOptions).GetProperties().Where(p => p.CanWrite))
                    property.SetValue(this, property.GetValue(loadOptions, null), null);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void CheckOptions()
        {
            if(ToSheetNumber < FromSheetNumber)
                throw new Exception("Il foglio finale non può essere minore di quello iniziale");

            foreach (var column in Columns)
            {
                if(column.Item2 == CsvColumnType._)
                    throw new Exception($"Tipologia vuota per la colonna {column.Item1}");

                if (Columns.Count(c => c.Item1 == column.Item1) > 1)
                    throw new Exception($"Più tipologie indicate per la colonna {column.Item1}");

                if (Columns.Count(c => c.Item2 == column.Item2) > 1)
                {
                    throw new Exception($"La tipologia '{column.Item2}' è indicata in più colonne diverse");
                }
            }
        }
        
        #endregion
        
    }
}