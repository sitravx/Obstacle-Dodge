using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Values")]
    [SerializeField] private float speed = 5f;
    void Start()
    {
        
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(moveHorizontal * speed * Time.deltaTime, 0, moveVertical * speed * Time.deltaTime);
    }
}
