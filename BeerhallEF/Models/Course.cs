using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    public class Course
    {
        #region Properties
        public string Title { get; set; }

        public int CourseId { get; private set; }
        public int? Credits { get; set; }
        public Language Language { get; set; }


        #endregion
        #region Navigational Properties
        public Brewer Brewer { get; set; } // wegens bi-directionele associatie
        #endregion

        #region Constructors
        protected Course()
        {
        }

        public Course(string title, Brewer brewer, Language language)
        {
            Title = title;
            Brewer = brewer;
            Language = language;
        }
        #endregion
    }
}
