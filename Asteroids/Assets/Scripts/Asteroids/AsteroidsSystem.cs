using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSystem : MonoBehaviour
{
    [SerializeField] private ObjectPooler asteroidPooler;
    private List<GameObject> asteroids = new List<GameObject>();
}
