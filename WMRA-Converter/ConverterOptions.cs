using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;  

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

        #endregion

        public ConverterOptions()
        {
            InputFile = String.Empty;
            OutputFile = String.Empty;
            FromSheetNumber = 1;
            ToSheetNumber = 1;
            FromRow = 1;
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
        }
        
        #endregion
        
    }
}