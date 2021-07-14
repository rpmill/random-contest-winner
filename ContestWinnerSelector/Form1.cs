using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string _filePath = String.Empty;
        int _numberOfWinners = 0;
        int _minRange = 0;
        int _maxRange;
        List<int> _randomNumbers = new List<int>();
        List<string> _winnerList = new List<string>();
        List<string> _contestants = new List<string>();
        private void fileLocationButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                _filePath = dialog.FileName;
                fileLocationBox.Text = _filePath;
            }
        }

        private void generateWinnersButton_Click(object sender, EventArgs e)
        {
            bool isEntryError = false;

            // verify that a path has been chosen and that a number of winners has been provided
            if (String.IsNullOrEmpty(_filePath))
            {
                isEntryError = true;
                MessageBox.Show("A valid filename is required.");
            }
            else if (String.IsNullOrEmpty(numOfWinnersBox.Text))
            {
                isEntryError = true;
                MessageBox.Show("A valid number of winners is required.");
            }
            else if (!String.IsNullOrEmpty(numOfWinnersBox.Text))
            {
                int _parse;

                if (int.TryParse(numOfWinnersBox.Text, out _parse) && _parse > 0)
                {
                    _numberOfWinners = _parse;
                }
                else
                {
                    isEntryError = true;
                    MessageBox.Show("A whole integer greater than 0 is required for number of winners.");
                }
            }

            if (!isEntryError)
            {
                // injest the csv
                _contestants = GetListFromFile(_filePath);
                _maxRange = GetMaxRangeFromList(_contestants);

                // check if the number of winners desired is greater than the total number of contestants
                if (_numberOfWinners > _maxRange)
                {
                    isEntryError = true;
                    MessageBox.Show("You selected more winners than available contestants.");
                }

                if (!isEntryError)
                {
                    // randomly pick the number of winners
                    _randomNumbers = RandomModel.RandomNumberGenerator(_minRange, _maxRange, _numberOfWinners);
                    _winnerList = GetWinnerList(_contestants, _randomNumbers);

                    // display the winners in the window
                    foreach (var winner in _winnerList)
                    {
                        winnersBox.Items.Add(winner);
                    }
                    winnersBox.Refresh();
                }

            }            

        }

        private void clearBoxesButton_Click(object sender, EventArgs e)
        {
            ClearFileName();
            ClearNumOfWinners();
            ClearWinnersBox();
        }

        private List<string> GetListFromFile(string input)
        {
            List<string> _list = new List<string>();

            using (var reader = new StreamReader(input))
            {
                string line = String.Empty;
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    _list.Add(line);
                }
            }

            return _list;
        }

        private int GetMaxRangeFromList(List<string> input)
        {
            int _range = -1;

            if (input.Count > 0)
            {
                _range = input.Count;
            }
            else
            {
                MessageBox.Show("The selected file is empty.");
            }

            return _range;
        }

        private List<string> GetWinnerList(List<string> contestants, List<int> randoms)
        {
            List<string> output = new List<string>();

            foreach (int i in randoms)
            {
                output.Add(contestants[i]);
            }

            return output;
        }

        private void clearWinnersButton_Click(object sender, EventArgs e)
        {
            ClearNumOfWinners();
            ClearWinnersBox();
        }

        private void ClearFileName()
        {
            // clear out the path box
            fileLocationBox.Text = String.Empty;
            fileLocationBox.Refresh();
        }

        private void ClearNumOfWinners()
        {
            // clear out the number of winners box
            numOfWinnersBox.Text = String.Empty;
            numOfWinnersBox.Refresh();
        }

        private void ClearWinnersBox()
        {
            // clear out the winners box
            winnersBox.Items.Clear();
            winnersBox.Refresh();
        }

        private void clearWinnersBoxButton_Click(object sender, EventArgs e)
        {
            ClearWinnersBox();
        }
    }
}
