using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    [Inject]
    private IPlayerInputController playerInputController;
    [Inject]
    private IPlayerMovementController playerMovementController;
    [Inject]
    private IPlayerShootingController playerShootingController;

    public void Update()
    {
        playerInputController.ReadInput();
        playerShootingController.Shoot(playerInputController.GetInputData());
    }

    public void FixedUpdate()
    {
        playerMovementController.Move(playerInputController.GetInputData());
    }
}
