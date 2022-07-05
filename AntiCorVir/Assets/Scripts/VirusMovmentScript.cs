using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Скрипт движения вируса
/// </summary>
public class VirusMovmentScript : MonoBehaviour
{
    [SerializeField] private GameFieldScript gameField;
    [SerializeField] private float speed;

    private float FieldX;
    private float FieldZ;
   
    private Vector3 targetPointPos;    
    
    void Start()
    {        
        GameFieldScale();
        targetPointPos = gameObject.GetComponent<MovePointsScript>().TargetPointPosition(FieldX, FieldZ);        
    }

   
    void FixedUpdate()
    {
        VirusMove();
    }

/// <summary>
/// Возвращает размеры игрового поля
/// </summary>
    private void GameFieldScale()
    {
        FieldX = gameField.FieldScaleX();       
        FieldZ = gameField.FieldScaleZ();
    }

    /// <summary>
    /// Движение от точки к точке
    /// </summary>
    private void VirusMove()
    {
        if (transform.position != targetPointPos) transform.position = Vector3.MoveTowards(transform.position, targetPointPos, speed * Time.deltaTime);

        else targetPointPos = gameObject.GetComponent<MovePointsScript>().TargetPointPosition(FieldX, FieldZ); //задает новую случайную позицию для точки
    }    
}
