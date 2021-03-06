﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    [CreateAssetMenu(menuName = ("RPG/Special Ability/Area Effect"))]
    public class AreaEffectConfig : AbilityConfig
    {

        [Header("Area Effect Specific")]
        [SerializeField] float damageToEachTarget = 15f;
        [SerializeField] float areaEffectRadius = 10f;

        public override AbilityBehaviour GetBehaviourComponent(GameObject objectToAttachTo)
        {
            return objectToAttachTo.AddComponent<AreaEffectBehaviour>();
        }


        public float GetDamageToEachTarget()
        {
            return damageToEachTarget;
        }

        public float GetAreaEffectRadius()
        {
            return areaEffectRadius;
        }
    }
}
