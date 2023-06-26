using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI play, settings;


    [SerializeField] TextMeshProUGUI level1, level2, level3, level4, level5, level6;




    [SerializeField] GameObject[] allUI;
    [SerializeField] GameObject[] levelSelectUI;



    [SerializeField] bool hasLevelSelect;

    void DisableUI()
    {
        foreach (var item in allUI)
        {
            item.SetActive(false);
        }
    }

  public  void PlayButton()
    {
        DisableUI();

        if (!hasLevelSelect)
        {
            SceneManager.LoadScene(1);
        }
        else
        {

        }
    }


 public   void OpenLevelSelect()
    {
        DisableUI();
        foreach (var item in levelSelectUI)
        {
            item.SetActive(true);
        }
    }

}
