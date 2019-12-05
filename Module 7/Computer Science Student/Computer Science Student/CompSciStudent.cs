using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    class CompSciStudent : Student
    {
        //constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        //fields
        private string _AcademicTrack;

        //constructor
        public CompSciStudent(string name, string id, string track) : base(name, id)
        {
            AcademicTrack = track;
        }

        //academictrack prop
        public string AcademicTrack { get; set; }

        //requiredHours property
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
