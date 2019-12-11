using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //偏移值
    Vector3 m_Offset;
    Vector3 m_TargetScreenVec;
    private IEnumerator OnMouseDown()
    {
        m_TargetScreenVec = Camera.main.WorldToScreenPoint(transform.position);
        m_Offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_TargetScreenVec.z));
        while (Input.GetMouseButton(0))
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_TargetScreenVec.z)) + m_Offset;
            yield return new WaitForFixedUpdate();
        }
    }
}
