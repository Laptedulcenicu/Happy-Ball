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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPausePanel ( )
    {
        pausePanel.SetActive ( true );
    }

    public void ClosePausePanel ( )
    {
        pausePanel.SetActive ( false );
    }

    public void HomeButton ( )
    {
        SceneManager.LoadScene ( SceneManager.GetActiveScene ( ).buildIndex - 1 );
    }

    public void ReplayButton ( )
    {
        SceneManager.LoadScene ( SceneManager.GetActiveScene ( ).buildIndex );
    }
}
