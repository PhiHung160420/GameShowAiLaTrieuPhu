using System;
using System.Collections.Generic;

namespace DTOpoj
{
    [Serializable()]
    public class CauHoi
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public List<string> DSCauTraLoi { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string Answer { get; set; }
        public CauHoi()
        {
            DSCauTraLoi = new List<string>();
        }
    }
}
