using System;
using UnityEngine;

public class EventSample2 : MonoBehaviour
{
    void Start()
    {
        EventSample event_sample = GetComponent<EventSample>();
        event_sample.OnSpaceEnter += OnSpaceButton;
    }

    private void OnSpaceButton(object sender, EventArgs e)
    {
        Debug.Log("<color=blue>Space</color>");
    }
}
