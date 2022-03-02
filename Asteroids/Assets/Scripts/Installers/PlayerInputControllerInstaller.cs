using UnityEngine;
using Zenject;

public class PlayerInputControllerInstaller : MonoInstaller
{
    [SerializeField] PlayerInputController playerInputController;

    public override void InstallBindings()
    {
        Container.Bind<IPlayerInputController>().To<PlayerInputController>().FromInstance(playerInputController).AsSingle();
    }
}