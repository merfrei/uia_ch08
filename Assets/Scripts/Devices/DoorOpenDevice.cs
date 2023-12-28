using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] Vector3 dPos;

    private bool open;

    public void Operate()
    {
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
