using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private PlayerMovementController playerMovementController;

    private void Update()
    {
        playerInputController.ReadInput();
    }

    private void FixedUpdate()
    {
        playerMovementController.Move(playerInputController.GetInputData());
    }
}
