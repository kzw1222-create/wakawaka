using UnityEngine;

public class SatiPlayerController : MonoBehaviour
{
    Rigidbody rb;

    Vector3 move;

    float speed = 5f;

    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            z = 1f;

            animator.Play("boku_back_Clip");
        }
        else
        {
            animator.Play("boku_back_idle_Clip");
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = -1f;

        }
        if (Input.GetKey(KeyCode.A))
        {
            x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = 1f;
        }

        move = new Vector3(x, 0, z);

        rb.linearVelocity = new Vector3(move.x * speed, rb.linearVelocity.y, move.z * speed);


    }
}