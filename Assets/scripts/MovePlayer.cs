using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Transform BallCentarPoint; // if Player is a Ball
    [SerializeField] private int movingForce;
    [SerializeField] private int jumpingForce;
    private Rigidbody player_rb;
    private bool forward;
    private bool jump;
    private float rotateHow;
    [SerializeField] private int rotateForce;


    private void Start()
    {
        // for phisic movement only
        player_rb = Player.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) forward = true;
        rotateHow = Input.GetAxis("Horizontal");
        BallCentarPoint.gameObject.transform.Rotate(new Vector3(0, rotateHow, 0));

        if (Input.GetKey(KeyCode.Space)) jump = true;

        BallCentarPoint.gameObject.transform.position = Player.transform.position;     
        Player.transform.rotation = BallCentarPoint.gameObject.transform.rotation;    
    }

    private void FixedUpdate()
    {
        if (forward) 
        {
            player_rb.AddForce(Player.gameObject.transform.forward * movingForce);
            forward = false;
        }
        if (jump) 
        {
            jump = false;
            player_rb.AddForce(Vector3.up * jumpingForce);
        }
    }
}
