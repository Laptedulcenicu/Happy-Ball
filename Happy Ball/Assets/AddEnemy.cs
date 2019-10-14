using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnemy : MonoBehaviour
{
    public EnemyI prefabEnemyI;
    public EnemyR prefabEnemyR;
    public EnemyS prefabEnemyS;
    public List<Transform> SpawnPosition = new List<Transform>();
    private int randomSpot;
    private float waitTime;
    public float startWaitTime;
    private float waiteEnemyI;
    public float startEnemyI;
    private float waiteEnemyR;
    public float startEnemyR;
    private float waiteEnemyS;
    public float startEnemyS;
    int numberOfS;
    int numberOfR;
    int numberOfI;
   public int limitS, limitI, limitR;




    // Start is called before the first frame update
    void Start()
    {
        int numberOfS=numberOfR=numberOfI=0;
     
       
        
      
       
        print ( SpawnPosition.Count );

    }

    public void Update ( )
    {
        if (waitTime >= 30)
        {
            numberOfS = numberOfR = numberOfI = 0;
            limitS++;
            limitR++;
            limitI++;
            waitTime = 0;
            if(startEnemyI != 1)
            {               
                startEnemyI--;
            }

            if (startEnemyS != 1)
            {
                startEnemyS--;
            }
            if (startEnemyR != 1)
            {
                startEnemyR--;
            }


        }
        else
        {

            waitTime += Time.deltaTime;
            if (waiteEnemyI <= 0)
            {
                if (numberOfI < limitI)
                {
                    randomSpot = Random.Range ( 0, SpawnPosition.Count - 1 );
                    prefabEnemyI.target = SpawnPosition[randomSpot + 1].transform.position;
                    Instantiate ( prefabEnemyI, SpawnPosition[randomSpot].transform );
                    numberOfI++;

                }

                waiteEnemyI = startEnemyI;
            }
            else
            {

                waiteEnemyI -= Time.deltaTime;

            }


            if (waiteEnemyR <= 0)
            {
                if (numberOfR < limitR)
                {

                randomSpot = Random.Range ( 0, SpawnPosition.Count - 1 );
                Instantiate ( prefabEnemyR, SpawnPosition[randomSpot ].transform );
                 numberOfR++;
                }
                waiteEnemyR = startEnemyR;
            }
            else
            {

                waiteEnemyR -= Time.deltaTime;

            }

            if (waiteEnemyS <= 0)
            {
                if (numberOfS < limitS)
                {
                    randomSpot = Random.Range ( 0, SpawnPosition.Count - 1 );
                    Instantiate ( prefabEnemyS, SpawnPosition[randomSpot].transform );
                    numberOfS++;
                }
                    waiteEnemyS = startEnemyS;
            }
            else
            {

                waiteEnemyS -= Time.deltaTime;

            }


        }

    }


}
