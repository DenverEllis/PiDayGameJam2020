using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject battleCamera;

    public GameObject player;
    public List<BasePiMon> allPiMon = new List<BasePiMon>();
    public List<PiMonMoves> allMoves = new List<PiMonMoves>();

    public Transform defencePodium;
    public Transform attackPodium;
    public GameObject emptyPiMon;

    void Start() {
        playerCamera.SetActive(true);
        battleCamera.SetActive(false);
    }

    void Update()
    {
        
    }

    public void EnterBattle(Rarity rarity) {
        playerCamera.SetActive(false);
        battleCamera.SetActive(true);

        BasePiMon battlePiMon = GetRandomPiMonFromList(GetPiMonByRarity(rarity));

        Debug.Log(battlePiMon.Name);
        
        player.GetComponent<PlayerMovement>().isAllowedToMove = false;
        GameObject dPiMon = Instantiate(emptyPiMon, defencePodium.transform.position, Quaternion.identity) as GameObject;

        dPiMon.transform.parent = defencePodium;
        BasePiMon tempPiMon = dPiMon.AddComponent<BasePiMon>() as BasePiMon;
        tempPiMon.AddMember(battlePiMon);

        dPiMon.GetComponent<SpriteRenderer>().sprite = battlePiMon.image;
    }

    public List<BasePiMon> GetPiMonByRarity(Rarity rarity) {
        List<BasePiMon> returnPiMon = new List<BasePiMon>();
        foreach (BasePiMon PiMon in allPiMon) {
            if(PiMon.rarity == rarity) returnPiMon.Add(PiMon);
        }

        return returnPiMon;
    }

    public BasePiMon GetRandomPiMonFromList(List<BasePiMon> PiMonList) {
        BasePiMon PiMon = new BasePiMon();
        int PiMonIndex = Random.Range(0, PiMonList.Count - 1);
        PiMon = PiMonList[PiMonIndex];
        return PiMon;
    }
}

[System.Serializable]
public class PiMonMoves {
    string Name;
    public MoveType category;
    public Stat moveStat;
    public PokemonType moveType;
    public int PP;
    public float power;
    public float accuracy;

}

[System.Serializable]
public class Stat {
    public float minimum;
    public float maximum;
}

public enum MoveType {
    Physical,
    Special,
    Status
}