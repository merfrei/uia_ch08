using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string itemName;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Item collected: {itemName}");
        Destroy(this.gameObject);
    }
}
