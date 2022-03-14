using UnityEngine;
using Zenject;

public class PlayerShootingController : MonoBehaviour, IPlayerShootingController
{
    [Inject] private PlayerBullet.Factory pooler;

    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private float bulletSpeed = 10f;

    private float lastShot = 0.0f;

    public void Shoot(InputData data)
    {
        if (!data.IsShooting()) { return; }

        PlayerBullet bullet = pooler.Create();
        if (bullet == null) { return; }

        if ((Time.time > fireRate + lastShot))
        {
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;        

            bullet.gameObject.SetActive(true);

            var rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddRelativeForce(new Vector2(0, bulletSpeed));

            lastShot = Time.time;
        }
    }
}
