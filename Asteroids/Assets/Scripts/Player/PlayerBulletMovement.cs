using UnityEngine;
using Zenject;

public class PlayerBulletMovement : MonoBehaviour, IPoolable<IMemoryPool>
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float bulletSpeed = 10f;

    IMemoryPool pool;

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    public void OnSpawned(IMemoryPool pool)
    {
        rb.AddRelativeForce(new Vector2(0, bulletSpeed));
    }

    public void OnDespawned()
    {

    }

    public class Factory : PlaceholderFactory<PlayerBullet>
    {
    }
}
