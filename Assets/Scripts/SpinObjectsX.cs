using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    public float spinSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
       // transform.Rotate(new Vector3(15, 20, 45) * Time.deltaTime);
    }
}
