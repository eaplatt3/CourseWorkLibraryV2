using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////////////////
// File: CourseWork.cs                                      //
//                                                          //
// Purpose: Contains the class definitions for CourseWork   //
//                                                          //
// Written By: Earl Platt III                               //
//                                                          //
// Compiler: Visual Studio 2019                             //
//                                                          //
//////////////////////////////////////////////////////////////


namespace CourseWorkLibraryV2
{
    [DataContract] 
    public class CourseWork
    {
        #region Member Variables 
        //Member Variables
        string m_Name;
        List<Category> categories;
        List<Assignment> assignments;
        List<Submission> submissions;
        #endregion

        //*****************************************************
        // Method: CourseWork Constructor
        //
        // Purpose: To Create Object 
        //*****************************************************
        public CourseWork()
        {
            m_Name = Name;
            categories = new List<Category>();
            assignments = new List<Assignment>();
            submissions = new List<Submission>();
        }

        #region C# Properties
        //Get & Set using C# properties 
        [DataMember(Name = "Name")]
        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;

            }
        }

        [DataMember(Name = "Catergories")]
        public List<Category> Categories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
            }
        }

        [DataMember(Name = "Assignments")]
        public List<Assignment> Assigments
        {
            get
            {
                return assignments;
            }

            set
            {
                assignments = value;
            }
        }

        [DataMember(Name = "Submission")]
        public List<Submission> Submissions
        {
            get
            {
                return submissions;
            }

            set
            {
                submissions = value;
            }
        }

        #endregion

        #region Methods
        //*****************************************************
        // Method: FindSubmission
        //
        // Purpose: To return a submission by name
        //*****************************************************
        public Submission FindSubmission(string s)
        {
            Submission sub = new Submission();

            for(int i = 0; i < submissions.Count(); i++)
            {
                if (submissions[i].AssignmentName == s)
                {
                    sub.AssignmentName = submissions[i].AssignmentName;
                    sub.CategoryName = submissions[i].CategoryName;
                    sub.Grade = submissions[i].Grade;
                }
            }
            return sub;
        }

        //*****************************************************
        // Method: CalculateGrade
        //
        // Purpose: To Calculate Grade Based on weight
        //*****************************************************
        public double CalculateGrade(double grade)
        {
            double testGrade = 0;
            double hwGrade = 0;
            double quizGrade = 0;
            double labGrade = 0;
            int testCtn = 0;
            int hwCtn = 0;
            int quizCtn = 0;
            int labCtn = 0;
            
            for(int i = 0; i < submissions.Count(); i++)
            {
                if(submissions[i].CategoryName == "Exams")
                {
                    testGrade += submissions[i].Grade;
                    testCtn++;
                }

                if(submissions[i].CategoryName == "Homework")
                {
                    hwGrade += submissions[i].Grade;
                    hwCtn++;
                }

                if(submissions[i].CategoryName == "Quizzes")
                {
                    quizGrade += submissions[i].Grade;
                    quizCtn++;
                }

                if(submissions[i].CategoryName == "Labs")
                {
                    labGrade += submissions[i].Grade;
                    labCtn++;
                }
            }

            testGrade = testGrade / testCtn;
            hwGrade = hwGrade / hwCtn;
            quizGrade = quizGrade / quizCtn;
            labGrade = labGrade / labCtn;

            grade = testGrade + hwGrade + quizGrade + labGrade;

            return grade;
        }

        //***********************************************************
        // Method: Overrided ToString
        //
        // Purpose: To return categoryName, assignmentName & grade.
        //***********************************************************

        public override string ToString()
        {
            return m_Name.ToString() + " , " + categories + " , " + assignments + " , " + submissions;
        }


        #endregion
    }
}
