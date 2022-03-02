using UnityEngine;

public class PlayerShootingController : MonoBehaviour, IPlayerShootingController
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private ObjectPooler pooler;

    [SerializeField] private float fireRate = 1f;

    private float lastShot = 0.0f;

    public void Shoot()
    {
        GameObject bullet = pooler.GetPooledObject();
        if (bullet == null) { return; }

        if ((Time.time > fireRate + lastShot))
        {
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true);

            lastShot = Time.time;
        }
    }
}
