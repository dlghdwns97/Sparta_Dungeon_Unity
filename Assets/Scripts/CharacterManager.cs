using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    public TextMeshProUGUI[] stats = new TextMeshProUGUI[6];
    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        for (int i = 0; i < stats.Length; i++)
        {
            stats[i] = GetComponent<TextMeshProUGUI>();
        }
    }
    public void DisplayPlayerInfo(int level, int gold, int health)
    {
        stats[0].text = "Lv " + level.ToString();
        stats[1].text = gold.ToString();
        stats[2].text = health.ToString();
    }
    public void DisplayCombatStat(int atk, int def, int critical)
    {
        stats[3].text = atk.ToString();
        stats[4].text = def.ToString();
        stats[5].text = critical.ToString();
    }
}
