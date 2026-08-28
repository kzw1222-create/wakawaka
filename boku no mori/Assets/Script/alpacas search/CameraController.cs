using UnityEngine;

public class CameraController : MonoBehaviour
{
    SearchPlayerController player;

    Vector3 cameraOffset = new Vector3(0f, 5f, -10f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<SearchPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
