using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJumping : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Rigidbody rb;
    [SerializeField] float jumpForce = 2f;
    [SerializeField] float jumpDelay = 0f;

    void Start()
    {
        GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && Time.time >= jumpDelay)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpDelay = Time.time + 0.8f;

            Debug.Log("Jumping");
        }
    }
}
