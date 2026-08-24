using UnityEngine;

public class BugCatchManager : MonoBehaviour
{
    // BugData型の捕まえた虫のデータを格納する変数
    BugData caughtBug;
    // Inventoryスクリプトを格納する変数
    Inventory inventory;
    
    // 捕まえた虫のデータを格納するメソッド
    public void CatchBug(BugData bug)
    {
        caughtBug = bug;
        inventory.AddBug(caughtBug);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //シーン内からInventoryコンポーネントを探して見つかったものをinventoryに入れる
        inventory = FindFirstObjectByType<Inventory>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
