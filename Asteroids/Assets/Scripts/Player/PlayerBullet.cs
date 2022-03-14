using UnityEngine;
using Zenject;

public class PlayerBullet : MonoBehaviour, IPoolable<IMemoryPool>
{
    IMemoryPool pool;

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
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

    public class Factory : PlaceholderFactory<PlayerBullet>
    {
    }
}
