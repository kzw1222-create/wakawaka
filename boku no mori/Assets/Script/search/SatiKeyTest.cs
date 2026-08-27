using UnityEngine;
using UnityEngine.InputSystem;

public class SatiKeyTest : MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current == null)
        {
            Debug.Log("キーボードが認識されていません！");
            return;
        }

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Debug.Log("★★★ Eキーを認識しました！ ★★★");
        }
    }
}