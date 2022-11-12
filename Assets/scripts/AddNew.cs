using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNew : MonoBehaviour
{
    [HideInInspector] public bool NewBall;
    [SerializeField] private GameObject NewBallPrefab;
    [SerializeField] private GameObject PlayerBall;
<<<<<<< HEAD
    [SerializeField] private GameObject PlayerBallCenterPoint;
    public List<GameObject> ballsOnScheme;
=======
    private List<GameObject> newBallsList = new List<GameObject>();
    private GameObject posBall;
    private GameObject addingBall;
>>>>>>> cfdd48e7aaec03b062a3092cee82d9f6e9f9065d
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

<<<<<<< HEAD
    private GameObject lastAddingBall;
    private GameObject posBall;


=======
>>>>>>> cfdd48e7aaec03b062a3092cee82d9f6e9f9065d
    private void Start()
    {
        newBallScaleX = NewBallPrefab.transform.localScale.x;
        newBallScaleY = NewBallPrefab.transform.localScale.y;
        newBallScaleZ = NewBallPrefab.transform.localScale.z;
<<<<<<< HEAD
        offsetNewCreationX = newBallScaleX + 1;
        offsetNewCreationZ = newBallScaleZ + 1;

        ballsOnScheme.Add(PlayerBall);
=======
        offsetNewCreationX = newBallScaleX;
        offsetNewCreationZ = newBallScaleZ;
        newBallsList.Add(PlayerBall);
        posBall = newBallsList[newBallsList.Count - 1];
>>>>>>> cfdd48e7aaec03b062a3092cee82d9f6e9f9065d
    }

    private void Update()
    {
<<<<<<< HEAD
        posBall = ballsOnScheme[ballsOnScheme.Count - 1];



        posBallRotation = posBall.transform.rotation;
        posBallPosX = posBall.transform.position.x;
        posBallPosZ = posBall.transform.position.z;
        posBallRotationEulerY = posBall.transform.rotation.eulerAngles.y;
        sin = Mathf.Sin((posBallRotationEulerY * Mathf.PI) / 180); // from degrees to radians
        cos = Mathf.Cos((posBallRotationEulerY * Mathf.PI) / 180);


        if (NewBall == true){
            lastAddingBall = Instantiate(NewBallPrefab, new Vector3(posBallPosX - sin * offsetNewCreationX, newBallScaleY/2, posBallPosZ - offsetNewCreationZ * cos), PlayerBallCenterPoint.transform.rotation);


            lastAddingBall.GetComponent<ConfigurableJoint>().connectedBody = ballsOnScheme[ballsOnScheme.Count - 1].GetComponent<Rigidbody>();

            ballsOnScheme.Add(lastAddingBall);

=======
        
        posBallPosX = posBall.transform.position.x;
        posBallPosZ = posBall.transform.position.z;
        posBallRotationEulerY = PlayerBall.transform.rotation.eulerAngles.y;
        sin = Mathf.Sin((posBallRotationEulerY * Mathf.PI) / 180); // from degrees to radians
        cos = Mathf.Cos((posBallRotationEulerY * Mathf.PI) / 180);

        if (NewBall){
            posBall = newBallsList[newBallsList.Count - 1];
            addingBall = Instantiate(NewBallPrefab, new Vector3(posBallPosX - sin * offsetNewCreationX, newBallScaleY/2, posBallPosZ - offsetNewCreationZ * cos), posBall.transform.rotation);
>>>>>>> cfdd48e7aaec03b062a3092cee82d9f6e9f9065d
            NewBall = false;


            addingBall.GetComponent<ConfigurableJoint>().connectedBody = newBallsList[newBallsList.Count-1].GetComponent<Rigidbody>();
            newBallsList.Add(addingBall);
        }
    }
}
