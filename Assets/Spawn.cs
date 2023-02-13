using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    SpawnGameElement spawnGameElement;
    [SerializeField] int row;
    [SerializeField] int col;
    [SerializeField] int distant;
    [SerializeField] int elements;
    [SerializeField] GameObject gameobjectElement;
    [SerializeField] Transform spawnPosition;
    private void Start()
    {
        spawnGameElement = GetComponent<SpawnGameElement>();
        spawnGameElement.Spawn(col, row, distant, elements, gameobjectElement, spawnPosition);
    }
}
