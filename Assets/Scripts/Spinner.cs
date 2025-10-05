using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Header("Spin Values")]
    [SerializeField] private float xAngle = 0f;
    [SerializeField] private float yAngle = 0f;
    [SerializeField] private float zAngle = 0f;

    void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}
