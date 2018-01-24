﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventShake : _BaseLogicEvent {
    float time = .4f;
    float strength = 8f;
    float speed = 5f;

    public static EventShake c(float time = .4f)
    {
        return new EventShake() { time = time };
    }

    public static EventShake c(float strength = 8f, float speed = 5f, float time = .4f)
    {
        return new EventShake() { strength = strength, time = time };
    }

    public override IEnumerator Execute()
    {
        KeepCameraInBounds.instance.StartShake(strength / 8f, speed, time);

        yield return null;
    }
}