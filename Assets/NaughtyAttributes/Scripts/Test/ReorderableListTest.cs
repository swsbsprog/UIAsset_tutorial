using System.Collections.Generic;
using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ReorderableListTest : MonoBehaviour
    {
        public int[] intArray1;
        public GameObject[] gameObjectsList1;
        [ReorderableList]
        public int[] intArray;

        [ReorderableList]
        public List<Vector3> vectorList;

        [ReorderableList]
        public List<SomeStruct> structList;

        [ReorderableList]
        public GameObject[] gameObjectsList;

        [ReorderableList]
        public List<Transform> transformsList;

        [ReorderableList]
        public List<MonoBehaviour> monoBehavioursList;
    }

    [System.Serializable]
    public struct SomeStruct
    {
        public int Int;
        public float Float;
        public Vector3 Vector;
    }
}
