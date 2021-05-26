using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingCalculator
    {
        public int CalculateScore(string sequence)
        {
            int totalScore = 0;

            int currentFrameScore = 0;
            int currentFrameCount = 0;
            int currentFrameNo = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                var currentSymbol = sequence[i];
                currentSymbol = currentSymbol == '-' ? '0' : currentSymbol;

                if (char.IsDigit(currentSymbol))
                {
                    currentFrameScore += int.Parse(currentSymbol.ToString());
                    currentFrameCount++;

                    if (currentFrameCount == 2)
                    {
                        totalScore += currentFrameScore;
                        currentFrameScore = 0;
                        currentFrameCount = 0;
                        currentFrameNo++;
                    }

                    continue;
                }

                if (currentSymbol == '/')
                {
                    var nextSymbol = sequence[i + 1];
                    if(char.IsDigit(nextSymbol))
                    {
                        totalScore += 10 + int.Parse(nextSymbol.ToString());
                    }
                     //TOD array overlow test case
                    if(nextSymbol == 'X')
                    {
                        totalScore += 10 + 10;
                    }
                        
                    currentFrameScore = 0;
                    currentFrameCount = 0;
                    currentFrameNo++;
                }

                if (currentSymbol == 'X')
                {
                    if (currentFrameNo < 10)
                    {
                        var sub = sequence.Substring(i, 2);
                        if (sub == "XX")
                        {
                            totalScore += 30;
                        }

                        currentFrameScore = 0;
                        currentFrameCount = 0;
                        currentFrameNo++;
                    }


                }

            }



            return totalScore;
        }
    }
}
