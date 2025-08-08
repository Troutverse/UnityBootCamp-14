using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DTrigger : MonoBehaviour
{
    public List<Dialog> scripts;
    
    public void OnDTriggerEnter()
    {
        if (scripts != null && scripts.Count > 0)
        {
            DialogManger.Instance.StartLine(scripts);
        }
    }
}
