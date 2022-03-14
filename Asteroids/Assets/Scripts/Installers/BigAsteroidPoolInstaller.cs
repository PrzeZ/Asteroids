using UnityEngine;
using Zenject;

public class BigAsteroidPoolInstaller : MonoInstaller
{
    [SerializeField] GameObject asteroid;
    public override void InstallBindings()
    {
        Container.BindFactory<AsteroidMove, AsteroidMove.Factory>()
            .WithId("BigAsteroidPool")
            .FromPoolableMemoryPool<AsteroidMove, BigAsteroidPool>(poolBinder => poolBinder
              .WithInitialSize(20)
              .FromComponentInNewPrefab(asteroid));
    }
    class BigAsteroidPool : MonoPoolableMemoryPool<IMemoryPool, AsteroidMove>
    {
    }
}