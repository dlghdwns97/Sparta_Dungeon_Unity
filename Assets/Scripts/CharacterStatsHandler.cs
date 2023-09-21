using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private Status baseStats;

    public Status CurrentStates { get; private set; }
    public List<Status> statsModifiers = new List<Status>();

    private void Awake()
    {
        UpdateStatus();
    }
    private void UpdateStatus()
    {
        StatusSO statusSO = null;
        if (baseStats.statusSO != null)
        {
            statusSO = Instantiate(baseStats.statusSO);
        }
        CurrentStates = new Status { statusSO = statusSO };

        CurrentStates.statsChangeType = baseStats.statsChangeType;
        CurrentStates.level = baseStats.level;
        CurrentStates.maxHealth = baseStats.maxHealth;
        CurrentStates.gold = baseStats.gold;

        CharacterManager.instance.DisplayPlayerInfo(CurrentStates.level, CurrentStates.gold, CurrentStates.maxHealth);
        CharacterManager.instance.DisplayCombatStat(statusSO.atk, statusSO.def, statusSO.critical);
    }
}
