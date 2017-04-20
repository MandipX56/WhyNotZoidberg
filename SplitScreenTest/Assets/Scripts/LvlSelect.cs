using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelect : MonoBehaviour
{
    public string lvlSelect; 

    //public void LoadScene()
    //{
    //    SceneManager.LoadScene(lvlSelect);
    //}

    public void OnButtonClick(string lvlSelect)
    {
        Application.LoadLevel(lvlSelect);
    }

}
