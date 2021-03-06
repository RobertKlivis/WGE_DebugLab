﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCubeScript : MonoBehaviour {

    public GameObject _cube;
    public Vector3 _leftPosition;
    public Vector3 _rightPosition;

    public void StartLerp()
    {
        _cube.transform.position = _leftPosition;
        StartCoroutine(LerpCube());
    }

    IEnumerator LerpCube()
    {
        float t = 0;

        while (t < 1.4)
        {
            t += Time.deltaTime;
            Debug.Log(t);
            _cube.transform.position = _cube.transform.position - (_leftPosition - _rightPosition) * t * Time.deltaTime;
            if(t >=1.4)
            {
                _cube.transform.position = _rightPosition;
            }
            yield return null;
        }
    }

    //inseert code here:

    public void PrintDebugString()
    {
        Debug.Log(this.ToString());

    }

    public override string ToString()
    {

        string s;

        s = (_cube ? "Cube position = " + _cube.transform.position
            : "Cube not instantiated ") + "\n"
            + "Left Position = " + _leftPosition + "\n"
            + "Right Position = " + _rightPosition;

        return s;
    }

}
