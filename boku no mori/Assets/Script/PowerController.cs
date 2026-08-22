using UnityEngine;
using UnityEngine.UI;

public class PowerController : MonoBehaviour
{
    public float power = 0f;
    
    public float minPower = 0f;
    public float maxPower = 100f;

    public float powerSpeed = 50f;

    public Slider powerGauge;

    private bool increasing = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        powerGauge.minValue = minPower;
        powerGauge.maxValue = maxPower;
        powerGauge.value = power;
    }

    // Update is called once per frame
    void Update()
    {
        if (increasing)
        {
            power += powerSpeed * Time.deltaTime;
            //Debug.Log(power);

            if(power >= maxPower)
            {
                power = maxPower;
                increasing = false;
            }
        }
        else
        {
            power -= powerSpeed * Time.deltaTime;
            //Debug.Log(power);

            if(power <= minPower)
            {
                power = minPower;
                increasing = true;
            }
        }
        powerGauge.value = power;
    }
    public float GetPower()
    {
        return power;
    }
}
