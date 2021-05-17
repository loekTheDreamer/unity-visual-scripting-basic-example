using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
        void Update ()
    {
        transform.Rotate(0, 0, Time.deltaTime * 10, Space.Self);
        Debug.Log(transform.localEulerAngles.z);
    }
}
