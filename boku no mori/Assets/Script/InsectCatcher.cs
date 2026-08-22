using UnityEngine;
using TMPro;

public class InsectCatcher : MonoBehaviour
{
    public float CatchRange = 30f;

    public float minCatchPower = 40f;
    public float maxCatchPower = 60f;
    public PowerController powerController;
    RectTransform crosshair;
    public GameObject successText;
    public GameObject failureText;
    private bool gameFinished = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crosshair = GetComponent<RectTransform>();
        successText.SetActive(false);
        failureText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished)
        {
            return;
        }
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

        //標準が合っていない時
        if(distance > CatchRange)
        {
            CatchFailed();
            return;
        }
        //パワーが合っていない時
        if(currentPower < minCatchPower || currentPower > maxCatchPower)
        {
            CatchFailed();
            return;
        }
        //どっちも間違っていない（成功）の時
        CatchSuccess(insect);

    }
    void CatchSuccess(GameObject insect)
    {
        gameFinished = true;

        Debug.Log("おらぁぁ！！捕まえたぞぉぉぉ！！！");
        insect.SetActive(false);

        successText.SetActive(true);
    }
    void CatchFailed()
    {
        gameFinished = true;

        Debug.Log("逃げられたにょーーーーん");

        failureText.SetActive(true);

    }
    
}
