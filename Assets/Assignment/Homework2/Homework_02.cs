using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework_02 : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _length = 3;

    private List<GameObject> prefabList = new List<GameObject>();

    void Start()
    {

    }

    void Update()
    {
        CreatePrefabRandomly();
        ClearAll();
    }

    private void CreatePrefabRandomly()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _length; j++)
                {
                    for (int k = 0; k < _length; k++)
                    {
                        float random = Random.Range(0.0f, 10.0f);
                        GameObject prefab = Instantiate(_prefab, new Vector3(i * random, j * random, k * random), Quaternion.identity);
                        prefabList.Add(prefab);
                    }
                }
            }
        }
    }

    private void ClearAll()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (var i in prefabList)
            {
                Destroy(i);
            }

            prefabList.Clear();
        }
    }


}
