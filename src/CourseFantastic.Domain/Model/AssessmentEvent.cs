using System;
namespace CourseFantastic.Domain.Model
{
    public class AssessmentEvent
    {
        /// <summary>
        /// either due date or assessment date depending on the assessment type
        /// i.e. Portfolio type would have startDate, endDate while Exam may only have date
        /// </summary>
        /// 

        private TimePeriod _timePeriod;
        public TimePeriod TimePeriod
        {
            get
            {
                return _timePeriod;
            }
            set
            {
                _timePeriod = value;
            }
        }
        private AssessmentType _type;
        public AssessmentType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        private SubjectDelivery _subject;
        public SubjectDelivery Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        private DateTime _briefingDate;
        public DateTime BriefingDate
        {
            get
            {
                return _briefingDate;
            }

            set
            {
                _briefingDate = value;
            }
        }
        private string _location;
        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }


        public AssessmentEvent(AssessmentType type, string location, SubjectDelivery subject)
        {
            Type = type;
            Location = location;
            Subject = subject;
        }
        public AssessmentEvent(AssessmentType type, string location, SubjectDelivery subject, DateTime briefingDate)
            : this(type, location, subject)
        {
            BriefingDate = briefingDate;
        }
        public AssessmentEvent(AssessmentType type, string location, SubjectDelivery subject, DateTime startDate, DateTime endDate)
            : this(type, location, subject)
        {
            TimePeriod = new TimePeriod(startDate, endDate);
        }

    }

}
