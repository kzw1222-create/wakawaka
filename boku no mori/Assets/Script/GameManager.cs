using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // BugData型のデータを複数入れられるListを作成
    public List<BugData> bugs;
    // 現在のスポーンタイプを保持する変数
    public BugSpawnType currentSpawnType;

    void Start()
    {
        // Listの中身を順番に取り出して表示
        for (int i = 0; i < bugs.Count; i++)
        {
            //もし現在のスポーンタイプがバグのスポーンタイプと一致する場合のみ表示
            if (bugs[i].spawnType == currentSpawnType)
            {
                Debug.Log(bugs[i].bugName);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
