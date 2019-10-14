using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyI : MonoBehaviour, IBridge
{
    [SerializeField]
    private Stat health;
    public float initHealth;
    public float speed;
    public int damage;
    bool attacking;
    private float waitTime;
    public float startWaitTime;
    public Vector3 target;

    public void Start ( )
    {
        waitTime = startWaitTime;
        health.Initialize ( initHealth, initHealth );
    }

    public void Update ( )
    {

        if (transform.position == target)
            Destroy ( gameObject );

        transform.position = Vector2.MoveTowards ( transform.position, target, speed * Time.deltaTime );

        if (attacking)
        {
            if (waitTime <= 0)
            {
                if (PlayerPrefs.GetInt ( "vibration", 1 ) == 1)
                Handheld.Vibrate ( );

                PlayerController.Instance.TakeDamage ( damage );
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
    public void OnTriggerEnter2D ( Collider2D collision )
    {
        if (collision.tag == "Player")
        {
            attacking = true;

        }
    }
    public void OnTriggerExit2D ( Collider2D collision )
    {
        if (collision.tag == "Player")
        {
            attacking = false;
        }
    }
    public void TakeDamage ( int damage ) //functia aceasta este apelata de catre player si ajuta sa dea damage la enemy
    {
        initHealth -= damage;
        health.MyCurrentValue = initHealth; //apeleaza metoda din stat ca sa scada bara de viata 
        if (initHealth <= 0)
        {
            Destroy ( gameObject );
        }
    }
}
