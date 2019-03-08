using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_01 : MonoBehaviour
{
    private int i = 1;
    private float j = 1.5f;
    private string k = "Jun Du";

    private int[] integerArray = { 0, 1, 2 };
    private List<TeamMate> teamMateList = new List<TeamMate>();
    private Dictionary<string, int> integerDictionary = new Dictionary<string, int>();

    private void Awake()
    {
        teamMateList.Add(new TeamMate("Yuki", 24));
        teamMateList.Add(new TeamMate("Hua", 24));
        teamMateList.Add(new TeamMate("George", 25));

        integerDictionary.Add("a", 0);
        integerDictionary.Add("b", 1);
        integerDictionary.Add("c", 2);
    }

    void Start()
    {
        Debug.Log($"The integer is " + i
            + ", the float is " + j
            + ", the string is " + k);

        foreach (KeyValuePair<string, int> pair in integerDictionary)
        {
            Debug.Log(pair.Key + " " + pair.Value);
        }

        foreach (TeamMate i in teamMateList)
        {
            Debug.Log(i.name + " " + i.age);
        }
    }
}
