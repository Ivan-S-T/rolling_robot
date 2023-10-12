using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Vector3 offset;

    [SerializeField]
    private Transform player;

    [Range(0.0f, 1.0f), SerializeField]
    private float _followDelay;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void Follow()
    {
        Vector3 endPos = player.position + offset;
        //prevent X camera movement
        endPos = new Vector3(offset.x, endPos.y, endPos.z);
        transform.position = Vector3.Lerp(transform.position, endPos, _followDelay);
    }

    private void FixedUpdate()
    {
        Follow();
    }
}
