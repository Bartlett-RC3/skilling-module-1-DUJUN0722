using System;
using UnityEngine;

namespace DogsWorld
{
    public class dog : MonoBehaviour
    {

        // Properties
        string dogType;
        string dogGender;
        int dogAge;
        float dogHeight;
        float dogWeight;


        // Construction
        public dog(string _dogType, string _dogGender, int _dogAge, float _dogHeight, float _dogWeight)
        {
            dogType = _dogType;
            dogGender = _dogGender;
            dogAge = _dogAge;
            dogHeight = _dogHeight;
            dogWeight = _dogWeight;
        }


        // Function
        public string GetDogType()
        {
            return dogType;
        }
        public string GetDogGender()
        {
            return dogGender;
        }
        public int GetDogAge()
        {
            return dogAge;
        }
        public float GetDogHeight()
        {
            return dogHeight;
        }
        public float GetDogWeight()
        {
            return dogWeight;
        }

    }
}
