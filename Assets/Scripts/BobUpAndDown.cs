using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobUpAndDown : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.up * ((Mathf.Sin(Time.time) + 1.0f) * 0.5f);
    }
}