using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigIntoHole : MonoBehaviour
{
    public IEnumerator MoveInto(Vector3 destination, float period)
    {
        var startPos = transform.position;
        float time = 0f;
        while (time < 1f)
        {
            time += Time.deltaTime / period;
            transform.position = Vector3.Lerp(startPos, destination, time);
            yield return null;//new WaitForEndOfFrame();
        }
        gameObject.SetActive(false);
    }
}
