using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("StatChangesForWeapons")]
    public float DamageIncrease;
    bool Damage;
    public float DamageDecrease;
    public float CritChanceIncrease;
    bool CritChance;
    public float CritChanceDecrease;
    public float MagSizeIncrease;
    bool MagSize;
    public float MagSizeDecrease;
    public float FireDamageIncrease;
    bool FireDamage;
    public float FireDamageDecrease;
    public float ElectricDamageIncrease;
    bool ElectricDamage;
    public float ElectricDamageDecrease;
    public float ToxinDamageIncrease;
    bool ToxinDamage;
    public float ToxinDamageDecrease;
    public float AffinityChanceIncrease;
    bool AffinityChance;
    public float AffinityChanceDecrease;
    public float CriticalMultiplierIncrease;
    bool CriticalMultiplier;
    public float CriticalMultiplierDecrease;

    [Header("StatBases")]
    public float numberBase;

    [Header("SceneAfflictionsAndChanges")]
    public GameObject player;
    
    void Awake()
    {
        DefineBonuses();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DefineBonuses()
    {
        float currLevel = player.GetComponent<PlayerStats>().Level;

    }

    void DefineNegatives()
    {

    }

    void DecideBonus()
    {
        int bonusDecisionNum = Random.Range(0, 8);
        if (bonusDecisionNum == 0)
        {

        }
        if (bonusDecisionNum == 1)
        {

        }
        if (bonusDecisionNum == 2)
        {

        }
        if (bonusDecisionNum == 3)
        {

        }
        if (bonusDecisionNum == 4)
        {

        }
        if (bonusDecisionNum == 5)
        {

        }
        if (bonusDecisionNum == 6)
        {

        }
        if (bonusDecisionNum == 7)
        {

        }
    }
    void DecideNegatives()
    {
        int bonusDecisionNum = Random.Range(0, 8);
    }
}
