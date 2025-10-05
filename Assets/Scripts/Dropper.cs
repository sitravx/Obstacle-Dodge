using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time > 3f)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
