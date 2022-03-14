using UnityEngine;
using Zenject;

public class BulletPoolInstaller : MonoInstaller
{
    [SerializeField] GameObject bullet;
    public override void InstallBindings()
    {
        Container.BindFactory<PlayerBullet, PlayerBullet.Factory>()
            // We could just use FromMonoPoolableMemoryPool here instead, but
            // for IL2CPP to work we need our pool class to be used explicitly here
            .FromPoolableMemoryPool<PlayerBullet, BulletPool>(poolBinder => poolBinder
                // Spawn 20 right off the bat so that we don't incur spikes at runtime
                .WithInitialSize(20)
                // Bullets are simple enough that we don't need to make a subcontainer for them
                // The logic can all just be in one class
                .FromComponentInNewPrefab(bullet)
                .UnderTransformGroup("Bullets"));
    }

    class BulletPool : MonoPoolableMemoryPool<IMemoryPool, PlayerBullet>
    {
    }
}