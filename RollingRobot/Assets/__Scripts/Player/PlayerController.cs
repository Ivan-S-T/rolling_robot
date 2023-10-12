using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private bool gyroEnable;

    private Rigidbody rb;

    [SerializeField]
    private float speed = 1f;
    private Joystick joystick;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       // gyroEnable = SystemInfo.supportsGyroscope;
        joystick = GameObject.FindGameObjectWithTag("Floating Joystick")?.GetComponent<Joystick>();
       // joystick.gameObject.SetActive(!gyroEnable);
    }

    private void GetInput()
    {
        //if (gyroEnable)
        //{
        //    horizontalInput = Input.acceleration.x;
        //    verticalInput = Input.acceleration.y;
        //}
        //else
        //{
            horizontalInput = Input.GetAxis("Horizontal");            //horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");            //verticalInput = Input.GetAxis("Vertical");
            if (joystick != null)
            {
                horizontalInput += joystick.Horizontal;
                verticalInput += joystick.Vertical;
            }

       // }
        //if (joystick!=null)
        //{
        //    horizontalInput += joystick.Horizontal;
        //    verticalInput += joystick.Vertical;
        //}
    }

    private void Update()
    {
        GetInput();
        if (transform.position.y<-1.0f)
        {
            LevelManager.Instance.FinishLevel(false);
            Destroy(gameObject);
        }
    }

    private void MovePlayerwithRigidbody()
    {
        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
        rb.AddForce(direction * speed);
    }

    private void FixedUpdate()
    {
        MovePlayerwithRigidbody();
    }

    private void OnTriggerEnter(Collider other)
    {
        var trigger = other.gameObject.GetComponent<IPlayerInteractable>();
        if (trigger != null)
        {
            trigger.Activate();
        }
    }
}
