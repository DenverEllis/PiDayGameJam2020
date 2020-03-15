using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePiMon : MonoBehaviour
{
    public string Name;
    public Sprite image;
    public BiomeList biomeFound;
    public PiMonType type;
    public Rarity rarity;
    public int HP;
    private int maxHP;
    public Stat AttackStat;
    public Stat DefenceStat;

    public PiMonStats piMonStats;

    public bool canEvolve;
    public PiMonEvolution evolveTo;

    private int level;

    void Start() {
        maxHP = HP;
    }

    public void AddMember(BasePiMon bp) {
        this.Name = bp.Name;
        this.image = bp.image;
        this.biomeFound = bp.biomeFound;
        this.type = bp.type;
        this.rarity = bp.rarity;
        this.HP = bp.HP;
        this.maxHP = bp.maxHP;
        this.AttackStat = bp.AttackStat;
        this.DefenceStat = bp.DefenceStat;
        this.piMonStats = bp.piMonStats;
        this.canEvolve = bp.canEvolve;
        this.evolveTo = bp.evolveTo;
        this.level = bp.level;
    } 
}

public enum Rarity {
    VeryCommon,
    Common,
    SemiRare,
    Rare,
    VeryRare
}

public enum PiMonType {
    Sweet,
    Savory,
    Pizza
}

public enum PokemonType {
    Flying,
    Ground,
    Rock,
    Steel,
    Fire,
    Water,
    Grass,
    Ice,
    Electric,
    Psychic,
    Dark,
    Dragon,
    Ghost
}

[System.Serializable]
public class PiMonEvolution {
    public BasePiMon nextEvolution;
    public int levelUpLevel;
}

[System.Serializable]
public class PiMonStats {
    public int AttackStat;
    public int DefenceStat;
    public int SpeedStat;
    public int SpAttackStat;
    public int SpDefenceStat;
    public int EvasionStat;
}