using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField, Header("パズルオブジェクト")]
    private GameObject puzzleObj;

    ///パズルのパターン数
    public static int MaxPuzzlePattern = 6;

    /// <summary>
    /// パズルパターンの乱数
    /// </summary>
    private int PuzzlePatternNum()
    {
        int num = Random.Range(0, MaxPuzzlePattern);
        return num;
    }

    private void GeneratePuzzle()
    {

    }

}