using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMRA_Core
{
    public class Core
    {
        #region Fields
        private readonly ConverterOptions _options;
        private Dictionary<CsvColumnType, List<String>> _cvsValues;
        #endregion

        public Core(ConverterOptions options)
        {
            _options = options;
        }

        #region Public Methods

        public void Process()
        {
            ReadCSVFile();
        }

        #endregion

        #region Private Methods

        private void ReadCSVFile()
        {
            _cvsValues = new Dictionary<CsvColumnType, List<String>>();

            foreach (var column in _options.Columns)
                _cvsValues.Add(column.Item2, new List<String>());

            var rowCounter = 0;

            using (var reader = new StreamReader(_options.InputFile))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    rowCounter++;

                    if (_options.FromRow > rowCounter)
                        continue;

                    var values = line.Split(new Char[] { ',', ';' });

                    foreach(var column in _options.Columns){
                        _cvsValues[column.Item2].Add(values[column.Item1 - 1]);
                    }
                }
            }

            _cvsValues.Count();
        }

        #endregion
    }
}
