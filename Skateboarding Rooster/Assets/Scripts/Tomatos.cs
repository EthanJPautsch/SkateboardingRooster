using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomatos : MonoBehaviour
{
    [SerializeField] GameManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.IncreaseScore(10);
            Destroy(gameObject);
        }
    }
}