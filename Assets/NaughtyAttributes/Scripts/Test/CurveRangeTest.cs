using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class CurveRangeTest : MonoBehaviour
    {
        public AnimationCurve defaultCurves; 

        public void Update()
        {
            var pos = transform.position;
            pos.y = defaultCurves.Evaluate(Time.time);
            transform.position = pos;
        }

        [CurveRange(0f, 0f, 1f, 1f, EColor.Yellow)]
        public AnimationCurve[] curves;

        [CurveRange(-1, -1, 1, 1, EColor.Red)]
        public AnimationCurve curve;

        [CurveRange(EColor.Orange)]
        public AnimationCurve curve1;

        [CurveRange(0, 0, 10, 10)]
        public AnimationCurve curve2;

        public CurveRangeNest1 nest1;

        [System.Serializable]
        public class CurveRangeNest1
        {
            [CurveRange(0, 0, 1, 1, EColor.Green)]
            public AnimationCurve curve;

            public CurveRangeNest2 nest2;
        }

        [System.Serializable]
        public class CurveRangeNest2
        {
            [CurveRange(0, 0, 5, 5, EColor.Blue)]
            public AnimationCurve curve;
        }
    }
}
