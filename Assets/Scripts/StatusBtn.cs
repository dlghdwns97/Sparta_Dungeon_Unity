using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBtn : MonoBehaviour
{
    public void OpenStatus()
    {
        gameObject.SetActive(true);
    }
    public void CloseStatus()
    {
        gameObject.SetActive(false);
    }
}
