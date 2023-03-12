using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public string Place { set; get; }
        public string Date { set; get; }
        public string Time { set; get; }
        public byte Category { set; get; }
        public IEnumerable<Category> Categories { set; get; }
        public DateTime GetDateTime()
        { 
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}