using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNew : MonoBehaviour
{
    [HideInInspector] public bool NewBall = false;
    [SerializeField] private GameObject NewBallPrefab;
    [SerializeField] private GameObject PlayerBall;
    public List<GameObject> ballsOnScheme;
    private float posBallPosX;
    private float posBallPosZ;
    private float posBallRotationEulerY;
    private float sin;
    private float cos;
    private Quaternion posBallRotation;
    private float newBallScaleX;
    private float newBallScaleY;
    private float newBallScaleZ;
    private float offsetNewCreationX;
    private float offsetNewCreationZ;

    private GameObject lastAddingBall;
    private GameObject posBall;

    private void Start()
    {
        newBallScaleX = NewBallPrefab.transform.localScale.x;
        newBallScaleY = NewBallPrefab.transform.localScale.y;
        newBallScaleZ = NewBallPrefab.transform.localScale.z;
        offsetNewCreationX = newBallScaleX;
        offsetNewCreationZ = newBallScaleZ;

        ballsOnScheme.Add(PlayerBall);
    }

    private void Update()
    {
        posBall = ballsOnScheme[ballsOnScheme.Count - 1];
        posBallRotation = posBall.transform.rotation;
        posBallPosX = posBall.transform.position.x;
        posBallPosZ = posBall.transform.position.z;
        posBallRotationEulerY = posBall.transform.rotation.eulerAngles.y;
        sin = Mathf.Sin((posBallRotationEulerY * Mathf.PI) / 180); // from degrees to radians
        cos = Mathf.Cos((posBallRotationEulerY * Mathf.PI) / 180);


        if (NewBall == true){
            lastAddingBall = Instantiate(NewBallPrefab, new Vector3(posBallPosX - sin * offsetNewCreationX, newBallScaleY/2, posBallPosZ - offsetNewCreationZ * cos), posBallRotation);

            lastAddingBall.GetComponent<ConfigurableJoint>().connectedBody = ballsOnScheme[ballsOnScheme.Count - 1].GetComponent<Rigidbody>();

            ballsOnScheme.Add(lastAddingBall);

            NewBall = false;
        }
    }
}
