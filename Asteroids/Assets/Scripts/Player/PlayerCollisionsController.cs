using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionsController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Asteroid"))
        {
            Debug.Log("Player hit by asteroid!");
            this.gameObject.SetActive(false);
        }
    }

}
