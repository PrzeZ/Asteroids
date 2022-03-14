using UnityEngine;
using Zenject;

public class AsteroidPoolInstaller : MonoInstaller
{
    [SerializeField] GameObject asteroid;

    public override void InstallBindings()
    {
        Container.BindFactory<AsteroidMove, AsteroidMove.Factory>()
            .FromPoolableMemoryPool<AsteroidMove, AsteroidPool>(poolBinder => poolBinder
                .WithInitialSize(20)
                .FromComponentInNewPrefab(asteroid));
    }

    class AsteroidPool : MonoPoolableMemoryPool<IMemoryPool, AsteroidMove>
    {
    }
}