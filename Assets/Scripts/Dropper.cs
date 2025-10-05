using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float waitTime = 3f;

    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
    void Update()
    {
        Debug.Log(Time.time);
        
        if (Time.time > waitTime)
        {
            Debug.Log("Gravity on!");
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
