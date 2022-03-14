using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private Camera cam;

    private bool isWrappingX = false;
    private bool isWrappingY = false;

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnBecameInvisible()
    {
        if (isWrappingX && isWrappingY)
        {
            return;
        }

        Vector3 viewportPosition = cam.WorldToViewportPoint(transform.position);
        Vector3 newPosition = transform.position;

        if (!isWrappingX && (viewportPosition.x > 1 || viewportPosition.x < 0))
        {
            newPosition.x = -newPosition.x;

            isWrappingX = true;
        }

        if (!isWrappingY && (viewportPosition.y > 1 || viewportPosition.y < 0))
        {
            newPosition.y = -newPosition.y;

            isWrappingY = true;
        }

        transform.position = newPosition;
    }

    private void OnBecameVisible()
    {
        isWrappingX = false;
        isWrappingY = false;
    }
}
