using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoad : MonoBehaviour
{
    [SerializeField] GameObject straightaway;
    [SerializeField] GameObject curve;
    [SerializeField] GameObject reverseCurve;
    [SerializeField] Transform spawnStraight;
    [SerializeField] Transform spawnCurve;
    [SerializeField] Transform spawnReverse;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            newRoad();
        }
    }

    void newRoad()
    {
        int rand = Random.Range(0, 2);
        Debug.Log(rand);
        if(rand == 0)
        {
            GameObject road = Instantiate(straightaway, spawnStraight.position, Quaternion.identity);
        }
        if (rand == 1)
        {
            GameObject road = Instantiate(curve, spawnCurve.position, Quaternion.identity);
        }
        if (rand == 2)
        {
            GameObject road = Instantiate(reverseCurve, spawnReverse.position, Quaternion.identity);
        }

    }
}
