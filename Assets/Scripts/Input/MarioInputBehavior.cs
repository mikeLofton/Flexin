using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioInputBehavior : MonoBehaviour
{
    private MarioMovementBehavior _marioMove;

    private void Awake()
    {
        _marioMove = GetComponent<MarioMovementBehavior>();
    }

    private void Update()
    {
        _marioMove.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }
}
