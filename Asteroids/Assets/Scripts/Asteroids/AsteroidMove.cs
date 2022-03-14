using UnityEngine;
using Zenject;

public class AsteroidMove : MonoBehaviour, IAsteroidMove, IPoolable<IMemoryPool>
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private float movementSpeed = 1f;

    IMemoryPool pool;

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

    public void OnSpawned(IMemoryPool pool)
    {
        this.pool = pool;
        gameObject.SetActive(false);
    }

    public void OnDespawned()
    {
        pool = null;
    }

    public class Factory : PlaceholderFactory<AsteroidMove>
    {
    }
}
