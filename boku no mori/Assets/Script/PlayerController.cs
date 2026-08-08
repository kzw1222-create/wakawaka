using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")) * speed * Time.deltaTime);        
    }

}
