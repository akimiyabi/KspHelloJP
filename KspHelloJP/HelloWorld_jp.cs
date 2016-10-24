using UnityEngine;

namespace KspHelloJP
{

    /// <summary>
    /// EditorAny
    /// </summary>
    /// <remarks>
    /// Editorに入った時
    /// </remarks>
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    public class TestWindow : MonoBehaviour
    {

        public static int howmanytimes = 0;
        public static bool canview = true;

        /// <summary>
        /// start
        /// </summary>
        void Start()
        {
        }

        /// <summary>
        /// Update
        /// </summary>
        void Update()
        {
            if (canview == false || howmanytimes > 2)
            {
                //表示済み or 表示回数上限
                return;
            }

            //window表示オブジェクト
            ScreenMessages.PostScreenMessage("今日はKerbal!");
            ScreenMessages.PostScreenMessage(howmanytimes.ToString());

            canview = false;
            howmanytimes++;
        }

        /// <summary>
        /// OnGUI
        /// </summary>
        void OnGUI()
        {
        }
    }

    /// <summary>
    /// SpaceCentre 
    /// </summary>
    /// <remarks>
    /// SpaceCentreに入った時表示許可を初期化
    /// </remarks>
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    public class TestWindowSC : MonoBehaviour
    {
        
        /// <summary>
        /// start
        /// </summary>
        void Start()
        {
            if (!TestWindow.canview)
                TestWindow.canview = true;
        }

        /// <summary>
        /// Update
        /// </summary>
        void Update()
        {
        }

        /// <summary>
        /// OnGUI
        /// </summary>
        void OnGUI()
        {
        }
    }
}

