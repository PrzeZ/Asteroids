using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private float size = 1f;
    [SerializeField] private float minSize = 0.35f;
    [SerializeField] private float maxSize = 1.65f;
    [SerializeField] private float movementSpeed = 1f;

    private void OnEnable()
    {
        transform.eulerAngles = new Vector3(0f, 0f, Random.value * 360f);

        // Set the scale and mass of the asteroid based on the assigned size so
        // the physics is more realistic
        transform.localScale = Vector3.one * size;
        rigidbody.mass = size;
        SetTrajectory(new Vector2(Random.value, Random.value));

        //Add torque
        rigidbody.AddTorque(Random.Range(-10, 10));

    }

    public void SetTrajectory(Vector2 direction)
    {
        rigidbody.AddForce(direction * movementSpeed);
    }
}
