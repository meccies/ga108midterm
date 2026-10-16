using UnityEngine;

public class DoorColliderScript : MonoBehaviour
{
    public GameObject door;

    void Start()
    {
        GetComponent<KeyPickUp>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (GetComponent<KeyPickUp>())
        {
            door.SetActive(false);
            Debug.Log("Door unlocked");
        }
    }
}
