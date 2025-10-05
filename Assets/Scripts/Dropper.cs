using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float waitTime = 3f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
    }
    void Update()
    {
        Debug.Log(Time.time);
        
        if (Time.time > waitTime)
        {
            Debug.Log("Gravity on!");
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
