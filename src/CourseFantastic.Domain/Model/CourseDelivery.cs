using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseFantastic.Domain.Model
{
    public class CourseDelivery
    {
        private ISemesterDates _semesterDates;

        public ISemesterDates SemesterDates
        {
            get { return _semesterDates; }
            set { _semesterDates = value; }
        }


        private Course _course;

        public Course Course
        {
            get { return _course; }
            set { _course = value; }
        }


        private string _callOccCode;


        public string CallOccCode
        {
            get { return _callOccCode; }
            set { _callOccCode = value; }
        }
       
        private string _version;

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }
        private College _college;

        public College College
        {
            get { return _college; }
            set { _college = value; }
        }
        private TimePeriod _deliveryPeriod;

        public TimePeriod DeliveryPeriod
        {
            get { return _deliveryPeriod; }
            set { _deliveryPeriod = value; }
        }
        private List<SubjectDelivery> _subjects;

        public List<SubjectDelivery> Subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }


       
        public CourseDelivery(Course course, College college, DateTime startDate, DateTime endDate)
        {
            Course = course;
            College = college;
            Version = VersionControl.GetInstance().GetNextMajor();
            DeliveryPeriod.Start = startDate;
            DeliveryPeriod.End = endDate;

        }
        public CourseDelivery(Course course, College college, string callOccCode, DateTime startDate, DateTime endDate)
            : this(course, college, startDate, endDate)
        {
            CallOccCode = callOccCode;
        }
        public CourseDelivery(Course course, College college, string callOccCode, ISemesterDates semester)
            : this(course, college, semester.Dates["termOneStart"], semester.Dates["termTwoEnd"])
        {
            CallOccCode = callOccCode;
        }
        public CourseDelivery(Course course, College college, string callOccCode, DateTime startDate, DateTime endDate, List<SubjectDelivery> subjects)
            : this(course, college, callOccCode, startDate, endDate)
        {
            Subjects = subjects;
        }

        public CourseDelivery(string courseName, string courseDescription, College college, string callOccCode, DateTime startDate, DateTime endDate)
            : this(new Course(courseName, courseDescription), college, callOccCode, startDate, endDate)
        {

        }
        public CourseDelivery(Qualification qualification, string courseDescription, College college, string callOccCode, ISemesterDates semester)
            : this(new Course(courseDescription, qualification), college, callOccCode, semester)
        {

        }




        public SubjectDelivery AddSubjectDelivery(String name, string description, CourseDelivery courseDelivery)
        {
            if (this.Subjects.Select(s => s.Name).Contains(name, StringComparer.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Subject with the same name already exists");
            }

            var subject = new SubjectDelivery(name, description, courseDelivery);
            Subjects.Add(subject);
            return subject;
        }

        public List<SubjectDelivery> AddSubjectDelivery(String name, string description, int numberOfSessions, CourseDelivery courseDelivery, string location, DateTime sessionStart, DateTime sessionEnd)
        {
            var subject = AddSubjectDelivery(name, description, courseDelivery);
            subject.AddSessions(numberOfSessions, location, sessionStart, sessionEnd);
            return Subjects;

        }

    }

}
