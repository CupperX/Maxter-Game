using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class FindAndTransform : MonoBehaviour
{
    public GameObject panel;
    public Button levelUpButton;
    public Button clickerButton;
    public Button closeButtonGO;
    public List<UnityEngine.UI.Slider> progressBars;//0-улучшение, а 1 - кликер
    public Text currentLevel;
    public GameObject housePlaceButton;
    public List<int> upgrades;
    
    public UIBilding currentObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SetActive(bool active, UIBilding activator)
    {
        panel.SetActive(active);
        housePlaceButton.SetActive(!active);
        print("false");
        currentObj = activator;
        currentLevel.text = currentObj.level.ToString();
    }
    public void Close()
    {
        panel.SetActive(false);
        housePlaceButton.SetActive(true);
    }
    public void SetActiveButtons(bool active)
    {
        levelUpButton.interactable = active;
        clickerButton.interactable = active;
        closeButtonGO.interactable = active;
    }
    public void ActivityForBuilding(int type)
    {
        SetActiveButtons(false);
        Debug.Log(type);
        currentObj.GetActivityCommand(type, progressBars[type]);
    }
    public void SetActiveButtons(bool active, bool activeClose)
    {
        levelUpButton.interactable = active;
        clickerButton.interactable = active;
        closeButtonGO.interactable = activeClose;
    }
}
