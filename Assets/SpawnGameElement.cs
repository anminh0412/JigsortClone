using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameElement : MonoBehaviour
{
    public void Spawn(int _col, int _row, int _elements, GameObject _go)
    {
        for(int i = 1; i <= _elements; i++) 
        {
            GameObject go = Instantiate(_go, new Vector3(0, 0, 0), Quaternion.identity);
            go.transform.position = new Vector3(i, 0, 0);
        }
    }
}
