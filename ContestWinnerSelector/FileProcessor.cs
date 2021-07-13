using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContestWinnerSelector
{
    class FileProcessor
    {
        public static DirectoryInfo Directory { get; set; }
        string FileName { get; set; }
        List<WinnerModel> Participants = new List<WinnerModel>();
        List<WinnerModel> Winners = new List<WinnerModel>();

        public FileProcessor()
        { 
            
        }

        public static void SetDirectory(string input) => Directory = new DirectoryInfo(input);


    }
}
