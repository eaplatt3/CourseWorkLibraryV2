using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////////////////
// File: Submission.cs                                      //
//                                                          //
// Purpose: Contains the class definitions for Submission   //
//                                                          //
// Written By: Earl Platt III                               //
//                                                          //
// Compiler: Visual Studio 2019                             //
//                                                          //
//////////////////////////////////////////////////////////////

namespace CourseWorkLibraryV2
{
    [DataContract]
    public class Submission
    {
        #region Member Variables 
        //Member Variables 
        private string categoryName;
        private string assignmentName;
        private double grade;
        #endregion

        //Constructor 
        public Submission()
        {
            categoryName = "Homework";
            assignmentName = "Homework 2";
            grade = 90;
        }

        #region C# Properties
        //Using C# Properties with string
        [DataMember(Name = "categoryname")]
        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }

        [DataMember(Name = "assignmentname")]
        public string AssignmentName
        {
            get
            {
                return assignmentName;
            }

            set
            {
                assignmentName = value;
            }
        }

        //Using C# Properties with double 
        [DataMember(Name = "grade")]
        public double Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        #endregion

        #region Methods
        //***********************************************************
        // Method: Overrided ToString
        //
        // Purpose: To return categoryName, assignmentName & grade.
        //***********************************************************
        public override string ToString()
        {
            return categoryName.ToString() + "," + categoryName + "," + assignmentName + "," + grade;
        }

        #endregion
    }
}
