using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIBilding:MonoBehaviour
{
    public FindAndTransform Menu;
    public string TypeOfResourse;
    public int count;
    public int time;
    public int level=1;
    public int type;
    public List<int> timeVariants;
    public int IndexInUpgradeList;
    void Start()
    {
        time = timeVariants[0];
        Menu = GameObject.FindGameObjectWithTag("PanelForClick").GetComponent<FindAndTransform>();
        Debug.Log(Menu);
    }

    void OnMouseDown()
    {
        Menu.SetActive(true,this);
    }
    public void GetActivityCommand(int typeFromGM, UnityEngine.UI.Slider pb)
    {
        StartCoroutine(WaitTime(pb));
        type=typeFromGM;
    }
    public void ReturnActivityCommand()
    {
        switch (type) 
        {
            case 0:
                Upgrade();
                break;
            case 1:
                GetResourse();
                break;
        }
        print(level..DATA.coins);
    }
    IEnumerator WaitTime(UnityEngine.UI.Slider pb)
    {
        int newVTime = 0;
        while(newVTime != time)
        {
            yield return new WaitForSeconds(1);
            newVTime++;
            pb.value = (float)newVTime/time;
            //print(newVTime / time);

            
        }
        ReturnActivityCommand();
        if (level == 5)
        {
            Menu.SetActiveButtons(false, true);
        }
        else
        {
            Menu.SetActiveButtons(true);
        }
    }
    void Upgrade()
    {
        level++;
        if (level == 5)
        {
            
            StartCoroutine(AutomaticFarm());
        }
        else
        {
            time = timeVariants[level - 1];
        }
    }
    void GetResourse()
    {
        switch (TypeOfResourse)
        {
            case "food":
                DATA.food += count;
                break;
            case "coal":
                DATA.coal += count;
                break;
            case "metal":
                DATA.metal += count;
                break;
            case "brick":
                DATA.bricks += count;
                break;
        }
        print(DATA.food.ToString()+" "+DATA.coal.ToString()+ " " + DATA.metal.ToString()+ " " + DATA.bricks.ToString());
    }
    IEnumerator AutomaticFarm()
    {
        while (true) {
            yield return new WaitForSeconds(1f);
            GetResourse();
        }
        
    }
}
