using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace mike.pong
{
    /// <summary>
    /// 場景編輯器：場景切換與結束遊戲
    /// </summary>
    public class SpritewManing : MonoBehaviour
    {
        [SerializeField, Range(0.1f, 3), Header("音效時間")]
        private float soundDuration = 2.0f;

        private string nameSceneToChange;

        //按鈕與程式溝通方式
        //1.定義公開方法
        //2.此腳本掛在遊戲物件上
        //3.按鈕上設定On Click 事件

        /// <summary>
        /// 透過字串切換場景
        /// </summary>
        /// <param name="nameScene"></param>
        public void ChangeScene(string nameScene)
        {
            nameSceneToChange = nameScene;
            Invoke("DelayChangeScene", soundDuration);
        }

        private void DelayChangeScene()
        {
            //print("切換場景");
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameSceneToChange);
        }


        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }

        public void DelayQuit()
        {
             print("結束遊戲");
            Application.Quit();
        }




    }
}
