using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGenerater : MonoBehaviour
{
    [SerializeField,Header("パズルオブジェクト群(左上から右へ1つずつ進んでいき、0～8に格納)")]
    private GameObject[] puzzleObj;

    /// <summary>
    /// パズルパターンの乱数
    /// </summary>
    private int PuzzlePatternNum()
    {
        int num = Random.Range(0, PuzzleManager.MaxPuzzlePattern);
        return num;
    }

}