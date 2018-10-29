using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour {

    
    public float speed = 0.1f;
    public Material color;

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        float offset = Time.time * speed;
        Debug.Log(offset);
        transform.Translate(offset, 0.0f, 0.0f);

        if (Input.GetMouseButton(0))
        {
            color.color = new Color(Random.value, Random.value, Random.value);
        }
	}
}
