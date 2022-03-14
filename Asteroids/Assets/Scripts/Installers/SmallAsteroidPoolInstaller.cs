using UnityEngine;
using Zenject;

public class SmallAsteroidPoolInstaller : MonoInstaller
{
    [SerializeField] GameObject asteroid;
    public override void InstallBindings()
    {
        Container.BindFactory<AsteroidMove, AsteroidMove.Factory>()
         .WithId("SmallAsteroidPool")
         .FromPoolableMemoryPool<AsteroidMove, SmallAsteroidPool>(poolBinder => poolBinder
          .WithInitialSize(20)
          .FromComponentInNewPrefab(asteroid));
    }

    class SmallAsteroidPool : MonoPoolableMemoryPool<IMemoryPool, AsteroidMove>
    {
    }
}