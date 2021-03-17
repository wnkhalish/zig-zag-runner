using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    [SerializeField][Range(0,1)] float LerpSpeed = .2f;

    Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, LerpSpeed);
    }
}
