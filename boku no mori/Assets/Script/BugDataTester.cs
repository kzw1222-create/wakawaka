using System.Collections.Generic;
using UnityEngine;

public class BugDataTester : MonoBehaviour
{
    // BugData型のデータを複数入れられるListを作成
    public List<BugData> bugs;

    void Start()
    {
        // Listの中身を順番に取り出して表示
        for (int i = 0; i < bugs.Count; i++)
        {
            Debug.Log(bugs[i].bugName);
        }
    }
}
