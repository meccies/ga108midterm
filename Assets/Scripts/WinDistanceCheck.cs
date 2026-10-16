using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WinDistanceCheck : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform winArea;

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Win");
        Debug.Log("You Win!");
    }
}

// Attach to Win Area GameObject