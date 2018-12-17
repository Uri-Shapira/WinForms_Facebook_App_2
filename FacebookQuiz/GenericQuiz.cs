using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookQuiz
{
    class GenericQuiz : AbstractQuiz
    {


        public GenericQuiz() : base()
        {
        }
        
     
        public override void BuildQuiz()
        {
            Question q1 = new Question("Berlin is the capital of which country?", new string[] { "Belgium", "Netherlands", "Germany"}, 2);
            Question q2 = new Question("Which is the longest river in the world?", new string[] { "Amazon", "Nile", "Mississipi"}, 1);
            Question q3 = new Question("What language do most people in Austria speak?", new string[] { "German", "Austrian", "Hungarian"}, 0);
            Question q4 = new Question("Which country is closer to the North Pole?", new string[] { "Finland", "China", "North Korea"}, 0);
            Question q5 = new Question("On the “polar” opposite end of the world, which animal lives in Antarctica?", new string[] { "Polar Bear", "Penguins", "Reindeer"}, 1);
            Questions.Add(q1);
            Questions.Add(q2);
            Questions.Add(q3);
            Questions.Add(q4);
            Questions.Add(q5);

        }
    }
}
