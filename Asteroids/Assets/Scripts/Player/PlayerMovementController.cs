using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour , IPlayerMovementController
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private float thrustSpeed = 1f;
    [SerializeField] private float rotationSpeed = 0.5f;

    public void Move(InputData inputData)
    {
        Vector2 move = inputData.GetMove();
        rigidbody.AddRelativeForce(new Vector2(0, move.x * thrustSpeed));
        rigidbody.AddTorque(move.y);
    }
}
