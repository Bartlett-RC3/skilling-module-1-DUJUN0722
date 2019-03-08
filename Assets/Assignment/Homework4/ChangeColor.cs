using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    #region api
    //// In this example we show how to invoke a coroutine and
    //// continue executing the function in parallel.

    //private IEnumerator coroutine;

    //void Start()
    //{
    //    // - After 0 seconds, prints "Starting 0.0"
    //    // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
    //    // - After 2 seconds, prints "WaitAndPrint 2.0"
    //    print("Starting " + Time.time);

    //    // Start function WaitAndPrint as a coroutine.

    //    coroutine = WaitAndPrint(2.0f);
    //    StartCoroutine(coroutine);

    //    print("Before WaitAndPrint Finishes " + Time.time);
    //}

    //// every 2 seconds perform the print()
    //private IEnumerator WaitAndPrint(float waitTime)
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(waitTime);
    //        print("WaitAndPrint " + Time.time);
    //    }
    //}

    #endregion

    private IEnumerator colorChangingCoroutine;


    void Start()
    {
        colorChangingCoroutine = IChangeColor();
        StartCoroutine(colorChangingCoroutine);

    }

    private IEnumerator IChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            this.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
