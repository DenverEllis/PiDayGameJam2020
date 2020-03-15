using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<OwnedPiMon> ownedPiMon = new List<OwnedPiMon>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

[System.Serializable]
public class OwnedPiMon {
    public string NickName;
    public BasePiMon piMon;
    public int level;
    public List<PiMonMoves> moves = new List<PiMonMoves>();
}