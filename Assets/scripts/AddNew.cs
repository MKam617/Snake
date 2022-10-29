using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNew : MonoBehaviour
{
    [HideInInspector] public bool NewBall;
    [SerializeField] private GameObject NewBallPrefab;
    [SerializeField] private GameObject PlayerBall;
    private List<GameObject> newBallsList = new List<GameObject>();
    private GameObject posBall;
    private GameObject addingBall;
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

    private void Start()
    {
        newBallScaleX = NewBallPrefab.transform.localScale.x;
        newBallScaleY = NewBallPrefab.transform.localScale.y;
        newBallScaleZ = NewBallPrefab.transform.localScale.z;
        offsetNewCreationX = newBallScaleX;
        offsetNewCreationZ = newBallScaleZ;
        newBallsList.Add(PlayerBall);
        posBall = newBallsList[newBallsList.Count - 1];
    }

    private void Update()
    {
        
        posBallPosX = posBall.transform.position.x;
        posBallPosZ = posBall.transform.position.z;
        posBallRotationEulerY = PlayerBall.transform.rotation.eulerAngles.y;
        sin = Mathf.Sin((posBallRotationEulerY * Mathf.PI) / 180); // from degrees to radians
        cos = Mathf.Cos((posBallRotationEulerY * Mathf.PI) / 180);

        if (NewBall){
            posBall = newBallsList[newBallsList.Count - 1];
            addingBall = Instantiate(NewBallPrefab, new Vector3(posBallPosX - sin * offsetNewCreationX, newBallScaleY/2, posBallPosZ - offsetNewCreationZ * cos), posBall.transform.rotation);
            NewBall = false;


            addingBall.GetComponent<ConfigurableJoint>().connectedBody = newBallsList[newBallsList.Count-1].GetComponent<Rigidbody>();
            newBallsList.Add(addingBall);
        }
    }
}
