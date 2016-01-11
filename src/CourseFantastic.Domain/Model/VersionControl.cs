using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFantastic.Domain.Model
{
    class VersionControl
    {
        private static VersionControl _versionControl;
        private VersionControl()
        { }

        public static VersionControl GetInstance()
        {
            if (_versionControl == null)
            {
                _versionControl = new VersionControl();
            }
            return _versionControl;
        }

        public string GetNextMajor()
        {
            return null;
        }
        public string GetNextMinor()
        {
            return null;
        }

    }
}
