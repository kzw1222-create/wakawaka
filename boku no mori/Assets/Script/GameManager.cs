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
    //出現率の合計値を格納する変数
    int totalSpawnRate = 0;
    //出現する虫のランダム値を格納する変数
    //int raqndomValue = Random.Range(0,totalSpawnRate);

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
        for (int i = 0; i < spawnableBugs.Count; i++)
        {
            totalSpawnRate += spawnableBugs[i].spawnRate;
            Debug.Log(totalSpawnRate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
