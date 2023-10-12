using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverToHole : MonoBehaviour
{
    [SerializeField] private float timeToDig = 0.4f;
    [SerializeField] protected float offsetZ = 0.2f;

    GameObject player;
    protected Vector3 playerPos;

    public void MovePlayerToHole()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPos = player.transform.position;

        var digScript = player.GetComponent<DigIntoHole>();
        Vector3 movePoint = GetDestination();
        StartCoroutine(digScript.MoveInto(movePoint, timeToDig));
    }

    public virtual Vector3 GetDestination()
    {
        Vector3 movePoint = new Vector3(transform.position.x, transform.position.y, transform.position.z - offsetZ);
        return movePoint;
    }
}
