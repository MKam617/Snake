using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallPlayer : MonoBehaviour
{
    [SerializeField] private GameObject BallPlayer;
    [SerializeField] private Transform BallPlayerCentarPoint; 
    [SerializeField] private int movingForce;
    [SerializeField] private int jumpingForce;
    // [SerializeField] [Range(0.1f, 5)] private float rotateSpeed;
    private Rigidbody ballPlayer_rb;
    private bool forward;
    private bool jump;
    private float rotateHow;


    private void Start()
    {
        ballPlayer_rb = BallPlayer.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) forward = true;
        rotateHow = Input.GetAxis("Horizontal");
        BallPlayerCentarPoint.gameObject.transform.Rotate(new Vector3(0, rotateHow, 0));

        if (Input.GetKey(KeyCode.Space)) jump = true;

        BallPlayerCentarPoint.transform.position = BallPlayer.transform.position;     
        BallPlayer.transform.rotation = BallPlayerCentarPoint.transform.rotation;    
    }

    private void FixedUpdate()
    {
        if (forward) 
        {
            ballPlayer_rb.AddForce(BallPlayer.gameObject.transform.forward * movingForce);
            forward = false;
        }
        if (jump) 
        {
            jump = false;
            ballPlayer_rb.AddForce(Vector3.up * jumpingForce);
        }
    }
}
