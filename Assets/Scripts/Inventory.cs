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
}
