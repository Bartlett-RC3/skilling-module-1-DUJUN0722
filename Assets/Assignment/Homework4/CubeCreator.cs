using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    [SerializeField] private int _size = 10;
    [SerializeField] private GameObject _prefab;

    void Start()
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                Instantiate(_prefab, new Vector3(i * 2, 0.5f, j * 2), Quaternion.identity, this.transform);
            }
        }
    }
}
