using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMove : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;

    public Transform endMarker;

    //二点間の距離を入れる
    private float distance_two;

    //速さ
    [SerializeField]
    private float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //2点の距離を代入
        distance_two = Vector3.Distance(startMarker.position,endMarker.position);


    }

    // Update is called once per frame
    void Update()
    {

        float present_Location = (Time.time * speed)/distance_two;

        //移動の処理
        transform.position = Vector3.Lerp(startMarker.position,endMarker.position,present_Location);
        //Debug.Log("hi");
    }
}
