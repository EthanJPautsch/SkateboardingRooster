using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewRoad : MonoBehaviour
{
    [SerializeField] GameObject straightaway;
    [SerializeField] GameObject curve;
    [SerializeField] GameObject reverseCurve;
    [SerializeField] GameObject tomatoStraightaway;
    [SerializeField] GameObject tomatoCurve;
    [SerializeField] GameObject tomatoReverseCurve;
    [SerializeField] GameObject obstacleStraightaway;
    [SerializeField] GameObject obstacleCurve;
    [SerializeField] GameObject obstacleReverseCurve;
    [SerializeField] Transform spawnStraight;
    [SerializeField] Transform spawnTomatoStraight;
    [SerializeField] Transform spawnObstacleStraight;
    [SerializeField] Transform spawnCurve;
    [SerializeField] Transform spawnTomatoCurve;
    [SerializeField] Transform spawnObstacleCurve;
    [SerializeField] Transform spawnReverse;
    [SerializeField] Transform spawnTomatoReverse;   
    [SerializeField] Transform spawnObstacleReverse;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            newRoad();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Destroyed");
            gameObject.SetActive(false);
        }
    }

    void newRoad()
    {
        int rand = Random.Range(1, 9);
        Debug.Log(rand);
        if(rand == 1)
        {
            GameObject road = Instantiate(straightaway, spawnStraight.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 2)
        {
            GameObject road = Instantiate(curve, spawnCurve.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 3)
        {
            GameObject road = Instantiate(reverseCurve, spawnReverse.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 4)
        {
            GameObject road = Instantiate(tomatoStraightaway, spawnTomatoStraight.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 5)
        {
            GameObject road = Instantiate(tomatoCurve, spawnTomatoCurve.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 6)
        {
            GameObject road = Instantiate(tomatoReverseCurve, spawnTomatoReverse.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 7)
        {
            GameObject road = Instantiate(obstacleStraightaway, spawnObstacleStraight.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 8)
        {
            GameObject road = Instantiate(obstacleCurve, spawnObstacleCurve.position, Quaternion.identity);
            Destroy(road, 20f);
        }
        else if (rand == 9)
        {
            GameObject road = Instantiate(obstacleReverseCurve, spawnObstacleReverse.position, Quaternion.identity);
            Destroy(road, 20f);
        }

    }
}
