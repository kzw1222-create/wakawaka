using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    RectTransform crosshair;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crosshair = GetComponent<RectTransform>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0, Screen.width);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0, Screen.height);
        crosshair.position = mousePosition;
    }
}
