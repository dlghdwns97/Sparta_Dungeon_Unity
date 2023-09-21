using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance;
    public GameObject item;

    private Sprite[] _itemImage;
    private void Awake()
    {
        instance = this;
    }
    public void MakeItemList()
    {
        _itemImage = new Sprite[]
        {
            Resources.Load<Sprite>("Image/Item/Iron_Armor"),
            Resources.Load<Sprite>("Image/Item/Iron_Sword"),
            Resources.Load<Sprite>("Image/Item/Golden_Shield"),
            Resources.Load<Sprite>("Image/Item/Necklace")
        };

        for (int i = 0; i < _itemImage.Length; i++)
        {
            item.GetComponent<Image>().sprite = _itemImage[i];
            GameObject Item = Instantiate(item);
        }
    }
}
