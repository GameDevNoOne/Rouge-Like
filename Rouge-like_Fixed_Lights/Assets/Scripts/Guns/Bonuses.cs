using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("StatChangesForWeapons")]
    public int DamageIncrease;
    public int DamageDecrease;
    public float CritChanceIncrease;
    public float CritChanceDecrease;
    public int MagSizeIncrease;
    public int MagSizeDecrease;
    public float FireDamageIncrease;
    public float FireDamageDecrease;
    public float ElectricDamageIncrease;
    public float ElectricDamageDecrease;
    public float ToxinDamageIncrease;
    public float ToxinDamageDecrease;
    public float AffinityChanceIncrease;
    public float AffinityChanceDecrease;
    public float CriticalMultiplierIncrease;
    public float CriticalMultiplierDecrease;

    [Header("SceneAfflictionsAndChanges")]
    public GameObject player;
    
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

    }
}
