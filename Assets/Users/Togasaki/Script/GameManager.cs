using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField, Header("メインカメラ")]
    private Transform mainCamera;

    /// <summary>
    /// タッチした初期地点
    /// </summary>
    private Vector3 touchPos;

    /// <summary>
    /// 現在タッチしている地点
    /// </summary>
    private Vector3 currentPos;

    private void Update()
    {
        CameraMove();
    }

    /// <summary>
    /// カメラを移動させる処理
    /// </summary>
    private void CameraMove()
    {
        //画面をタッチした場合firstTouchPosを変更
        if (Input.GetMouseButtonDown(0))
        {
            touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        //現在地を代入
        if (Input.GetMouseButton(0))
        {
            currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float distant = currentPos.x - touchPos.x;
            mainCamera.position = new Vector3(mainCamera.position.x - distant, 0, -10);

        }
    }

}
