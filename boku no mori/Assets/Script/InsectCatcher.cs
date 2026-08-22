using UnityEngine;

public class InsectCatcher : MonoBehaviour
{
    public float CatchRange = 30f;

    public float minCatchPower = 40f;
    public float maxCatchPower = 60f;
    public PowerController powerController;
    RectTransform crosshair;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crosshair = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckInsect();
        }
        
    }
    void CheckInsect()
    {
        GameObject insect = GameObject.FindGameObjectWithTag("Insect");
        if(insect == null)
        {
            return;
        }
        Vector3 insectScreenPosition = Camera.main.WorldToScreenPoint(insect.transform.position);

        float distance = Vector2.Distance(crosshair.position, insectScreenPosition);

        float currentPower = powerController.GetPower();

        Debug.Log("押したときのパワー : " + currentPower);

        if(distance <= CatchRange)
        {
            if(currentPower >= minCatchPower && currentPower <= maxCatchPower)
            {
                Debug.Log("虫ゲットだぜ！！！");
                Destroy(insect);
            }
            else
            {
                Debug.Log("パワーが適正じゃないぃぃぃいいい！");
            }
        }
        else
        {
            Debug.Log("虫を捕まえられなかった、、、");
        }
    }
    
}
