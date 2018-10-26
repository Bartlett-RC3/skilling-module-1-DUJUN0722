using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DogsWorld;

public class Session2Homework : MonoBehaviour {
    
    public int count = 10; 
    public int a = 10;
    public int b = 20;
	
	void Start () {

        // HOMEWORK i: if Condition

        if (a > b)
        {
            Debug.Log("Integer a is bigger than integer b.");
        }
        else if (a == b)
        {
            Debug.Log("Integer a is equal to integer b.");
        }
        else
        {
            Debug.Log("Integer a is smaller than integer b.");
        }

        // HOMEWORK i': shorthand conditions

        int c = (a < b) ? 1 : 2;

        // HOMEWORK ii: for loop

        for (int i = 0; i < count; i++)
        {
            Debug.Log("This is no.{1}" + i);
        }

        // HOMEWORK iii: about dog class

        dog myDog = new dog("Corgi", "Male", 5, 18.2f, 8.9f);

        Debug.Log("The dog's type is" + myDog.GetDogType());
        Debug.Log("The dog's gender is" + myDog.GetDogGender());
        Debug.Log("The dog's age is" + myDog.GetDogAge());
        Debug.Log("The dog's height is" + myDog.GetDogHeight());
        Debug.Log("The dog's weight is" + myDog.GetDogWeight());

    }
}
