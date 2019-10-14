using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Timeout object.
/// It return itself to object pool after provided timeout.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class TimeoutObject : GenericPoolableObject
{

    public int damage;
    // Reference to rigidbody used in spawner
    public Rigidbody2D Rigidbody { get; private set; }

    /// <summary>
    /// Unity's method called on object enable
    /// </summary>
    public override void PrepareToUse()
    {
        base.PrepareToUse();
        

        if (!Rigidbody)
        {
            Rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    /// <summary>
    /// Unity's method called every frame
    /// </summary>


    private void OnTriggerEnter2D ( Collider2D collision )
    {

        if (collision.tag == "Border")
        {
            // Returning object
            ReturnToPool ();
        }
        else if (collision.tag == "Enemy")
        {
            if (collision.gameObject.GetComponent<EnemyR>() != null )
            {
                collision.gameObject.GetComponent<EnemyR> ( ).TakeDamage ( damage );
                ReturnToPool ( );
            }
            else if(collision.gameObject.GetComponent<EnemyS> ( ) != null)
            {
                collision.gameObject.GetComponent<EnemyS> ( ).TakeDamage ( damage );
                ReturnToPool ( );
            }
            else if (collision.gameObject.GetComponent<EnemyI> ( ) != null)
            {
                collision.gameObject.GetComponent<EnemyI> ( ).TakeDamage ( damage );
                ReturnToPool ( );

            }

        }
       
    }
        
    
}
