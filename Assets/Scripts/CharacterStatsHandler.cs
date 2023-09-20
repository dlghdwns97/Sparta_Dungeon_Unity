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
        // TODO
        CurrentStates.statsChangeType = baseStats.statsChangeType;
        CurrentStates.maxHealth = baseStats.maxHealth;
        CurrentStates.gold = baseStats.gold;
    }
}
