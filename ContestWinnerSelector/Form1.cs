using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContestWinnerSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileLocationButton_Click(object sender, EventArgs e)
        {
            string _filePath = String.Empty;
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                _filePath = dialog.FileName;
                fileLocationBox.Text = _filePath;
            }
        }

        private void generateWinnersButton_Click(object sender, EventArgs e)
        {
            // verify that a path has been chosen
            // verify that a number of winners has been provided
            // injest the csv
            // randomly pick the number of winners
            // display the winners in the window
        }

        private void clearBoxesButton_Click(object sender, EventArgs e)
        {
            // clear out the path box
            fileLocationBox.Text = String.Empty;
            fileLocationBox.Refresh();

            // clear out the number of winners box
            numOfWinnersBox.Text = String.Empty;
            numOfWinnersBox.Refresh();

            // clear out the winners box
            winnersBox.Items.Clear();
            winnersBox.Refresh();
        }
    }
}
