using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("StatChangesForWeapons")]
    public float DamageIncrease;
    bool Damage;
    public float CritChanceIncrease;
    bool CritChance;
    public float MagSizeIncrease;
    bool MagSize;
    public float FireDamageIncrease;
    bool FireDamage;
    public float ElectricDamageIncrease;
    bool ElectricDamage;
    public float ToxinDamageIncrease;
    bool ToxinDamage;
    public float AffinityChanceIncrease;
    bool AffinityChance;
    public float CriticalMultiplierIncrease;
    bool CriticalMultiplier;

    [Header("StatBases")]
    public float numberBase;
    public float RarityLevel;
    bool isFlat = false;
    bool isPercent = false;
    public float PlayerLevel;

    [Header("SceneAfflictionsAndChanges")]
    public GameObject player;
    public GunStats Gun;
    
    void Awake()
    {
        DefineBonuses();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DefineBonuses()
    {
        PlayerLevel = player.GetComponent<PlayerStats>().Level;
        Gun = player.GetComponentInChildren<GunStats>();
        for (int i = 0; i < RarityLevel; i++)
        {
            DecideBonus();
        }
    }

    void DecideBonus()
    {
        int bonusDecisionNum = Random.Range(0, 8);
        if (bonusDecisionNum == 0)
        {
            Damage = true;
            CalculateDamage();
        }
        if (bonusDecisionNum == 1)
        {
            CritChance = true;
            CalculateCritChance();
        }
        if (bonusDecisionNum == 2)
        {
            MagSize = true;
            MagSizeChange();
        }
        if (bonusDecisionNum == 3)
        {
            FireDamage = true;
            FireDamageChange();
        }
        if (bonusDecisionNum == 4)
        {
            ElectricDamage = true;
            ElectricDamageChange();
        }
        if (bonusDecisionNum == 5)
        {
            ToxinDamage = true;
            ToxinDamageChange();
        }
        if (bonusDecisionNum == 6)
        {
            AffinityChance = true;
            AffinityChanceChange();
        }
        if (bonusDecisionNum == 7)
        {
            CriticalMultiplier = true;
            CriticalMultiplierChange();
        }
    }

    void DecideFlatOrPercent()
    {
        float randChance = Random.Range(0, 2);
        if (randChance == 0)
        {
            isFlat = true;
        }
        if (randChance == 1)
        {
            isPercent = true;
        }
    }

    void CalculateDamage()
    {
        if (isFlat)
        {
            DamageIncrease = PlayerLevel * 100 + (Random.Range(0, 100));
            Gun.Damage += DamageIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            DamageIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.Damage *= DamageIncrease;
            isPercent = false;
        }
        Damage = false;
    }

    void CalculateCritChance() 
    {
        if (isFlat)
        {
            CritChanceIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.CriticalChance += CritChanceIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            CritChanceIncrease = 1 + (PlayerLevel % 5) * 10 + (Random.Range(0, 10));
            Gun.CriticalChance *= CritChanceIncrease;
            isPercent = false;
        }

        CritChance = false;
    }

    void MagSizeChange()
    {
        if (isFlat)
        {
            MagSizeIncrease = PlayerLevel + (Random.Range(0, 10));
            Gun.MagSize += (int)MagSizeIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            MagSizeIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.MagSize *= (int)MagSizeIncrease;
            isPercent = false;
        }
        MagSize = false;
    }

    void FireDamageChange()
    {
        if (isFlat)
        {
            FireDamageIncrease = PlayerLevel * 100 + (Random.Range(0, 100));
            Gun.FireDamage += (int)FireDamageIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            FireDamageIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.FireDamage *= (int)FireDamageIncrease;
            isPercent = false;
        }
        FireDamage = false;
    }

    void ElectricDamageChange()
    {
        if (isFlat)
        {
            ElectricDamageIncrease = PlayerLevel * 100 + (Random.Range(0, 100));
            Gun.ElectricDamage += (int)ElectricDamageIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            ElectricDamageIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.ElectricDamage *= (int)ElectricDamageIncrease;
            isPercent = false;
        }
        ElectricDamage = false;
    }

    void ToxinDamageChange()
    {
        if (isFlat)
        {
            ToxinDamageIncrease = PlayerLevel * 100 + (Random.Range(0, 100));
            Gun.ToxinDamage += (int)ToxinDamageIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            ToxinDamageIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.ToxinDamage *= (int)ToxinDamageIncrease;
            isPercent = false;
        }
        ToxinDamage = false;
    }

    void AffinityChanceChange()
    {
        if (isFlat)
        {
            AffinityChanceIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.AffinityChance += AffinityChanceIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            AffinityChanceIncrease = 1 + (PlayerLevel % 5) * 10 + (Random.Range(0, 10));
            Gun.AffinityChance *= AffinityChanceIncrease;
            isPercent = false;
        }
        AffinityChance = false;
    }

    void CriticalMultiplierChange()
    {
        if (isFlat)
        {
            CriticalMultiplierIncrease = (PlayerLevel / 10) + (Random.Range(0, 10));
            Gun.CriticalMultiplier += CriticalMultiplierIncrease;
            isFlat = false;
        }
        if (isPercent)
        {
            CriticalMultiplierIncrease = PlayerLevel * 10 + (Random.Range(0, 10));
            Gun.CriticalMultiplier *= CriticalMultiplierIncrease;
            isPercent = false;
        }
        CriticalMultiplier = false;
    }
}
