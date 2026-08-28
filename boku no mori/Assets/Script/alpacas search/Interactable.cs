using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{

    public void Interact()
    {
        Debug.Log("虫を発見した！");
        SceneManager.LoadScene("MiniGame");
    }
}
