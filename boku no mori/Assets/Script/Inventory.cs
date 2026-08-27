using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<BugData> inventoryBugs;

    public void AddBug(BugData bug)
    {
        // BugData型の虫のデータをinventoryBugsリストに追加する
        inventoryBugs.Add(bug);
        Debug.Log(bug.bugName + "をインベントリに追加しました。");
        Debug.Log(inventoryBugs.Count + "匹の虫がインベントリに入っています。");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}