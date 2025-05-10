using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIBilding:MonoBehaviour
{
    public FindAndTransform Menu;
    public string TypeOfResourse;
    public int count;
    public int time;
    public int level;
    public int type;
    void Start()
    {
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
                level++;
                break;
            case 1:
                DATA.coins += count;
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
        Menu.SetActiveButtons(true);
    }
}
