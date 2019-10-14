using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    // Start is called before the first frame update
    [SerializeField]
    public Stat health;
    public float initHealth;

    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody2D rb;

    protected override void Awake ( )
    {
        base.Awake ( );
        health.Initialize ( initHealth, initHealth );
        PlayerPrefs.SetFloat ( "Health", initHealth ) ;

    }
    public void FixedUpdate ( )
    {
        Vector2 direction = Vector2.up * variableJoystick.Vertical + Vector2.right * variableJoystick.Horizontal; 
        rb.velocity = direction * speed*Time.fixedDeltaTime;
    }

    public void TakeDamage ( int damage ) //functia aceasta este apelata de catre player si ajuta sa dea damage la enemy
    {
        initHealth -= damage;
        health.MyCurrentValue = initHealth; //apeleaza metoda din stat ca sa scada bara de viata 
        if (initHealth <= 0)
        {

        }

    }
    


}
