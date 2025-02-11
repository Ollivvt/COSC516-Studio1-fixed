using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Transform ballTransform;
    [SerializeField] private Vector3 offset = new Vector3(0, 10, -10); // Offset distance

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the camera position to follow the ball
        transform.position = ballTransform.position + offset;
    }
}
