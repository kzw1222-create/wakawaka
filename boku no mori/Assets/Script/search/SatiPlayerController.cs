using UnityEngine;
using UnityEngine.InputSystem;

public class SatiPlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Keyboard.current == null)
        {
            moveDirection = Vector3.zero;
            return;
        }

        float horizontal = 0f;
        float vertical = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            horizontal = -1f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            horizontal = 1f;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            vertical = -1f;
        }

        if (Keyboard.current.wKey.isPressed)
        {
            vertical = 1f;
        }

        moveDirection = new Vector3(
            horizontal,
            0f,
            vertical
        ).normalized;
    }

    private void FixedUpdate()
    {
        Vector3 movement =
            moveDirection *
            moveSpeed *
            Time.fixedDeltaTime;

        rb.MovePosition(rb.position + movement);
    }
}