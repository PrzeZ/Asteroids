using UnityEngine;

public class AsteroidMove : MonoBehaviour, IAsteroidMove
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private float movementSpeed = 1f;

    private void OnEnable()
    {
        SetTrajectory(Random.insideUnitCircle.normalized);

        //Add torque
        rigidbody.AddTorque(Random.Range(-10, 10));

    }

    public void SetTrajectory(Vector2 direction)
    {
        rigidbody.AddForce(direction * movementSpeed);
    }
}
