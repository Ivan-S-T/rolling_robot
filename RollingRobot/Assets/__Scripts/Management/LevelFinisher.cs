using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinisher : MonoBehaviour
{
    [SerializeField] private bool isWin = false;
    public void FinishLevel()
    {
        StartCoroutine(nameof(FinishTheLevel));
    }
    IEnumerator FinishTheLevel()
    {
        yield return new WaitForSeconds(1.5f);
        LevelManager.Instance.FinishLevel(isWin);
    }
}
