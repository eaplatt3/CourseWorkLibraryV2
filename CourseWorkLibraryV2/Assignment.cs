﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////////////////
// File: Assignment.cs                                      //
//                                                          //
// Purpose: Contains the class definitions for Assignment   //
//                                                          //
// Written By: Earl Platt III                               //
//                                                          //
// Compiler: Visual Studio 2019                             //
//                                                          //
//////////////////////////////////////////////////////////////

namespace CourseWorkLibraryV2
{
    [DataContract]
    public class Assignment
    {
        #region Member Variables 
        //Member Variables 
        private string name;
        private string description;
        private string categoryName;
        #endregion

        //*****************************************************
        // Method: Assigment Constructor
        //
        // Purpose: To Create Object 
        //*****************************************************
        public Assignment()
        {
            name = "Homework 2";
            description = "Create the submission class. " +
                "Add serialization to all classes.";
            categoryName = "Homework";
        }

        #region C# Properties
        //Get & Set using C# properties 
        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;

            }
        }

        [DataMember(Name = "description")]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }

        }

        [DataMember(Name = "catergoryname")]
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
        #endregion

        #region Methods
        //*****************************************************
        // Method: Overrided ToString
        //
        // Purpose: To return Name, Description & Percentage.
        //*****************************************************
        public override string ToString()
        {
            return Name.ToString() + ", " + Description  + CategoryName;
        }
        #endregion
    }
}
