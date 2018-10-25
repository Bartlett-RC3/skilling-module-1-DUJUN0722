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
        Debug.Log(myArray[0]);

        // HOMEWORK vi
        List<double> myList = new List<double>();
        myList.Add(1.11);
        myList.Add(2.22);
        Debug.Log(myList[0]);

        // HOMEWORK vii
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "a");
        myDictionary.Add(2, "b");
        myDictionary.Add(3, "c");

        if (myDictionary.ContainsKey(1)) 
        {
            Debug.Log("The first letter is" + myDictionary.Values);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
