using UnityEngine;

public class collision : MonoBehaviour
{
    public PlayerMovement movement;
    public int Text = 0; 

    void OnCollisionEnter (Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("We hit an obstacle");
        }

        

    }
    private void OnTriggerEnter3D(Collider other)
    {
        Debug.Log("We Hit Ivisiblock.");
    }



}
