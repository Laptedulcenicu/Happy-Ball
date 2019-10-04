using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
   
    public AudioClip button;
    public AudioClip death;
    public AudioClip win;

    private AudioSource aSource;
    bool allowMusic;
    bool allowSounds;
    bool allowVibration;

    private void Start()
    {
        aSource = GetComponent<AudioSource> ( );

        if (PlayerPrefs.GetInt ( "music", 1 ) == 1)
            aSource.Play ( );
    }

    public void Play(string name)
    {
        if (name == "music")
            if (PlayerPrefs.GetInt ( "music", 1 ) == 1)
                aSource.Play ( );
            else
                aSource.Stop ( );


        if (PlayerPrefs.GetInt ( "sound", 1 ) == 0)
            return;

        if (name == "button")
            aSource.PlayOneShot ( button );

        if (name == "death")
            aSource.PlayOneShot ( death );

        if (name == "win")
            aSource.PlayOneShot ( win );


     
    }
    public void PlayVibration ( )
    {
        if (PlayerPrefs.GetInt ( "vibration", 1 ) == 0)
            return;
        Handheld.Vibrate ( );
        
    }
}
