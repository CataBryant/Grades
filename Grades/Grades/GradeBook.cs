using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Gradebook
    {
        
        public Gradebook()
        {
            grades = new List<float>();
        }
        private List<float> grades;
        public GradeStatistic ComputerStatistic()
        {
            GradeStatistic stats = new GradeStatistic();
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AvgGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

    }
