using System;
namespace CourseFantastic.Domain.Model
{
    public class InstructorAssignment
    {
        public Boolean IsActive
        {
            get
            {
                return Subject.CourseDetails.DeliveryPeriod.End >= DateTime.Now;
            }
        }
        private InstructorAssignmentRole _role;

        public InstructorAssignmentRole Role
        {
            get { return _role; }
            set { _role = value; }
        }
        private SubjectDelivery _subject;

        public SubjectDelivery Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private Teacher _instructor;

        public Teacher Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }
        public InstructorAssignment(Instructor teacher, SubjectDelivery subject)
        {
            Instructor = teacher as Teacher;
            Subject = subject;
            Role = InstructorAssignmentRole.All;

        }

        public InstructorAssignment(Instructor teacher, SubjectDelivery subject, InstructorAssignmentRole role)
            : this(teacher, subject)
        {
            Role = role;
        }

    }

}
