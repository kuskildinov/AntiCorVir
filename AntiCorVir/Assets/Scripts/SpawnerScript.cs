using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private float spawnTime;
    [SerializeField] private VirusScript[] virusPrefab;
    [SerializeField] private GameFieldScript gameField;

    private float timer;
    private Vector3 spawnPos;

    private float FieldX;    
    private float FieldZ;

    void Start()
    {
        FieldX = gameField.FieldScaleX();
        FieldZ = gameField.FieldScaleZ();
    }
    void FixedUpdate()
    {
        spawnPos = new Vector3(Random.Range(-FieldX, FieldX) ,0.0f, Random.Range(-FieldZ, FieldZ));
        timer += Time.deltaTime;
        if(timer >= spawnTime)
        {
            VirusScript newVirus = Instantiate(virusPrefab[Random.Range(0, virusPrefab.Length)], spawnPos, Quaternion.identity);
            timer = 0;
        }
    }
}
