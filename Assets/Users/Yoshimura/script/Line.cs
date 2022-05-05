using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer lineRenderer;

    private int positionCount;

    private Camera mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer > ();

        lineRenderer.useWorldSpace = false;
        positionCount = 0;
        mainCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {


        //このラインオブジェクトを、位置はカメラ１０ｍ、回転はカメラと同じようになるようキープさせる
        transform.position = mainCamera.transform.position + mainCamera.transform.forward * 10;
        transform.rotation = mainCamera.transform.rotation;

        // 座標指定の設定をローカル座標系にしたため、与える座標にも手を加える
        Vector3 pos = Input.mousePosition;
        pos.z = 10.0f;

        // マウススクリーン座標をワールド座標に直す
        pos = mainCamera.ScreenToWorldPoint(pos);

        // さらにそれをローカル座標に直す。
        pos = transform.InverseTransformPoint(pos);

        if (Input.GetMouseButtonDown(0))
        {
            lineRenderer.SetPosition(0, pos);

        }

        if(Input.GetMouseButton(0))
        {
            
            lineRenderer.SetPosition(1, pos);
        }




        
        //リセットする
        if (!(Input.GetMouseButton(0)))
        {
            positionCount = 0;
        }
    }
}
