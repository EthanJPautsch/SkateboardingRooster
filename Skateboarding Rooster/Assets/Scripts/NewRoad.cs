using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoad : MonoBehaviour
{
    [SerializeField] GameObject straightaway;
    [SerializeField] GameObject curve;
    [SerializeField] GameObject reverseCurve;
    [SerializeField] Transform spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
            Debug.Log("------" + spawn.position);
            GameObject road = Instantiate(straightaway, spawn.position, Quaternion.identity);
        }
        if (rand == 1)
        {
            Debug.Log("/////" + spawn.position);
            GameObject road = Instantiate(curve, spawn.position, Quaternion.identity);
        }
        if (rand == 2)
        {
            Debug.Log("|||||" + spawn.position);
            GameObject road = Instantiate(reverseCurve, spawn.position, Quaternion.identity);
        }

    }
}
