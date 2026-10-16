using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform camera;
    public Vector3 offset = new Vector3(0, 0, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = camera.position + offset;
        transform.LookAt(camera);
    }
}
