using System;
using System.Collections.Generic;
using System.Linq;
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
    class CourseWork
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
        public CourseWork(string Name, Category Categories, Assignment Assigments, Submission Submissions)
        {
            m_Name = Name;
        }

        #region C# Properties
        //Get & Set using C# properties 
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


    }
}
