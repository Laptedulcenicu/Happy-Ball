using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    public GameObject PrefabHealth;
    public List<Transform> SpawnPosition = new List<Transform> ( );
    private int randomSpot;
    private float waitTime;
    public float startWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime <= 0)
        {
            randomSpot = Random.Range ( 0, SpawnPosition.Count - 1 );
            Instantiate ( PrefabHealth, SpawnPosition[randomSpot].transform );

            waitTime = startWaitTime;
        }
        else
        {
            waitTime -= Time.deltaTime;
        }

    }
}
