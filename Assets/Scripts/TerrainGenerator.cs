using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    private const float distance_spawn = 50f;

    [SerializeField] private Transform Grid0;
    [SerializeField] private List<Transform> GridList;

    public GameObject player_position;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = Grid0.Find("EndPos").position;
      
        int starting_parts = 2;

        for(int i = 0; i < starting_parts; i++)
        {
            SpawnTerrainPart();
        }
    }

    private void Update()
    {
       if(Vector3.Distance(player_position.transform.position, lastEndPosition) < distance_spawn)
        {
            SpawnTerrainPart();
        }
    }

    private void SpawnTerrainPart()
    {
        Transform chosenGrid = GridList[Random.Range(0, GridList.Count)];
        Transform lastTPT = SpawnTerrainPart(chosenGrid, lastEndPosition);
        lastEndPosition = lastTPT.Find("EndPos").position;
    }

    private Transform SpawnTerrainPart(Transform Grid_part, Vector3 spawnPos)
    {
        Transform terrainPartTransform = Instantiate(Grid_part, spawnPos, Quaternion.identity);
        return terrainPartTransform;
    }
}
