using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

namespace Utility
{
    public static class Math
    {
        public static float Map
            (float input, float minIn, float maxIn,
            float minOut, float maxOut)
        {
            return (input - minIn) / (maxIn - minIn) * (maxOut - minOut) + minOut;
        }
    }


    public class FloatEventArgs : EventArgs
    {
        public float Value { get; set; }

        public FloatEventArgs(float value)
        {
            this.Value = value;
        }
    }

}
