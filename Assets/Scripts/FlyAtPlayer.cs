using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{


    [SerializeField] private float speed = 2f;
    [SerializeField] Transform player;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {

    }
    void Update()
    {
        MoveToPlayer();
        DestryoWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    void DestryoWhenReached()
    {
        if (transform.position == player.transform.position)
        {
            if (transform.position == player.transform.position)
            {
                Destroy(gameObject);
            }
            
        }
    }
}
