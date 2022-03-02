using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float bulletSpeed = 10f;

   private void OnBecameVisible()
    {
        rb.AddRelativeForce(new Vector2(0, bulletSpeed));
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
