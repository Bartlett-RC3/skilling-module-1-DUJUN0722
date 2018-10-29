using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3_Joe : MonoBehaviour
{
    public GameObject cubePrefab;
    public int spacingX = 10;
    public int spacingZ = 10;
    public int x = 10;
    public int z = 10;
    public int gridX = 10;
    public int gridZ = 10;



    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                Instantiate(cubePrefab, new Vector3(x * spacingX, 0.0f, z * spacingZ), Quaternion.identity, this.transform);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        // TIME
        Debug.Log("This computer can render a frame in:" + Time.deltaTime);
        Debug.Log("Since I started playing the game this amout of time has passed:" + Time.timeSinceLevelLoad);
        Debug.Log("Computer has counted this amount of frames:" + Time.frameCount);

        // TRANSLATION
        // MOVE CHILDREN GAMEOBJECTS IN X AXIS
        foreach (Transform child in this.transform)
        {
            child.Translate(0, Random.Range(-1f, 1f), 0);
        }

        // ROTATION
        // ROTATION CHILDREN GAMEOBJECTS AROUND Y AXIS

        //foreach (Transform child in this.transform)
        //{
        //    child.Rotate(0, Random.value * 10, 0);
        //}

        foreach (Transform child in this.transform)
        {
            child.RotateAroundLocal(Vector3.up, Random.value);
        }

        // SCALE

        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(0.5f, 2), Random.Range(0.5f, 2), Random.Range(0.5f, 2));
        }

        Vector3[] originalScale = new Vector3[this.transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {

            originalScale[i] = transform.GetChild(i).localScale;
        }

        // KEYBORAD INPUT
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If I have pressed space
            // Record the cubes orginal scale

            foreach(Transform child in this.transform)
            {
                child.localScale = child.localScale * 10f;
            }

        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localScale = originalScale[i];
            }
        }

        // MOUSE PRESSED (0 LEFT 1 RIGHT 2 MIDDLE)
        // if (Input.GetMouseButton)
    

    }
}
