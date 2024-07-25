using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 一、静态属性

        #region 常用
        // 1.当前屏幕分辨率
        Resolution r = Screen.currentResolution;
        print("当前屏幕分辨率的宽:" + r.width + ", 高:" + r.height);

        // 2.屏幕窗口当前宽高   (得到的为当前窗口宽高 不是设备分辨率的宽高)
        print(Screen.width);
        print(Screen.height);

        // 3.屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        #endregion

        #region 不常用
        // 4.运行时是否全屏模式
        Screen.fullScreen = true;

        /*
           5. 窗口模式
                独占全屏        FullScreenMode.ExclusiveFullScreen
                全屏窗口        FullScreenMode.FullScreenWindow
                最大化窗口      FullScreenMode.MaximizedWindow
                窗口模式        FullScreenMode.Windowed;
         */
        Screen.fullScreenMode = FullScreenMode.Windowed;

        // 6.移动设备屏幕转向相关
        // 允许自动旋转为左横向   Home键在左
        Screen.autorotateToLandscapeLeft = true;
        // 允许自动旋转为右横向   Home键在右
        Screen.autorotateToLandscapeRight = true;
        // 允许自动旋转到纵向    Home键在下
        Screen.autorotateToPortrait = true;
        // 允许自动旋转到纵向倒着看   Home键在上
        Screen.autorotateToPortraitUpsideDown = true;

        // 指定屏幕显示方向
        Screen.orientation = ScreenOrientation.AutoRotation;
        #endregion

        #endregion

        #region 二、静态方法
        // 设置分辨率    一般移动设备不使用   最后参数为是否全屏
        Screen.SetResolution(1920, 1080, false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
