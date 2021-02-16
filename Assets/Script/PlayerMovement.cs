using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    public Animation animator;
    public float force = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            playerRb.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddForce(Vector3.right * force);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //TimeSystem.slowMotion();
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = 0.5f * 0.02f;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = 0.02f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        playerRb.constraints = RigidbodyConstraints.None;
    }
}
