using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    //[SerializeField] private ObjectPooler pooler;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Asteroid hit by bullet");
        }
    }

    //private void Split()
    //{
    //    Vector2 position = transform.position;
    //    position += Random.insideUnitCircle * 0.5f;

    //    // Create the new asteroid at half the size of the current
    //    GameObject asteroid = pooler.GetPooledObject();

    //    if (asteroid == null) { return; }
        
    //    asteroid.gameObject.transform.position = position;

    //    asteroid.SetActive(true);
    //}
}
