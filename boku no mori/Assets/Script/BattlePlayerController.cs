using UnityEngine;

public class BattlePlayerController : MonoBehaviour
{
    CharacterController controller;

    float moveSpeed = 8f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            z += 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 1f;
        }

        Vector3 move = new Vector3(x, 0f, z);
        controller.Move(move * moveSpeed * Time.deltaTime);

        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, -15f, 15f);
        position.z = Mathf.Clamp(position.z, -15f, 15f);
        transform.position = position;
    }
}
