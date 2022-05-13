using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer lineRenderer;

    private Camera mainCamera;

    private List<LineRenderer> lineRendererList;

    bool test = true;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        // ラインの座標指定を、このラインオブジェクトのローカル座標系を基準にするよう設定を変更　

         //カメラから見やすい位置に線が引かれる
        lineRenderer.useWorldSpace = false;


        mainCamera = Camera.main;

    }


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



        if (test == true)
        {
            //クリックで座標指定
            if (Input.GetMouseButtonDown(0))
            {

                lineRenderer.SetPosition(0, pos);
            }

            //終点の指定
            if (Input.GetMouseButton(0))
            {


                lineRenderer.SetPosition(1, pos);
            }



            //クリックでlinrendererをコピー
            if (Input.GetMouseButtonDown(0))
            {

                Instantiate(lineRenderer, new Vector3(-1f, 0f, 0), Quaternion.identity);

                test = false;
            }

        }
     }

}