using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    void Start()
    {
        ItemManager.instance.MakeItemList();
    }

    public void EquipItem()
    {
        gameObject.SetActive(true);
    }

    public void UnequipItem()
    {
        gameObject.SetActive(true);
    }
    public void SelectConfirmORCancel()
    {
        gameObject.SetActive(false);
    }
}
