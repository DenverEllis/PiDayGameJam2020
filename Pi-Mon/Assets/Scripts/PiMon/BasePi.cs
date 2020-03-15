using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePi : MonoBehaviour
{
    public string Name;
    public Sprite image;
    public BiomeList biomeFound;
    public PiMonType type;
    public Rarity rarity;
    
    private float maxHP;
    public float baseHP;
    private float maxAttack;
    public float baseAttack;
    private float maxDef;
    public float baseDef;
    public float speed;
    private int level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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