using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectEulerTests
{
    public class Answers
    {
        public Dictionary<long, long> answerDictionary;

        public Answers(string filepath)
        {
            answerDictionary = new Dictionary<long, long>();

            // Read data from file
            System.IO.StreamReader file =new System.IO.StreamReader(filepath);

            string line;

            // Add data to dict
            while ((line = file.ReadLine()) != null)
            {
                string [] splitLine = line.Split('.');
                long key = Convert.ToInt64(splitLine[0]);
                long value = Convert.ToInt64(splitLine[1].Trim(' '));
                answerDictionary.Add(key, value);
            }
        }

        public Dictionary<long, long> GetAll()
        {
            return answerDictionary;
        }
    }
}
