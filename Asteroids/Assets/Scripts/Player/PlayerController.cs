using System.Collections;
using System.Collections.Generic;
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
        playerShootingController.Shoot();
    }

    public void FixedUpdate()
    {
        playerMovementController.Move(playerInputController.GetInputData());
    }
}
