using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog
{ 
    public string name;
    public int age;
    public Color color;
    public float height;
    public float weight;
    public bool gender; // true represent male and false represent female
    

    public Dog(string newName, int newAge, Color newColor, float newHeight, float newWeight, bool newGender)
    {
        name = newName;
        age = newAge;
        color = newColor;
        height = newHeight;
        weight = newWeight;
        gender = newGender;
    }
}
