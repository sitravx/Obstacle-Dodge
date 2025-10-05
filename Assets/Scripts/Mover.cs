using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Values")]
    [SerializeField] private float moveSpeed = 5f;


    void Start()
    {
        PrintIntroduction();
    }


    void Update()
    {
        MovePlayer();
    }

    void PrintIntroduction()
    {
        Debug.Log("Welcome to the Mover script!");
        Debug.Log("Use the arrow keys or WASD to move the object.");
        Debug.Log("Don't bump into objects!");
    }
    
    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveHorizontal, 0, moveVertical);
    }
    
}
