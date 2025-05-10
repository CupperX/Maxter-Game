using UnityEngine;
using UnityEngine.UI;

public class PayForButtons : MonoBehaviour
{
    public string TypeOfResourse;
    public int cost;
    public Button MyButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int myRes = Check();
        if (myRes < cost) 
        { 
            MyButton.interactable = false;
        }
        else
        {
            MyButton.interactable = true;
        }
    }
    int Check()
    {
        int varForTime=0;
        switch (TypeOfResourse)
        {
            case "food":
                varForTime = DATA.food;
                break;
            case "coal":
                varForTime = DATA.coal;
                break;
            case "metal":
                varForTime = DATA.metal;
                break;
            case "brick":
                varForTime = DATA.bricks;
                break;
        }
        return varForTime;
    }
    public void Pay()
    {
        switch (TypeOfResourse)
        {
            case "food":
                DATA.food-=cost;
                break;
            case "coal":
                DATA.coal -= cost;
                break;
            case "metal":
                DATA.metal -= cost;
                break;
            case "brick":
                DATA.bricks -= cost;
                break;
        }
    }
}
