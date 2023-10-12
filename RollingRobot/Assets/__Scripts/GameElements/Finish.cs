using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour, IPlayerInteractable
{
    [SerializeField] private ParticleSystem holeFireWork;
    public void Activate()
    {
        holeFireWork.Play();
        GetComponent<MoverToHole>().MovePlayerToHole();
        GetComponent<LevelFinisher>().FinishLevel();
    }
}
