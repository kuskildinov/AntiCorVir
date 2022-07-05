using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Возвращает рандомную позицию точки движения на игровом поле
/// </summary>
public class MovePointsScript : MonoBehaviour
{
    private Vector3 targetPointPos;        
       
    /// <summary>
    /// Возвращет координаты текущей точки движения
    /// </summary>
    /// <returns></returns>
    public Vector3 TargetPointPosition(float x, float z)
    { 
        targetPointPos = new Vector3(Random.Range(-x, x ), 0.2f, Random.Range(-z , z));
        return targetPointPos;
    }

}
