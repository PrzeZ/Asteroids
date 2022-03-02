using UnityEngine;

public class PlayerInputController : MonoBehaviour, IPlayerInputController
{
    private InputData input = new InputData();

    public void ReadInput()
    {
        input.ClearInput();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            input.AddMove(1, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            input.AddMove(0, 1);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            input.AddMove(0, -1);
        }
    }

    public InputData GetInputData()
    {
        return input;
    }
}
