using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highlight : MonoBehaviour
{
    public GameObject highlightGO;
    public Button Button;
    public void HandlerMouseEnter()
    {
        if(Button.IsInteractable())
        {
            highlightGO.SetActive(true);
        }
    }
}
