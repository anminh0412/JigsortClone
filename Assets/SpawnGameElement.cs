using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnGameElement : MonoBehaviour
{
    public void Spawn(int _col, int _row,float _distant, int _elements, GameObject _go, Transform _spawnPosition)
    {
        for(int i = 1; i <= _elements; i++) 
        {
            GameObject go = Instantiate(_go, new Vector3(0, 0, 0), Quaternion.identity);
            go.transform.position = _spawnPosition.position + new Vector3(transform.position.x - _col / 2f*i, transform.position.y + _row / 2f*i, 0f) + new Vector3(_col * _distant, -_row * _distant, 0f);
        }
    }
}
