using System.IO;
using System.Windows.Forms;

namespace WMRA_Converter
{
    public partial class WmraConverter : Form
    {
        #region Fields

        private readonly ConverterOptions _options;

        #endregion

        public WmraConverter()
        {
            InitializeComponent();
            _options = new ConverterOptions();
        }

        private void LoadScreenOptions()
        {
            FileSelectionTextBox.Text = _options.InputFile;
            FileExportTextBox.Text = _options.OutputFile;
        }

        private void FileSelectionButton_Click(object sender, System.EventArgs e)
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

        private void FileExportButton_Click(object sender, System.EventArgs e)
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

        private void SaveOptionsButton_Click(object sender, System.EventArgs e)
        {
            _options.Save();
        }

        private void LoadOptionsButton_Click(object sender, System.EventArgs e)
        {
            _options.Load();
            LoadScreenOptions();
        }
    }
}
