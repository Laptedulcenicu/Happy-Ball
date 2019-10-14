using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public GameObject gamePlayPanel;
    public GameObject pausePanel;
    public GameObject losePanel;

    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.Instance.initHealth < 0)
        {
            Lose ( );
        }
    }

    public void OpenPausePanel ( )
    {
        pausePanel.SetActive ( true );
        Time.timeScale = 0;
    }

    public void ClosePausePanel ( )
    {
        Time.timeScale = 1;
        pausePanel.SetActive ( false );
    }

    public void Lose ( )
    {
        losePanel.SetActive ( true );
        Time.timeScale = 0;
    }

    public void HomeButton ( )
    {
        Time.timeScale = 1;
        SceneManager.LoadScene ( SceneManager.GetActiveScene ( ).buildIndex - 1 );
        Time.timeScale = 1;
    }

    public void ReplayButton ( )
    {
        Time.timeScale = 1;
        SceneManager.LoadScene ( SceneManager.GetActiveScene ( ).buildIndex );
 
    }
}
