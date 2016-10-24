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
        void start()
        {
        }

        /// <summary>
        /// Update
        /// </summary>
        void Update()
        {
            if (canview == false)
            {
                //表示済みのため何もしない
                return;
            }
            if (howmanytimes > 2)
            {
                //表示回数に達したため、何もしない
                return;
            }

            //window表示オブジェクト
            ScreenMessages.PostScreenMessage("今日はKerbal!");
            ScreenMessages.PostScreenMessage(howmanytimes.ToString());

            canview = false;
            howmanytimes++;

            return;
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
        void start()
        {
        }

        /// <summary>
        /// Update
        /// </summary>
        void Update()
        {

            if (TestWindow.canview == true)
            {
                //初期化済みのため、何もしない
                return;
            }

            TestWindow.canview = true;

        }

        /// <summary>
        /// OnGUI
        /// </summary>
        void OnGUI()
        {
        }
    }
}

