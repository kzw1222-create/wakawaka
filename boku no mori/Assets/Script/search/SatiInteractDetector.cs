using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class SatiInteractDetector : MonoBehaviour
{
    [SerializeField] private float interactDistance = 2.5f;
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] private TMP_Text interactText;

    private SatiIInteractable currentInteractable;

    private void Start()
    {
        interactText.gameObject.SetActive(false);
    }

    private void Update()
    {
        DetectInteractable();
        UpdateInteractUI();

        if (Keyboard.current != null &&
            Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (currentInteractable != null)
            {
                currentInteractable.Interact();
            }
        }
    }

    private void DetectInteractable()
    {
        Collider[] hits = Physics.OverlapSphere(
            transform.position,
            interactDistance,
            interactableLayer
        );

        SatiIInteractable closest = null;
        float closestDistance = float.MaxValue;

        foreach (Collider hit in hits)
        {
            SatiIInteractable interactable =
                hit.GetComponent<SatiIInteractable>();

            if (interactable == null)
                continue;

            float distance = Vector3.Distance(
                transform.position,
                hit.transform.position
            );

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = interactable;
            }
        }

        currentInteractable = closest;
    }

    private void UpdateInteractUI()
    {
        if (currentInteractable != null)
        {
            interactText.gameObject.SetActive(true);
            interactText.text =
                currentInteractable.GetInteractText();
        }
        else
        {
            interactText.gameObject.SetActive(false);
        }
    }
}