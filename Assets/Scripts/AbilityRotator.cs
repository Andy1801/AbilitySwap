﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Change with timer classes when implemented 
public class AbilityRotator : MonoBehaviour
{
    public int abilityTimerThreshold;
    private Timer timer;
    private bool rotateAbility;

    void Start()
    {
        timer = new Timer(abilityTimerThreshold);
        timer.StartTimer();
        rotateAbility = false;
    }

    void Update()
    {

        if (timer.getTimerStatus())
        {
            rotateAbility = true;
            timer.StartTimer();
        }
    }

    public IAbilities GetAbilities()
    {
        if (rotateAbility)
        {
            rotateAbility = false;
            return AbilityFactory.getRandomAbilities();
        }

        return null;
    }
}
