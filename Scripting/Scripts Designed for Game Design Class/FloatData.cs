﻿using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
 public float value;
 
 public void modifyValue(float f)
 {
     value += f;
 }

 public void resetValue(float f)
 {
     value = f;
 }
 
}
