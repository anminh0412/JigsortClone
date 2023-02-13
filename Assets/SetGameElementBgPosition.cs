using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameElementBgPosition : MonoBehaviour
{
   public void SetPosition(Transform _mainBg)
    {
        gameObject.transform.position = _mainBg.position;
    }
}
