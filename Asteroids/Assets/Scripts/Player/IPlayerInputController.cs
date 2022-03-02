using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInputController
{
    void ReadInput();
    InputData GetInputData();
}
