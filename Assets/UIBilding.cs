using UnityEngine;
using UnityEngine.UI;

public class UIBilding : MonoBehaviour
{
    public GameObject Menu;

    void OnMouseDown()
    {
        Menu.SetActive(true);
    }
}
