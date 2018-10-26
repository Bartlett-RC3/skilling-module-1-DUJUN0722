using System;
using UnityEngine;
namespace RC3Students
{

    public class RC3Student : MonoBehaviour
    {
        
        public string FirstName;
        private string MiddleName;
        public string LastName;

        private int age;
        private string HomeCountry;


        // Constructor
        public RC3Student(string _FirstName, string _MiddleName, string _LastName, int _age, string _HomeCountry)
        {
            FirstName = _FirstName;
            MiddleName = _MiddleName;
            LastName = _LastName;
            age = _age;

        }

        // Functions


        public string GetStudentName()
        {
            return FirstName + LastName;
        }
    }




}
