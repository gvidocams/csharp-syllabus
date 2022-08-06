using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Student : IStudent
    {
        List<string> testsTaken;

        public Student()
        {
            this.testsTaken = new List<string>();
        }

        public List<string> TestsTaken()
        {
            if (testsTaken.Count == 0)
            {
                return new List<string> { "No tests taken" };
            }
            else
            {
                return testsTaken;
            }
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            string[] correctAnswers = paper.MarkScheme();
            int correctAnswerCount = 0;
            
            for(int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == correctAnswers[i])
                {
                    correctAnswerCount++;
                }
            }

            int testPercentage = (int)((double)correctAnswerCount / (double)correctAnswers.Length * 100);
            string result = testPercentage >= paper.PassMark() ? "Passed!" : "Failed!";

            string test = $"{paper.Subject()}: {result} ({testPercentage}%)";

            testsTaken.Add(test);
        }
    }
}
