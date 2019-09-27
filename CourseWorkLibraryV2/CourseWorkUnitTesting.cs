using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////////////////////////////////////
// File: CourseWorkUnitTesting.cs                                      //
//                                                                     //
// Purpose: Contains the class definitions for CourseWorkUnitTesting   //
//                                                                     //
// Written By: Earl Platt III                                          //
//                                                                     //
// Compiler: Visual Studio 2019                                        //
//                                                                     //
/////////////////////////////////////////////////////////////////////////

namespace CourseWorkLibraryV2
{
    //Class Created for testing
    public class CourseWorkUnitTesting
    {
        #region Methods
        //*****************************************************
        // Method: UnitTestCategory
        //
        // Purpose: To Check if Name & Percentage is Called.
        //*****************************************************
        public void UnitTestCategory()
        {

            Category c = new Category();
            string sTestName = "bill";
            double dTestPercentage = 50.5;
            c.Name = sTestName;

            //Test if Name is being Called
            if (c.Name == sTestName)
            {
                Console.WriteLine("Category Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Category Name Property: Fail");
            }

            c.Percentage = dTestPercentage;

            //Test if Percentage is being Called
            if(c.Percentage == dTestPercentage)
            {
                Console.WriteLine("Category Percentage Property: Pass");
            }
            else
            {
                Console.WriteLine("Category Percentage Property: Fail");
            }

        }

        //*******************************************************************
        // Method: UnitTestAssigment
        //
        // Purpose: To Check if Name, Description & CategoryName is Called.
        //********************************************************************
        public void UnitTestAssignment()
        {
            Assignment a = new Assignment();

            string sTestName = "Mary";
            string sTestDescription = "There is a Description";
            string sTestCategoryName = "Name of Category";

            a.Name = sTestName;

            //Test if Name is being Called
            if(a.Name == sTestName)
            {
                Console.WriteLine("Assigment Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Assigment Name Property: Fail");
            }

            a.Description = sTestDescription;

            //Test is Description is being called
            if(a.Description == sTestDescription)
            {
                Console.WriteLine("Assigment Description Property: Pass");
            }
            else
            {
                Console.WriteLine("Assigment Description Property: Fail");
            }

            a.CategoryName = sTestCategoryName;

            //Checks if CategoryName is being called
            if(a.CategoryName == sTestCategoryName)
            {
                Console.WriteLine("Assigment CategoryName Property: Pass");
            }
            else
            {
                Console.WriteLine("Assigment CategoryName Property: Fail");
            }

        }
        #endregion
        
    }
}
