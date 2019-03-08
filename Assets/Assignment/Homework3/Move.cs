using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField][Range(-80.0f, 100.0f)] private float _range = 40.0f;
    [SerializeField][Range(0.0f, 10.0f)] private float _speed;

    void Update()
    {
        Check();
        this.transform.Translate(_speed , 0.0f, 0.0f);
    }

    private void Check()
    {
        if (this.transform.position.x > _range)
        {
            this.transform.position = new Vector3(-80.0f, -15.0f, 0.0f);
        }
    }

}
