using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Values")]
    [SerializeField] private float moveSpeed = 5f;
    void Start()
    {
        
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveHorizontal, 0, moveVertical);
    }
}
