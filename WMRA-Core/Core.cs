using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WMRA_Core.CsvColums;

namespace WMRA_Core
{
    public class Core
    {
        #region Fields
        private readonly ConverterOptions _options;
        private List<OutputRow> _outputRows;
        #endregion

        public Core(ConverterOptions options)
        {
            _options = options;
        }

        #region Public Methods

        public void Process()
        {
            ReadCsvFile();
            AdjustData();
            ExportCsv();
        }
        
        #endregion

        #region Private Methods

        private void ReadCsvFile()
        {
            _outputRows = new List<OutputRow>();
            var rowCounter = 0;

            using (var reader = new StreamReader(_options.InputFile))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    rowCounter++;

                    if (_options.FromRow > rowCounter)
                        continue;

                    if (line == null)
                        continue;

                    var outputRow = new OutputRow();
                    var values = line.Split(',', ';');

                    foreach(var column in _options.Columns)
                        outputRow.AddColumn(column.Item2, values[column.Item1 - 1]);

                    _outputRows.Add(outputRow);
                }
            }
        }

        private void ExportCsv()
        {
            using (var writetext = new StreamWriter(_options.OutputFile))
            {
                writetext.WriteLine(new OutputRow().GetHeader());

                foreach (var outputRow in _outputRows)
                {
                    writetext.WriteLine(outputRow);
                }
            }
        }

        private void AdjustData()
        {
            _outputRows = _outputRows.OrderBy(o => o.Time).ToList();
            
            var position = 1;
            foreach (var outputRow in _outputRows)
            {
                outputRow.Position = new Position(position);
                position++;
            }
        }

        #endregion
    }
}
