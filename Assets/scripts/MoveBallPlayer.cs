using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallPlayer : MonoBehaviour
{
    [SerializeField] private GameObject BallPlayer;
    [SerializeField] private Transform BallCentarPoint; // if BallPlayer is a Ball
    [SerializeField] private int movingForce;
    [SerializeField] private int jumpingForce;
    private Rigidbody ballPlayer_rb;
    private bool forward;
    private bool jump;
    private float rotateHow;
    [SerializeField] private int rotateForce;


    private void Start()
    {
        ballPlayer_rb = BallPlayer.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) forward = true;
        rotateHow = Input.GetAxis("Horizontal");
        BallCentarPoint.gameObject.transform.Rotate(new Vector3(0, rotateHow, 0));

        if (Input.GetKey(KeyCode.Space)) jump = true;

        BallCentarPoint.gameObject.transform.position = BallPlayer.transform.position;     
        BallPlayer.transform.rotation = BallCentarPoint.gameObject.transform.rotation;    
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
