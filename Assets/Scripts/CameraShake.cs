using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private float maxXOffset;
    private float maxYOffset;
    private float maxZOffset;
    private float xOffset;
    private float yOffset;
    private float zOffset;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        maxXOffset = -200.0f;
        maxYOffset = 50.0f;
        maxZOffset = -50.0f;

        xOffset = Random.Range(0.0f, maxXOffset);
        yOffset = Random.Range(0.0f, maxYOffset);
        zOffset = Random.Range(0.0f, maxZOffset);

        transform.position = new Vector3(xOffset, yOffset, zOffset);

    }
}
