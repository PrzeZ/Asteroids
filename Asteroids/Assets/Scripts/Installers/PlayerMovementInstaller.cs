using UnityEngine;
using Zenject;

public class PlayerMovementInstaller : MonoInstaller
{
    [SerializeField] PlayerMovementController playerMovementController;

    public override void InstallBindings()
    {
        Container.Bind<IPlayerMovementController>().To<PlayerMovementController>().FromInstance(playerMovementController).AsSingle();
    }
}