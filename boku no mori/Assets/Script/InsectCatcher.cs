using UnityEngine;

public class InsectCatcher : MonoBehaviour
{
    public float CatchRange = 30f;
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
        if(distance <= CatchRange)
        {
            Debug.Log("虫ゲットだぜ！！！");
            Destroy(insect);
        }
        else
        {
            Debug.Log("虫を捕まえられなかった、、、");
        }
    }
    
}
