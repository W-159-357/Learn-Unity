using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson05_Time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region 一、时间缩放比例
        // 1.时间停止
        // Time.timeScale = 0;
        // 2.回复正常
        // Time.timeScale = 1;
        // 3.两倍速
        // Time.timeScale = 2;
        #endregion

        #region 二、帧间隔时间
        // 帧间隔时间:最近的一帧 用了多长时间（秒）
        // 主要用来计算位移     (路程 = 时间 * 速度)
        // 根据需求 选择参与计算的间隔时间 游戏暂停时不动的(delteTime) 不受暂停影响(unscaledDeltaTime)

        // 1.受scale影响
        //print("帧间隔时间：" + Time.deltaTime);

        // 2.不受scale影响的帧间隔时间
        //print("不受影响的帧间隔时间" + Time.unscaledDeltaTime);

        #endregion

        #region 三、游戏开始到现在的时间
        // 主要用来计时   (单机游戏计时)

        // 1.受scale影响
        //print("游戏开始到现在的时间" + Time.time);
        // 2.不受scale影响
        //print("不受scale影响游戏开始到现在的时间" + Time.unscaledTime);

        #endregion



        #region 五、帧数
        // 从开始到现在游戏跑了多少帧（多少次循环）
        print(Time.frameCount);

        #endregion
    }

    private void FixedUpdate()
    {
        #region 四、物理间隔时间 FixedUpdate
        // 1.受scale影响
        print("物理间隔时间" + Time.fixedDeltaTime);

        // 2.不受scale影响
        print("不受scale影响物理间隔时间" + Time.fixedUnscaledDeltaTime);

        #endregion
    }

    /*
     总结
        Time相关的内容
            1.帧间隔时间     用来计算位移相关内容
            2.时间缩放比例   用来暂停 或 倍速等等
            3.帧数（帧同步）
     */
}
