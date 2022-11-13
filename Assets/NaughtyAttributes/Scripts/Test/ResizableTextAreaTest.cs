using UnityEngine;

namespace NaughtyAttributes.Test
{
    public class ResizableTextAreaTest : MonoBehaviour
    {
        public string defaultText0;

        [TextArea]
        public string defaultText1;

        [ResizableTextArea]
        public string text0;

        public ResizableTextAreaNest1 nest1;
    }

    [System.Serializable]
    public class ResizableTextAreaNest1
    {
        [ResizableTextArea]
        public string text1;

        public ResizableTextAreaNest2 nest2;
    }

    [System.Serializable]
    public class ResizableTextAreaNest2
    {
        [ResizableTextArea]
        public string text2;
    }
}
