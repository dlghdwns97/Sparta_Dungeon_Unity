using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableInfo : MonoBehaviour
{
    public void OpenInfo()
    {
        gameObject.SetActive(true);
    }
    public void CloseInfo()
    {
        gameObject.SetActive(false);
    }
}
