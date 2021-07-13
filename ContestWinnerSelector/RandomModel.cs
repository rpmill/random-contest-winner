using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestWinnerSelector
{
    class RandomModel
    {
        private static readonly Random _random = new Random();

        public static List<int> RandomNumberGenerator(int min, int max, int numOfNums)
        {
            List<int> _randomList = new List<int>();

            for (int i = 1; i < numOfNums + 1; i++)
            {
                int _newRandom = _random.Next(min, max);
                bool isInList = _randomList.IndexOf(_newRandom) != -1;

                while (isInList)
                {
                    _newRandom = _random.Next(min, max);
                    isInList = _randomList.IndexOf(_newRandom) != -1;
                    if (!isInList)
                    {
                        break;
                    }
                }

                _randomList.Add(_newRandom);

            }

            return _randomList;
        }
    }
}
