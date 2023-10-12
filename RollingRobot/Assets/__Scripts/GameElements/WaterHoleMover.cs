using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHoleMover : MoverToHole
{
    public override Vector3 GetDestination()
    {
        Vector3 destination = new Vector3(playerPos.x, transform.position.y, transform.position.z - offsetZ);
        return destination;
    }
}
