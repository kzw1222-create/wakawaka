using UnityEngine;

using TMPro;

public class PlayerInteract : MonoBehaviour
{
    float interactDistance = 2f;

    [SerializeField] TMP_Text interactText;

    Interactable target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, interactDistance);

        Debug.Log("見つかったCollider数：" + hits.Length);

        for (int i = 0; i < hits.Length; i++)
        {
            Interactable interactable = hits[i].GetComponent<Interactable>();

            if (interactable != null)
            {
                interactText.gameObject.SetActive(true);
                target = interactable;
                Debug.Log("Interactableを発見：" + target.gameObject.name);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Eキーを押しました");

            if (target != null)
            {
                Debug.Log("Interactを実行します");
                target.Interact();
            }
        }
    }
}
