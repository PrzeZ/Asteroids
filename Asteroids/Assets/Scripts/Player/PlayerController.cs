using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerController:MonoBehaviour
{
    [Inject]
    private IPlayerInputController playerInputController;
    [Inject]
    private IPlayerMovementController playerMovementController;

    public void Update()
    {
        playerInputController.ReadInput();
    }

    public void FixedUpdate()
    {
        playerMovementController.Move(playerInputController.GetInputData());
    }
}
