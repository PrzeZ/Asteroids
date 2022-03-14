using UnityEngine;
using Zenject;

public class AsteroidCollision : MonoBehaviour, IAsteroidCollision
{
    [Inject(Id = "SmallAsteroidPool")] private AsteroidMove.Factory smallPool;
    [Inject(Id = "MediumAsteroidPool")] private AsteroidMove.Factory mediumPool;

    [SerializeField] private AsteroidSize size;

    public enum AsteroidSize
    {
        Small,
        Medium,
        Big,
        Huge

    }

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
        AsteroidMove asteroid = null;
        if (size == AsteroidSize.Small)
        {
            return;
        }
        else if (size == AsteroidSize.Medium)
        {
            asteroid = smallPool.Create();
        }
        else if (size == AsteroidSize.Big)
        {
            asteroid = mediumPool.Create();
        }

        Vector2 position = transform.position;
        position += Random.insideUnitCircle * 0.5f;    

        if (asteroid == null) { return; }

        asteroid.gameObject.transform.position = position;
        asteroid.gameObject.SetActive(true);
    }
}
