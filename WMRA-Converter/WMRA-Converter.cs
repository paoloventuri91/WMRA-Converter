using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using WMRA_Core;

namespace WMRA_Converter
{
    public partial class WmraConverter : Form
    {
        #region Const
        private const Int32 ColumnDataControlHeigth = 35;
        #endregion

        #region Fields
        private readonly ConverterOptions _options;
        private readonly List<ColumnDataControl> _columnDataControls;
        private Int32 _columnCounter = 1;
        #endregion

        public WmraConverter()
        {
            InitializeComponent();
            ColumnControlPanel.AutoScroll = false;
            ColumnControlPanel.HorizontalScroll.Enabled = false;
            ColumnControlPanel.HorizontalScroll.Visible = false;
            ColumnControlPanel.HorizontalScroll.Maximum = 0;
            ColumnControlPanel.AutoScroll = true;
            _options = new ConverterOptions();
            _columnDataControls = new List<ColumnDataControl>();
        }

        private void LoadScreenOptions()
        {
            FileSelectionTextBox.Text = _options.InputFile;
            FileExportTextBox.Text = _options.OutputFile;
            FromRowUpDown.Value = _options.FromRow;

            _columnCounter = 1;

            _columnDataControls.RemoveAll(c => true);

            foreach (var columnDataControl in ColumnControlPanel.Controls.OfType<ColumnDataControl>())
                ColumnControlPanel.Controls.Remove(columnDataControl);
                        
            foreach (var optionsColumn in _options.Columns)
                AddColumnDataControl(optionsColumn.Item1, optionsColumn.Item2);
        }

        private void FileSelectionButton_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath),
                Filter = @"CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (file.ShowDialog() != DialogResult.OK)
                return;

            _options.InputFile = file.FileName;
            LoadScreenOptions();
        }

        private void FileExportButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            _options.OutputFile = saveFileDialog1.FileName;
            LoadScreenOptions();
        }

        private void SaveOptionsButton_Click(object sender, EventArgs e)
        {
            GetOptions();                       
            _options.Save();
        }

        private void LoadColumnOptions()
        {
            _options.Columns = new List<Tuple<Int32, CsvColumnType>>();

            foreach (var columnDataControl in _columnDataControls)
            {
                _options.Columns.Add(new Tuple<Int32, CsvColumnType>(columnDataControl.Column, columnDataControl.Type));
            }
        }

        private void GetOptions()
        {
            try
            {
                LoadColumnOptions();
                _options.CheckOptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void LoadOptionsButton_Click(object sender, EventArgs e)
        {
            _options.Load();
            LoadScreenOptions();
        }

        private void FromRowUpDown_ValueChanged(object sender, EventArgs e)
        {
            _options.FromRow = Convert.ToInt32(FromRowUpDown.Value);
        }

        private void NewColumnDataButton_Click(object sender, EventArgs e)
        {
            AddColumnDataControl();
        }

        private void AddColumnDataControl(Int32 column = 1, CsvColumnType type = CsvColumnType._)
        {
            var columnDataControl = new ColumnDataControl(column, type)
            {
                Location = new Point(0, ColumnDataControlHeigth * _columnDataControls.Count),
                Visible = true,
                Name = "cdc_" + _columnCounter
            };

            _columnCounter++;
            ColumnControlPanel.Controls.Add(columnDataControl);
            _columnDataControls.Add(columnDataControl);
        }

        public void RemoveColumnDataControl(ColumnDataControl sender)
        {
            ColumnControlPanel.Controls.Remove(sender);
            _columnDataControls.Remove(sender);
            var index = Int32.Parse(sender.Name.Split('_')[1]);

            foreach (var columnDataControl in ColumnControlPanel.Controls.OfType<ColumnDataControl>())
            {
                var controlIndex = Int32.Parse(columnDataControl.Name.Split('_')[1]);
                if (controlIndex <= index)
                    continue;

                columnDataControl.Top -= ColumnDataControlHeigth;
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            GetOptions();
            Core core = new Core(_options);
            core.Process();
        }
    }
}
