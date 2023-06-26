using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuCanvas : MonoBehaviour
{
    [SerializeField] bool hasLevelSelect;
    [SerializeField] TextMeshProUGUI level1, level2, level3, level4, level5, level6;


    [SerializeField] TextMeshProUGUI play, settings;






    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] GameObject[] allUI;
    [SerializeField] GameObject[] startUI;
    [SerializeField] GameObject[] levelSelectUI;

    private void Start()
    {
        DisableUI();
        TurnOnStartMenu();
    }

    void TurnOnStartMenu()
    {
        DisableUI();
        foreach (var item in startUI)
        {
            item.SetActive(true);
        }
        titleText.text = "Main Menu";
    }

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
            OpenLevelSelect();
        }
    }


   void OpenLevelSelect()
    {
       
        foreach (var item in levelSelectUI)
        {
            item.SetActive(true);
        }
    }

    public void BackButton()
    {
        DisableUI();
        TurnOnStartMenu();
    }

}
