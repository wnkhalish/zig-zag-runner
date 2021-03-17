using UnityEngine;
using System.Collections;

public abstract class Controller : MonoBehaviour
{    public abstract Vector3 GetInput();

    public abstract bool IsConnected { get; }

}
