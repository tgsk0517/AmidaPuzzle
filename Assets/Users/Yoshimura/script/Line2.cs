using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Line2 : MonoBehaviour
{

//    List<LineRendere> lineRenderes;
    void Start()
    {
   //     lineRenderes = new List<LineRendere>();
    }
   
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _addLine();
        }

        //追加　クリックしたら発動
        void _addLine()
        {
            //空のゲームオブジェクト作成
            GameObject line = new GameObject();
            //オブジェクトの名前をStrokeに変更
            line.name = "Stroke";
            //lineObjにLineRendereコンポーネント追加
            line.AddComponent<LineRenderer>();
            //lineRendererリストにlineObjを追加
      //      lineRenderers.Add(line.GetComponent<LineRenderer>());
            //lineObjを自身の子要素に設定
            line.transform.SetParent(transform);
            //lineObj初期化処理
            _initRenderers();
        }

        //lineObj初期化処理
        void _initRenderers()
        {
            //線をつなぐ点を0に初期化
       //     lineRenderers.Last().positionCount = 0;
            //マテリアルを初期化
         //   lineRenderers.Last().material = lineMaterial;
            //色の初期化
           // lineRenderers.Last().material.color = lineColor;
            //太さの初期化
           // lineRenderers.Last().startWidth = lineWidth;
            //lineRenderers.Last().endWidth = lineWidth;
        }
    }

    

   
}