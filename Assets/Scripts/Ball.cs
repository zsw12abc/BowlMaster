using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Ball : MonoBehaviour
{
    [SerializeField] private float launchSpeed;
    [SerializeField] private AudioSource audioSource;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        Launch();
    }

    public void Launch()
    {
        _rigidbody.velocity = new Vector3(0, 0, launchSpeed);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}