using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDestroy : MonoBehaviour
{
    void Update()
    {
        
        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);

        RaycastHit objectInFront;
        
        if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))
        {
            string objectInFrontName = objectInFront.transform.name;
            Destroy(objectInFront.transform.gameObject);
        }
    }
}
