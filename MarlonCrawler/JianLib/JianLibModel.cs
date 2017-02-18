using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarlonCrawler.JianLib
{
    public class ResumeModel
    {


    }
    public class ResumeListResult
    {
        public string status { get; set; }
        public List<ResumeChiefModel> resumes { get; set; }
        public int current_page { get; set; }
        public int total { get; set; }

    }
    public class ResumeChiefModel
    {
        public string name { get; set; }
        public string lastTime { get; set; }
        public string expectCity { get; set; }
        public string jobYear { get; set; }
        public string education { get; set; }
        public string company { get; set; }
        public string id { get; set; }
        public string match { get; set; }
        public List<ResumeEduChiefModel> educations { get; set; }
        public string age { get; set; }
        public string sex { get; set; }
        public string jobState { get; set; }
        public string about { get; set; }
    }
    public class ResumeEduChiefModel
    {
        public int id { get; set; }
        public string startTime { get; set; }
        public int userId { get; set; }
        public string schoolName { get; set; }
        public string education { get; set; }
        public string endTime { get; set; }
        public string specialty { get; set; }
    }



}
