using UnityEngine;
using Zenject;

public class AsteroidCollision : MonoBehaviour, IAsteroidCollision
{
    [Inject(Id = "MediumAsteroidPool")] private AsteroidMove.Factory pooler;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Asteroid hit by bullet");
            gameObject.SetActive(false);
            collider.gameObject.SetActive(false);
            Split();
            Split();
        }
    }

    private void Split()
    {
        Vector2 position = transform.position;
        position += Random.insideUnitCircle * 0.5f;

        AsteroidMove asteroid = pooler.Create();

        if (asteroid == null) { return; }

        asteroid.gameObject.transform.position = position;
        asteroid.gameObject.SetActive(true);
    }
}
