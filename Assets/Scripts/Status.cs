using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class Status
{
    public StatsChangeType statsChangeType;
    [Range(1, 100)] public int level;
    [Range(0, 20000)] public int gold;
    [Range(1, 100)] public int maxHealth;
    
    public StatusSO statusSO;
}
