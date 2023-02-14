using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnGameElement : MonoBehaviour
{
    public void Spawn(int _col, int _row,float _distant, int _elements, GameObject _go, Transform _spawnPosition)
    {
        for (int row = 0; row < _row; row++)
            for (int column = 0; column < _col; column++)
            {
                GameObject newTile = Instantiate(_go);
                newTile.transform.position = transform.position + new Vector3(transform.position.x - column / 2f, transform.position.y + _row / 2f, 0f) + new Vector3(column * _distant, -row * _distant, 0f);
            }
    }
}
