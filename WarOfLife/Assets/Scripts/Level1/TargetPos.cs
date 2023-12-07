using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPos : MonoBehaviour
{
    public void ActiveCollide()
    {
        GetComponent<BoxCollider>().enabled = true;
    }
}
