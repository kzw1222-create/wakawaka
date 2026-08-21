using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<BugData> inventoryBugs;

    public void AddBug(BagData bug)
    {
        inventoryBugs.Add(bug);
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
