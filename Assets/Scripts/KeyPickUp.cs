using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    [SerializeField] GameObject key;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(key);

            Debug.Log("Key obtained");
        }
    }
}

// place this on Key prefab