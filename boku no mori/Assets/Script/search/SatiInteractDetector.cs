using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class SatiInteractDetector : MonoBehaviour
{
    [Header("Interact Settings")]
    [SerializeField] private float interactDistance = 1f;
    [SerializeField] private LayerMask interactableLayer;

    [Header("UI")]
    [SerializeField] private TMP_Text interactText;

    private SatiIInteractable currentInteractable;

    private void Start()
    {
        if (interactText != null)
        {
            interactText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        DetectInteractable2D();
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

    private void DetectInteractable2D()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(
            transform.position,
            interactDistance,
            interactableLayer
        );

        SatiIInteractable closest = null;
        float closestDistance = float.MaxValue;

        foreach (Collider2D hit in hits)
        {
            SatiIInteractable interactable =
                hit.GetComponent<SatiIInteractable>();

            if (interactable == null)
            {
                continue;
            }

            float distance = Vector2.Distance(
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
        if (interactText == null)
        {
            return;
        }

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