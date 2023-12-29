using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IGameManager
{
    public ManagerStatus Status { get; private set; }

    private Dictionary<string, int> items;

    public void Startup()
    {
        Debug.Log("Inventory Manager starting...");

        items = new Dictionary<string, int>();

        Status = ManagerStatus.Started;
    }

    private void DisplayItems()
    {
        string itemsString = string.Join(" | ", items);

        Debug.Log($"Items: {itemsString}");
    }

    public void AddItem(string name)
    {
        if (items.ContainsKey(name))
        {
            items[name] += 1;
        }
        else
        {
            items[name] = 1;
        }

        DisplayItems();
    }

    public List<string> GetItemList()
    {
        return new List<string>(items.Keys);
    }

    public int GetItemCount(string name)
    {
        if (items.ContainsKey(name))
        {
            return items[name];
        }
        return 0;
    }
}
