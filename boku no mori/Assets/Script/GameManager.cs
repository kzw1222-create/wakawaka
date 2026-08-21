using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // BugData型の登録する虫のデータを複数入れられるListを作成
    public List<BugData> bugs;
    
    // BugData型のその場に出てくる虫のデータを複数入れられるListを作成
    public List<BugData> spawnableBugs;
    // 現在のスポーンタイプを設定する変数
    public BugSpawnType currentSpawnType;
    // 選択された虫のデータを格納する変数
    BugData selectedBug;
    //出現率の合計値を格納する変数
    int totalSpawnRate = 0;
    //今まで見てきた虫の出現率を合計した値
    int currentRate = 0;

    void Start()
    {
        // Listの中身を順番に取り出して表示
        for (int i = 0; i < bugs.Count; i++)
        {
            //もし現在のスポーンタイプがバグのスポーンタイプと一致する場合のみ表示
            if (bugs[i].spawnType == currentSpawnType)
            {
                spawnableBugs.Add(bugs[i]);
                Debug.Log(bugs[i].bugName);
            }
        }
        //出現率の合計値を計算する
        for (int i = 0; i < spawnableBugs.Count; i++)
        {
            totalSpawnRate += spawnableBugs[i].spawnRate;
            Debug.Log(totalSpawnRate);
        }

        //ランダムな値を1回だけ生成する
        int randomValue = Random.Range(0,totalSpawnRate);
        Debug.Log(randomValue);

        //虫を抽選する
        for (int i = 0; i <spawnableBugs.Count; i++)
        {
            currentRate += spawnableBugs[i].spawnRate;

            //ランダムな値が現在の出現率より小さい場合、選択された虫のデータを格納する
            if (randomValue < currentRate)
            {
                selectedBug = spawnableBugs[i];
                Debug.Log(selectedBug.bugName);
                break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
