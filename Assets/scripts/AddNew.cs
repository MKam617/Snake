using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNew : MonoBehaviour
{
    [HideInInspector] public bool NewBall = false;
    [SerializeField] private GameObject NewBallPrefab;
    [SerializeField] private GameObject PlayerBall;
    private float playerBallPosX;
    private float playerBallPosZ;
    private float playerBallRotationEulerY;
    private float sin;
    private float cos;
    private Quaternion playerBallRotation;
    private float newBallScaleX;
    private float newBallScaleY;
    private float newBallScaleZ;
    private float offsetNewCreationX;
    private float offsetNewCreationZ;

    private void Awake()
    {
        newBallScaleX = NewBallPrefab.transform.localScale.x;
        newBallScaleY = NewBallPrefab.transform.localScale.y;
        newBallScaleZ = NewBallPrefab.transform.localScale.z;
        offsetNewCreationX = newBallScaleX;
        offsetNewCreationZ = newBallScaleZ;
    }

    private void Update()
    {
        playerBallPosX = PlayerBall.transform.position.x;
        playerBallPosZ = PlayerBall.transform.position.z;
        playerBallRotationEulerY = PlayerBall.transform.rotation.eulerAngles.y;
        sin = Mathf.Sin((playerBallRotationEulerY * Mathf.PI) / 180); // from degrees to radians
        cos = Mathf.Cos((playerBallRotationEulerY * Mathf.PI) / 180);

        if (NewBall == true){
            Instantiate(NewBallPrefab, new Vector3(playerBallPosX - sin * offsetNewCreationX, newBallScaleY/2, playerBallPosZ - offsetNewCreationZ * cos), playerBallRotation);
            NewBall = false;
        }
    }
}
