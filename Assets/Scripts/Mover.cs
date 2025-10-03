using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float xValue = 0.01f;
    [SerializeField] private float yValue = 0.00f;
    [SerializeField] private float zValue = 0.00f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
