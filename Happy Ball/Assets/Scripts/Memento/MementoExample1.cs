//-------------------------------------------------------------------------------------
//	MediatorExample1.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

//This real-world code demonstrates the Memento pattern which temporarily saves and then restores the SalesProspect's internal state.
    public class MementoExample1 : MonoBehaviour
    {
        SalesProspect s = new SalesProspect ( );
        ProspectMemory m = new ProspectMemory ( );
    void Start()
        {
         
            s.Health = PlayerPrefs.GetFloat ( "Health", 0 );
            s.InitHealth = PlayerPrefs.GetFloat ( "Health", 0 );  
            // Store internal state
          
            m.Memento = s.SaveMemento();
         
        

        }

        private void OnTriggerEnter2D ( Collider2D collision )
        {
            if (collision.tag == "Player")
            {
                // Restore saved state
                s.RestoreMemento ( m.Memento );
                Destroy ( gameObject );
            }
        }
    }

class Memento
{
    private float health;
    private float initHealth;

    // Constructor
    public Memento ( float health, float initHealth )
    {
        this.health = health;
        this.initHealth = initHealth;

    }

    // Gets or sets name
    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    // Gets or set phone
    public float InitHealth
    {
        get { return initHealth; }
        set { initHealth = value; }
    }
}

class SalesProspect
{
    private float health;
    private float initHealth;

    // Gets or sets name
    public float Health
    {
        get { return health; }
        set
        {
            health = value;
            Debug.Log ( "Name:  " + health );
        }
    }

    // Gets or sets phone
    public float InitHealth
    {
        get { return initHealth; }
        set
        {
            initHealth = value;
            Debug.Log ( "Phone: " + initHealth );
        }
    }

    // Stores memento
    public Memento SaveMemento ( )
    {
        Debug.Log ( "\nSaving state --\n" );
        return new Memento ( health, initHealth );
    }

    // Restores memento
    public void RestoreMemento ( Memento memento )
    {
        Debug.Log ( "\nRestoring state --\n" );
        PlayerController.Instance.health.MyCurrentValue= memento.Health;
        PlayerController.Instance.initHealth=memento.InitHealth;


    }
}

class ProspectMemory
{
    private Memento _memento;

    // Property
    public Memento Memento
    {
        set { _memento = value; }
        get { return _memento; }
    }
}

