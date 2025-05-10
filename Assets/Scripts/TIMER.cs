using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public int time;
    public Text timeText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeText.text = time.ToString();
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        int timeLeft = time;
        while (timeLeft !=0) 
        {
            yield return new WaitForSeconds(60f);
            timeLeft--;
            timeText.text = timeLeft.ToString();
        }
        End();
    }
    void End()
    {
        Debug.Log("End!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
