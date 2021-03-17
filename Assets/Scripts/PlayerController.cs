using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField]
    float xRange = 10f;
    Controller controller;

    private void Start()
    {
        controller = GameObject.Find("InputController").GetComponent<Controller>();
    }


    void Update()
    {
        var current = transform.position;
        current.x = Utility.Math.Map(controller.GetInput().x, -1f, 1f, -xRange, xRange);
        transform.position = current;
    }
}
