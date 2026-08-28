using UnityEngine;
using UnityEngine.SceneManagement;

public class SatiSceneChangeInteractable : MonoBehaviour, SatiIInteractable
{
    [SerializeField] private string interactText = "[E] search";
    [SerializeField] private string sceneName = "MiniGame";

    public string GetInteractText()
    {
        return interactText;
    }

    public void Interact()
    {
        Debug.Log(gameObject.name + " examined!");

        SceneManager.LoadScene(sceneName);
    }
}