using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistic
    {
        public GradeStatistic()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float HighestGrade;
        public float LowestGrade;
        public float AvgGrade;
    }
}
