using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHead : MonoBehaviour
{
    [SerializeField] private GameObject _head;
    [SerializeField] private float _yOffset = 0.5f;
    private void Update()
    {
        _head.transform.position = new Vector3(transform.position.x, transform.position.y + _yOffset, transform.position.z);
    }
}
