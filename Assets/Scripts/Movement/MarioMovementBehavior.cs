using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _jumpPower;
    private Rigidbody _rigid;
    private Vector3 _moveDirection;
    private bool _isGrounded;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 velocity = MoveDirection * _speed * Time.fixedDeltaTime;
        _rigid.MovePosition(transform.position + velocity);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigid.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _isGrounded = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _isGrounded = true;
    }
}
