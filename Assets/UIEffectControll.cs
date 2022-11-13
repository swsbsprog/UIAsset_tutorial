using Coffee.UIEffects;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEffectControll : MonoBehaviour
{

    [Button]
    public void SetActiveEffect()
    {
        UIEffect uIEffect = GetComponent<UIEffect>();
        uIEffect.effectFactor = 0;
        uIEffect.blurFactor = 0;
    }
    [Button("비활성화")]
    public void SetDeactiveEffect()
    {
        UIEffect uIEffect = GetComponent<UIEffect>();
        uIEffect.effectFactor = 1;
        uIEffect.blurFactor = 1;
    }
    [Button("비활성화 애니메이션")]
    public void SetDeactiveEffectAnimation()
    {
        GetComponent<Animator>().Play("Deactive");
    }
}
