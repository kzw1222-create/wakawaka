using UnityEngine;

public class SuccessRange : MonoBehaviour
{
    public float minSuccessPower = 40f;
    public float maxSuccessPower = 60f;
    public RectTransform gauge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetRange();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetRange()
    {
        float gaugeWidth =  gauge.rect.width;

        float leftPosition = (minSuccessPower / 100f) * gaugeWidth;
        float rightPosition = (maxSuccessPower / 100f) * gaugeWidth;

        float rangeWidth = rightPosition - leftPosition;

        RectTransform rect =GetComponent<RectTransform>();

        rect.sizeDelta = new Vector2(rangeWidth, rect.sizeDelta.y);

        rect.anchoredPosition = new Vector2(leftPosition + rangeWidth / 2f - gaugeWidth / 2f,0); 
    }
}
