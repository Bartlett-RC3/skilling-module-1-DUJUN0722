using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3Students;

public class Session2_JUN : MonoBehaviour
{

    int number1 = 10;
    int number2 = 20;
    int number3 = 30;

    bool someBool = false;
    string someName = "name";
    string[] tutorNames = { "Dave", "Tyson", "Jordi", "Octavian", "Panos" };

    List<RC3Student> RC2018 = new List<RC3Student>();



    // Use this for initialization
    void Start()
    {

        RC3Student Bangrui = new RC3Student("Bangrui", "Null", "Chen", 24, "China");

        Debug.Log(Bangrui.GetStudentName());


        Debug.Log("A tutor is:" + tutorNames[0]);
        Debug.Log("A tutor is:" + tutorNames[1]);
        Debug.Log("A tutor is:" + tutorNames[2]);

        // Navigate date
        // For loop variable that count start, where it ends, waht is the incerment
        for (int i = 0; i <= tutorNames.Length -1; i++)
        {
            Debug.Log("A tutor is: " + tutorNames[i]);

        }

        for (int counter = 0; counter <= number2; counter++)
        {
            Debug.Log("Counting..." + counter);
        }

        // For each loop

        foreach(string tutorName in tutorNames)
        {
            Debug.Log(tutorName);
        }
        
        





        // Conditions
        if (number1 < number2)
        {// Question
            Debug.Log("Number1 is smaller than number2");
        }
        else
        {
            Debug.Log("Number2 is smaller than number1");
        }
        // Question we can ask
        // If something is smaller or bigger
        // <,>

        // If something is equal to something else
        // ==

        // Asking multiple question
        if (number1 < number2 && someBool == true)
        {

            Debug.Log("Answer to both questions is yes.");
        }

        if (number1 < number2)
        {
            if (someBool == true)
            {
                Debug.Log("Answer to both questions is yes.");
            }
        }

        if (number1 < number2 || someBool == true)
        {
            Debug.Log("One of the questions is true.");
        }

        // Complex question by conconcatenation and by embedding sub question
        if ((number1 < number2 && someBool == true) && (someBool == true && someName == "name"))
        {
            Debug.Log("This is too confusing! Simply please!");

        }

        // Shorthand if

        number3 = (number1 < number2) ? 100 : 200;


    }

    // Update is called once per frame
    void Update()
    {

    }
}
