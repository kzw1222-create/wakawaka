using UnityEngine;

public class SatiInteractable : MonoBehaviour, SatiIInteractable
{
    [SerializeField] private string interactText = "[E] search";

    public string GetInteractText()
    {
        return interactText;
    }

    public void Interact()
    {
        Debug.Log(gameObject.name + "を調べました！");
    }
}