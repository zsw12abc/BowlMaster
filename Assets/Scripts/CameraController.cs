using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Ball ball;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 1829f) //in front of head pin
        {
            transform.position = ball.transform.position + _offset;
        }
    }
}