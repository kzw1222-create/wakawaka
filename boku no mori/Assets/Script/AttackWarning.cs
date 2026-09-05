using UnityEngine;

public class AttackWarning : MonoBehaviour
{
    public float warningTime = 2f;

    private Renderer attackRenderer;
    public Vector3 attackSize = new Vector3(5f,2f,30f);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackRenderer = GetComponent<Renderer>();
        attackRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            attackRenderer.enabled = true;
            Invoke("Attack", warningTime);
            Debug.Log("攻撃だあああわわわあわあああ");
        }
    }
    void Attack()
    {
        Collider[] hitObjects = Physics.OverlapBox(transform.position, attackSize / 2f);

        bool playerHit = false;

        foreach(Collider hitObject in hitObjects)
        {
            if (hitObject.CompareTag("Player"))
            {
                playerHit = true;
                break;
            }
        }
        if (playerHit)
        {
            Debug.Log("いててててててて！！");
        }
        else
        {
            Debug.Log("あっぶねぇぇぇぇぇ");
        }
        attackRenderer.enabled = false;
    }
}
