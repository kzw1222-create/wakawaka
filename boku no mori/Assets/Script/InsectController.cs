using UnityEngine;

public class InsectController : MonoBehaviour
{
    [Header("移動範囲")]
    public Transform moveCenter;
    public float moveRange = 1.0f;

    [Header("移動設定")]
    public float moveSpeed = 1.0f;
    public float stopDistance = 0.2f;
    public float waitTime = 1.0f;

    private Vector3 targetPosition;
    private float waitTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetRandomTarget();
    }

    // Update is called once per frame
    void Update()
    {
        //待機中
        if(waitTimer > 0)
        {
            waitTimer -= Time.deltaTime;
            return;
        }

        //目的地へ移動
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        //目的地に到着したら
        if(Vector3.Distance(transform.position, targetPosition) < stopDistance)
        {
            waitTimer = waitTime;
            SetRandomTarget();
        }
    }
    void SetRandomTarget()
    {
        float randomX = Random.Range(-moveRange, moveRange);
        float randomY = Random.Range(-moveRange, moveRange);

        targetPosition = new Vector3(moveCenter.position.x + randomX, moveCenter.position.y + randomY, moveCenter.position.z);
    }
}
