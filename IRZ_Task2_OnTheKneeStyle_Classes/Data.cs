using System;

namespace IRZ_Task2_OnTheKneeStyle_Classes
{
    [Serializable]
    //I agree with you. It is terrible name.
    public class Data
    {
        public DateTime CreationDate;
        public string Title;
        public string Author;
        public string Answered;
        public string Link;

        public Data(DateTime creationDate, string title, string author, string answered, string link)
        {
            CreationDate = creationDate;
            Title = title;
            Author = author;
            Answered = answered;
            Link = link;
        }
        public Data() { }
    }
}