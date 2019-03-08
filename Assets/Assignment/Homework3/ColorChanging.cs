using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    private void OnMouseEnter()
    {
        this.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

}
