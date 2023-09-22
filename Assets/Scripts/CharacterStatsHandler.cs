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
    public void AddStat(int i)
    {
        switch (i)
        {
            case 1:
                CurrentStates.maxHealth += 40;
                CharacterManager.instance.DisplayPlayerInfo(CurrentStates.level, CurrentStates.gold, CurrentStates.maxHealth);
                break;
            case 2:
                CurrentStates.statusSO.atk += 10;
                CharacterManager.instance.DisplayCombatStat(CurrentStates.statusSO.atk, CurrentStates.statusSO.def, CurrentStates.statusSO.critical);
                break;
            case 3:
                CurrentStates.statusSO.def += 20;
                CharacterManager.instance.DisplayCombatStat(CurrentStates.statusSO.atk, CurrentStates.statusSO.def, CurrentStates.statusSO.critical);
                break;
            case 4:
                CurrentStates.statusSO.critical += 30;
                CharacterManager.instance.DisplayCombatStat(CurrentStates.statusSO.atk, CurrentStates.statusSO.def, CurrentStates.statusSO.critical);
                break;
        }

    }
}
