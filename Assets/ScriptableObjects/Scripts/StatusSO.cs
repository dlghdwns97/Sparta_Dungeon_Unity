using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStatusData", menuName = "Status/Attack", order = 0)]
public class StatusSO : ScriptableObject
{
    [Header("Attack Info")]
    public int atk;
    public int def;
    public int critical;
}
