using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1_JUN : MonoBehaviour
{



    // Numbers

    // Scope---Type---Name---Value
    int myInteger = 145;
    int largestInteger = int.MaxValue;
    int smallestIntger = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    float myFloat = 32.456f;

    // Text

    string myString = "This is the new awesome RC3! Better than ever";

    // Logical

    bool boolens = true;
    bool falseboolens = false;

    // 2.Data structures
    // Scope -- Type --Value (can take in many values)

    // Array

    //int[] myIntArray = { 1, 2, 3, 4, 5 };
    int[] twentyElementsArray = new int[5] {1,2,3,4,5};

    int[,] xyArray = new int[4, 5];

    double[] doubleArray = { 1.02, 11.33, 345, 32.55 };

    // List
    //内容只能加在list的最后一个
    //myList.Clear 可以删除

    List<int> myList = new List<int>();
    


    // Dictionary

    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();


    // 3.Function


    float NumberAddition(float a, float b)
    {
        return a + b;

    }

    void PointSomeNumbers()
    {


    }



    // Use this for initialization
    void Start()
    {
        myIntArray[2] = 300;

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Number addition function
    // Scope -- Type -- Variables -- Body(Instructions)

    

}
