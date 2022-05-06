using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField, Header("パズルオブジェクト")]
    private GameObject puzzleObj;

    [SerializeField, Header("パズル数"), Range(2, 6)]
    public int puzzleCount = 2;

    [SerializeField,Header("パズルの横間隔")]
    public float puzzleHorizontalDistance = 2.5f;

    [SerializeField, Header("パズルの縦間隔")]
    private float puzzleVerticalDistance = 6f;

    [SerializeField, Header("色別パズルスプライト")]
    private Sprite[] puzzleColorTemp;

    /// <summary>
    /// 0～6の七色のパズルスプライト
    /// </summary>
    public static Sprite[] puzzleColor;

    private void Awake()
    {
        puzzleColor = puzzleColorTemp;

    }

    private void Start()
    {
        GenerateTopDownPuzzles();
    }

    /// <summary>
    /// 両端のパズルオブジェクト生成関数
    /// countを2で割って割り切れたら、その間隔分puzzleHorizontalDistanceの倍数をとる
    /// この関数ではパズルを生成するのみで、場所の移動や、表示などはPuzzleTransformerで行う。
    /// </summary>
    /// <param name="count">パズル列番号</param>
    private void GenerateTopDownPuzzles()
    {
        for (int i = 1; i < puzzleCount + 1; i++)
        {
            if (i % 2 == 0)
            {
                //2の倍数列生成
                float horizontalPos = i * puzzleHorizontalDistance - puzzleHorizontalDistance;

                //ランダムカラー番号
                int rNum = Random.Range(0, puzzleColor.Length);

                //上
                GameObject top = Instantiate(puzzleObj, new Vector3(horizontalPos, puzzleVerticalDistance, 0), Quaternion.identity);
                
                PuzzleTransformer puzA = top.GetComponent<PuzzleTransformer>();
                puzA.colorNum = rNum;
                puzA.puzzleEnableNumber = new bool[9];


                ////生成したオブジェクトに可視化するbool配列を代入
                int rnd = Random.Range(0, 8);
                for (int n = 0; n <= rnd; n++)
                {
                    int rnd2 = Random.Range(0, 8);
                    Debug.Log(puzA.puzzleEnableNumber.Length);
                }

                //下
                GameObject bottom = Instantiate(puzzleObj, new Vector3(horizontalPos, -puzzleVerticalDistance, 0), Quaternion.identity);
                
                PuzzleTransformer puzB = bottom.GetComponent<PuzzleTransformer>();
                puzB.colorNum = rNum;
                puzB.puzzleEnableNumber = new bool[9];

                ////生成したオブジェクトに可視化するbool配列を代入
                int rndz = Random.Range(0, 8);
                for (int n = 0; n <= rnd; n++)
                {
                    int rnd2 = Random.Range(0, 8);
                    Debug.Log(puzB.puzzleEnableNumber.Length);
                }


            }
            else if (i % 2 == 1)
            {
                //3の倍数列生成

                int multipleVal = i / 2;

                float horizontalPos = multipleVal * 2 * puzzleHorizontalDistance + puzzleHorizontalDistance;

                //ランダムカラー番号
                int rNum = Random.Range(0, puzzleColor.Length);

                //上
                GameObject top = Instantiate(puzzleObj, new Vector3(-horizontalPos, puzzleVerticalDistance, 0), Quaternion.identity);

                PuzzleTransformer puzA = top.GetComponent<PuzzleTransformer>();
                puzA.colorNum = rNum;
                puzA.puzzleEnableNumber = new bool[9];


                ////生成したオブジェクトに可視化するbool配列を代入
                int rnd = Random.Range(0, 8);
                for (int n = 0; n <= rnd; n++)
                {
                    int rnd2 = Random.Range(0, 8);
                    Debug.Log(puzA.puzzleEnableNumber.Length);
                }


                //下
                GameObject bottom = Instantiate(puzzleObj, new Vector3(-horizontalPos, -puzzleVerticalDistance, 0), Quaternion.identity);
                
                PuzzleTransformer puzB = bottom.GetComponent<PuzzleTransformer>();
                puzB.colorNum = rNum;
                puzB.puzzleEnableNumber = new bool[9];

                ////生成したオブジェクトに可視化するbool配列を代入
                int rndz = Random.Range(0, 8);
                for (int n = 0; n <= rnd; n++)
                {
                    int rnd2 = Random.Range(0, 8);
                    Debug.Log(puzB.puzzleEnableNumber.Length);
                }

            }
        }
    }

}