using UnityEngine;
using Zenject;

public class MediumAsteroidPoolInstaller : MonoInstaller
{
    [SerializeField] GameObject asteroid;
    public override void InstallBindings()
    {
        Container.BindFactory<AsteroidMove, AsteroidMove.Factory>()
            .WithId("MediumAsteroidPool")
            .FromPoolableMemoryPool<AsteroidMove, MediumAsteroidPool>(poolBinder => poolBinder
                .WithInitialSize(20)
                .FromComponentInNewPrefab(asteroid));
    }
    class MediumAsteroidPool : MonoPoolableMemoryPool<IMemoryPool, AsteroidMove>
    {
    }
}