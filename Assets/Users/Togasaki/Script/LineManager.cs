using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    [SerializeField]
    private GameObject lineObj;

    //現在のマウス位置
    Vector3 currentPos;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;

    }

    private void Update()
    {
        currentPos = Input.mousePosition;
        currentPos.z = 20;

        currentPos = mainCamera.ScreenToWorldPoint(currentPos);

        currentPos = transform.InverseTransformPoint(currentPos);

        if (Input.GetMouseButtonDown(0))
        {
            InstLineObj();
        }
    }

    void InstLineObj()
    {
        Instantiate(lineObj, currentPos, Quaternion.identity);
    }


}
