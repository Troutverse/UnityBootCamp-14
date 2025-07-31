using UnityEngine;
using System;
using System.Collections.Generic;

public class Task : MonoBehaviour
{
    [Serializable]
    public class PlayerStats
    {
        [Header("Base Stats")] 
        public int Hp;
        public int Mp;
        public int Speed;
        public string Name;

        [Header("Attack Defense")]
        [Range(0, 1000)]
        public int Attack;
        [Range(0, 1000)]
        public int Defense;

        [Header("Recovery")]
        public int MaxHp;
        public int MaxMp;
        public float HpRegenRate; 
        public float MpRegenRate; 

        [Header("Growth")]
        public int Level = 1; 
        public long CurrentExp;  

        [Header("Others")]
        [Range(0, 100)]
        public int Lucky; 
        [TextArea] 
        public string Description;
    }

    public PlayerStats SinglePlayerStats;
    public List<PlayerStats> MultiPlayerStats;
}