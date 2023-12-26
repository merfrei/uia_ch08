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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
