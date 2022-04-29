using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField, Header("パズルオブジェクト")]
    private GameObject puzzleObj;

    [SerializeField, Header("パズル数"), Range(2, 100)]
    private int puzzleCount = 2;

    [SerializeField,Header("パズルの横間隔")]
    private float puzzleHorizontalDistance = 2.5f;

    [SerializeField, Header("パズルの縦間隔")]
    private float puzzleVerticalDistance = 6f;

    ///パズルのパターン数
    public static int MaxPuzzlePattern = 6;

    private void Start()
    {
        GenerateBothTopDownPuzzles();
    }

    /// <summary>
    /// パズルパターンの乱数
    /// </summary>
    private int PuzzlePatternNum()
    {
        int num = Random.Range(0, MaxPuzzlePattern);
        return num;
    }

    /// <summary>
    /// 両端のパズルオブジェクト生成関数
    /// countを2で割って割り切れたら、その間隔分puzzleHorizontalDistanceの倍数をとる
    /// </summary>
    /// <param name="count">パズル列番号</param>
    private void GenerateBothTopDownPuzzles()
    {
        for (int i = 1; i < puzzleCount; i++)
        {
            if (i == 1)
            {
                Instantiate(puzzleObj, new Vector3(-puzzleHorizontalDistance, puzzleVerticalDistance, 0), Quaternion.identity);
                Instantiate(puzzleObj, new Vector3(-puzzleHorizontalDistance, -puzzleVerticalDistance, 0), Quaternion.identity);

                Instantiate(puzzleObj, new Vector3(puzzleHorizontalDistance, puzzleVerticalDistance, 0), Quaternion.identity);
                Instantiate(puzzleObj, new Vector3(puzzleHorizontalDistance, -puzzleVerticalDistance, 0), Quaternion.identity);

            }
            else if (i == 3)
            {
                Instantiate(puzzleObj, new Vector3(0, 0, 0), Quaternion.identity);
            }

            if (i % 2 == 0 && i > 3)
            {
                float HorizontalPos = (i / 2) * puzzleHorizontalDistance;

                Instantiate(puzzleObj, new Vector3(-HorizontalPos, puzzleVerticalDistance, 0), Quaternion.identity);

                Instantiate(puzzleObj, new Vector3(puzzleVerticalDistance, HorizontalPos, 0), Quaternion.identity);

            }
        }
    }

}