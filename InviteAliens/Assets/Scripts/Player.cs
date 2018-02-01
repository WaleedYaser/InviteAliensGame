using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10f;

    float _verticalSpeed = .1f;
    float _horizontalSpeed = .1f;


    Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();

        if (!_rigidbody)
        {
            _rigidbody = gameObject.AddComponent<Rigidbody>();
            _rigidbody.useGravity = false; 
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(speed * Time.fixedDeltaTime,
            _verticalSpeed * Input.GetAxis("Mouse Y"), 0, ForceMode.VelocityChange);

    }
}
