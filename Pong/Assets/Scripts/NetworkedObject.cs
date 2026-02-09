using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NetworkedObject : MonoBehaviour
{
    protected abstract void Initialize();
    protected abstract int GetNetworkId();
}