using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{

    private Transform target;
    [SerializeField] private float speed = 1f;

    // public void Start()
    // {
    //     Bat_start();


    // }

    public void Update()
    {
        // this will check whether the bat has performed a certain action and then it will stop the bats movement
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }
    
    public void Bat_start(Transform player)
    {
        //bat starts moving here
        enabled = true;
        target = player;
    }
    
    public void Bat_stop()
    {
        //bat stops moving here when it has collided with the character
        enabled = false;    
    }
}
