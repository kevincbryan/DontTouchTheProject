﻿using System;
using UnityEngine;

[Serializable]
public class BoolReference
{

    public bool UseConstant = true;
    public bool ConstantValue;
    public BoolVariable Variable;

    public bool Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
        set
        {
            if (UseConstant)
            {
                ConstantValue = value;
            }
            else
            {
                Variable.Value = value;
            }
        }
    }
}
