using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // HOMEWORK i, ii, iii
        int myInt = 123;
        float myFloat = 123.123f;
        string myName = "JUN";

        // HOMEWORK iv
        Debug.Log(myInt);
        Debug.Log(myFloat);
        Debug.Log(myName);

        // HOMEWORK v
        int[] myArray = { 1, 2, 3, 4, 5 };
        Debug.Log(myArray);

        // HOMEWORK vi
        List<double> myList = new List<double>();
        myList.Add(1.11);
        myList.Add(2.22);
        Debug.Log(myList);

        // HOMEWORK vii
        Dictionary<string, string> myDictionary = new Dictionary<string, string>;
        myDictionary.Add("sweet", "chocolate");
        myDictionary.Add("sweet", "sugar");
        myDictionary.Add("spicy", "chili");
        myDictionary.Add("spicy", "garlic");

        if (myDictionary.ContainsKey("sweet")) 
        {
            Debug.Log("The sweet food is" + myDictionary.Values);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
