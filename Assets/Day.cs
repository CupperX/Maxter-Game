using UnityEngine;

public class Day : MonoBehaviour
{
    public GameObject light;
    void Update()
    {
        transform.Rotate(0.01f,0f,0f);

        //if(x = 190; y = -30; z = 0;)
        //{
        //    light.SetActive(true);
        //}
        //else
        //{
        //    light.SetActive(false);
        //}
    }
}
