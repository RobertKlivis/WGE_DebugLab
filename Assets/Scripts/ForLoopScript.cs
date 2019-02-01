using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopScript : MonoBehaviour {

    // start for loop 
    public void ExecuteLoop()
    {
        Debug.Log(this);
        int x = 0;

        System.Diagnostics.Stopwatch stopwatch =
            new System.Diagnostics.Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 500; i++)
        {
            x += i;
        }
        stopwatch.Stop();
        Debug.Log("Time taken: " + (stopwatch.Elapsed));
    }
}