using UnityEngine;

public class InputData
{
    private Vector2 move;
    private bool isShooting = false;

    public void AddMove(float forward, float rotation)
    {
        move += new Vector2(forward, rotation);
    }

    public Vector2 GetMove()
    {
        return move;
    }

    public bool IsShooting()
    {
        return isShooting;
    }

    public void SetShooting(bool value)
    {
        isShooting = value;
    }

    public void ClearInput()
    {
        move = Vector2.zero;
        isShooting = false;
    }
}
