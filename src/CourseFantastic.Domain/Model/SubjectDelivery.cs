using System;
using System.Collections.Generic;
namespace CourseFantastic.Domain.Model
{
    public class SubjectDelivery
    {

        private int _numberOfSessions;

        public int NumberOfSessions
        {
            get { return _numberOfSessions; }
            set { _numberOfSessions = value; }
        }

        private string _subjectDeliveryId;

        public string SubjectId
        {
            get { return _subjectDeliveryId; }
            set { _subjectDeliveryId = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Version { get; set; }

        private List<AssessmentEvent> _assessments;

        public List<AssessmentEvent> Assessments
        {
            get { return _assessments; }
            set { _assessments = value; }
        }
        private List<Bulletin> _subjectNews;

        public List<Bulletin> SubjectNews
        {
            get { return _subjectNews; }
            set { _subjectNews = value; }
        }
        private CourseDelivery _courseDeatils;

        public CourseDelivery CourseDetails
        {
            get { return _courseDeatils; }
            set { _courseDeatils = value; }
        }
        private List<TimeTableItem> _sessions;

        public List<TimeTableItem> Sessions
        {
            get { return _sessions; }
            set { _sessions = value; }
        }
        private List<InstructorAssignment> _instructors;

        public List<InstructorAssignment> Instructors
        {
            get { return _instructors; }
            set { _instructors = value; }
        }


        public SubjectDelivery(string name, string description,  CourseDelivery courseDetails)
        {
            Name = name;
            Description = description;           
            CourseDetails = courseDetails;
            Sessions = new List<TimeTableItem>();
        }
        public SubjectDelivery(string name, string description, int numberOfSessions,CourseDelivery courseDetails, string location, DateTime sessionStart, DateTime sessionEnd)
            : this(name, description, courseDetails)
        {
            AddSessions(numberOfSessions, location, sessionStart, sessionEnd);
        }

        public List<TimeTableItem> AddSessions(int numberOfSessions, string location, DateTime sessionStart, DateTime sessionEnd)
        {
            //TODO: implement logic to add the TimeTableItems considering semesterDates
            for (int i = 0; i < numberOfSessions; i++)
            {
                Sessions.Add(new TimeTableItem(new TimePeriod(sessionStart, sessionEnd), location));
            }
            return Sessions;
        }


    }

}
