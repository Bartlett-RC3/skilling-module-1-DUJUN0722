using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogConsoler : MonoBehaviour
{
   
    void Start()
    {
        Dog dog1 = new Dog("Huskey", 5, Color.black, 12.1f, 15.5f, true);
        Dog dog2 = new Dog("Corgi", 3, Color.white, 3.5f, 2.2f, false);
        Dog dog3 = new Dog("Bulldog", 7, Color.black, 7.8f, 9.2f, true);


        Debug.Log("The dog1 name is " + dog1.name + ", age " + dog1.age + ", color " + dog1.color
            + ", height " + dog1.height + ", weight " + dog1.weight + ", is male = " + dog1.gender);

        Debug.Log("The dog2 name is " + dog2.name + ", age " + dog2.age + ", color " + dog2.color
           + ", height " + dog2.height + ", weight " + dog2.weight + ", is male = " + dog2.gender);

        Debug.Log("The dog3 name is " + dog3.name + ", age " + dog3.age + ", color " + dog3.color
           + ", height " + dog3.height + ", weight " + dog3.weight + ", is male = " + dog3.gender);
    }


}
