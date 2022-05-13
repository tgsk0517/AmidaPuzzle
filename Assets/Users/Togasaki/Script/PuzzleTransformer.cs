using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTransformer : MonoBehaviour
{
    [SerializeField,Header("パズルオブジェクト群(左上から右へ1つずつ進んでいき、0～8に格納)")]
    private GameObject[] puzzleElements;

    /// <summary>
    /// パズルの色番号
    /// </summary>
    public int colorNum;

    /// <summary>
    /// 0～8の番号でこのオブジェクトの、どのエレメントを表示させるかの配列
    /// </summary>
    public bool[] puzzleEnableNumber = new bool[9];

    private void Start()
    {
        //puzzleEnableNumber = new bool[9];

        PuzzleInfoChange();
    }

    /// <summary>
    /// 色を変更し、表示するエレメント番号も指定する関数
    /// </summary>
    private void PuzzleInfoChange()
    {
        //色変更、パズル変形
        for (int i = 0; i < 9; i++)
        {
            puzzleElements[i].GetComponent<SpriteRenderer>().sprite = PuzzleManager.puzzleColor[colorNum];
            //puzzleElements[i].GetComponent <SpriteRenderer>().enabled = puzzleEnableNumber[i]; //不可視化
        }
        
    }
}