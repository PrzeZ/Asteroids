using UnityEngine;
using Zenject;

public class PlayerShootingControllerInstaller : MonoInstaller
{
    [SerializeField] PlayerShootingController playerShootingController;

    public override void InstallBindings()
    {
        Container.Bind<IPlayerShootingController>().To<PlayerShootingController>().FromInstance(playerShootingController).AsSingle();
    }
}