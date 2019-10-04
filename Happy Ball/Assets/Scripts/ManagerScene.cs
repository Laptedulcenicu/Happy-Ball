using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public GameObject settingsPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettingPanel ( )
    {
        settingsPanel.SetActive ( true );
    }

    public void CloseSettingsPanel ( )
    {
        settingsPanel.SetActive ( false );
    }

    public void PlayGame ( )
    {
        SceneManager.LoadScene ( SceneManager.GetActiveScene ( ).buildIndex + 1 );
    }
}

