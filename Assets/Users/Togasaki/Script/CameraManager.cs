using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField, Header("メインカメラ")]
    private Transform mainCamera;

    [SerializeField, Header("パズルマネージャー")]
    private PuzzleManager puzzleManager;

    private void Start()
    {
        CameraMove();
    }

    /// <summary>
    /// 奇数の場合にカメラをずらす処理
    /// </summary>
    private void CameraMove()
    {
        if(puzzleManager.puzzleCount % 2 == 1)
        {
            mainCamera.position = new Vector3(-puzzleManager.puzzleHorizontalDistance, mainCamera.position.y, mainCamera.position.z);
        }

    }

}
