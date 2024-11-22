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
            Debug.Log("YOU GOT 10 POINTS!");
            GameManager.instance.IncreaseScore(10);
            Destroy(gameObject);
        }
    }
}