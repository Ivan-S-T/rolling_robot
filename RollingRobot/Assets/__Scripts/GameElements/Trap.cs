using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, IPlayerInteractable
{
    public void Activate()
    {
        GetComponent<MoverToHole>().MovePlayerToHole();
        GetComponent<LevelFinisher>().FinishLevel();
    }
}
