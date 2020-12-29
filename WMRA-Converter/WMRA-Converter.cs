using System.IO;
using System.Windows.Forms;

namespace WMRA_Converter
{
    public partial class WmraConverter : Form
    {
        #region Fields

        private ConverterOptions _options;

        #endregion

        public WmraConverter()
        {
            InitializeComponent();
            _options = new ConverterOptions();
        }

        private void FileSelectionButton_Click(object sender, System.EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath)
            };

            if (file.ShowDialog() != DialogResult.OK)
                return;

            _options.InputFile = file.FileName;
            FileSelectionTextBox.Text = _options.InputFile;
        }
    }
}
