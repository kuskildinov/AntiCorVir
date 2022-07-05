using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Поверхность, на которой спавнятся вирусы
/// </summary>
public class GameFieldScript : MonoBehaviour
{
    private float scaleX;
    private float scaleY;
    private float scaleZ;

    private void Start()
    {
        scaleX = gameObject.transform.localScale.x;        
        scaleY = gameObject.transform.localScale.y;
        scaleZ = gameObject.transform.localScale.z;
    }

    /// <summary>
    /// Расстояние от цента до края платформы по Х
    /// </summary>
    /// <returns></returns>
    public float FieldScaleX()
    {
        Debug.Log(scaleX);
        return scaleX/2;
    }

    /// <summary>
    /// Расстояние от цента до края платформы по Y
    /// </summary>
    /// <returns></returns>
    public float FieldScaleY()
    {
        return scaleY/2;
    }

    /// <summary>
    /// Расстояние от цента до края платформы по Z
    /// </summary>
    /// <returns></returns>
    public float FieldScaleZ()
    {
        return scaleZ/2;
    }
}
