using System;
namespace CourseFantastic.Domain.Model {
	public class Bulletin {
        private SubjectDelivery _subjectDelivery;

        public SubjectDelivery SubjectDelivery
        {
            get { return _subjectDelivery; }
            set { _subjectDelivery = value; }
        }
        
        private DateTime _dateCreated;

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }
        private DateTime _publishDate;

        public DateTime PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _body;

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

		public Bulletin(DateTime publishDate, string title, string body):this(title,body) {
            PublishDate = publishDate;
		}
		public Bulletin(string title, string body) {
            Title = title;
            Body = body;
            DateCreated = DateTime.Now;
		}	

	}

}
