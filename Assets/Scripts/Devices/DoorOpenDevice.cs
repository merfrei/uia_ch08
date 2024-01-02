using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] Vector3 dPos;

    public bool requiredKey;
    public string keyName;

    private bool open;

    public void Operate()
    {
        if (requiredKey && Managers.Inventory.equippedItem != keyName)
        {
            return;
        }

        Vector3 pos;
        if (open)
        {
            pos = transform.position - dPos;

        }
        else
        {
            pos = transform.position + dPos;
        }
        transform.position = pos;
        open = !open;
    }
}
