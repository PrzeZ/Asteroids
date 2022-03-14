using UnityEngine;

public class InputData
{
    private Vector2 move;
    //private bool shoot;

    public void AddMove(float forward, float rotation)
    {
        move += new Vector2(forward, rotation);
    }

    public Vector2 GetMove()
    {
        return move;
    }

    public void ClearInput()
    {
        move = Vector2.zero;
    }
}
