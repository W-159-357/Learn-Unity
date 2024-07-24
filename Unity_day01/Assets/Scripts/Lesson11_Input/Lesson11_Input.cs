using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_Input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region 注意：输入相关内容肯定是写在 Update 中的
        #endregion

        #region 一、鼠标在屏幕位置
        // 屏幕坐标的远点 实在 屏幕的左下角    往右是X轴正方向 往上是Y轴正方向
        // 返回值为 Vector3 但是只有 x 和 y 有值 z一直是0 是因为屏幕本来就是 2D 的 不存在 Z轴
        // print(Input.mousePosition);

        #endregion


        #region 二、检测鼠标输入
        // 鼠标按下相关检测 对于我们来说
        // eg:  1.可以做 发射子弹
        //      2.可以控制摄像机移动
        //      3.背包拖拽物品

        // 1.鼠标按下一瞬间 进入一次
        // 0:左键 1:右键 2:中键
        if (Input.GetMouseButtonDown(0))
        {
            print("鼠标左键按下了");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            print("鼠标右键按下了");
        }
        else if (Input.GetMouseButtonDown(2))
        {
            print("鼠标中键按下了");
        }

        // 2.鼠标抬起一瞬间 进入
        if (Input.GetMouseButtonUp(0))
        {
            print("鼠标左键抬起了");
        }
        else if (Input.GetMouseButtonUp(1))
        {
            print("鼠标右键抬起了");
        }
        else if (Input.GetMouseButtonUp(2))
        {
            print("鼠标中键抬起了");
        }

        // 3.鼠标长按按下抬起都会进入 (当按住不放时，会一直进入判断)
        if (Input.GetMouseButton(1))
        {
            print("右键按下");
        }

        // 4.中键滚动
        // 返回值的 y -1:下滚动  0：不滚动 1：上滚动   返回值为Vector2 鼠标滚动 会改变其中的y值
        // print(Input.mouseScrollDelta);
        #endregion


        #region 三、检测键盘输入
        // eg:  1.按一个键释放一个技能或者切换武器 等等的操作

        // 1.键盘按下
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W被按下");
        }

        // 2.传入字符串的重载 (不能传入大写字符串，会报错  只能传入小写字符串)
        if (Input.GetKeyDown("q"))
        {
            print("Q被按下");
        }

        // 3.键盘抬起
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("W被抬起");
        }

        // 4.键盘长按
        if (Input.GetKey(KeyCode.W))
        {
            print("W被长按");
        }

        #endregion


        #region 四、检测默认轴输入
        // 学习鼠标、键盘输入    主要用来    -> 控制玩家
        // eg:  旋转  位移....
        // Unity提供了 更方便的方式  来帮助我们控制 对象的 位移和旋转


        // 1.键盘AD按下时  返回  -1 到 1之间的变换 （得到的值，就相当于我们的左右方向  -> 用于控制 对象左右移动 或左右旋转）
        //print(Input.GetAxis("Horizontal"));

        //// 2.键盘WS按下时  返回  -1 到 1之间的变换 （得到的值，就相当于我们的上下方向  -> 用于控制 对象上下移动 或上下旋转）
        //print(Input.GetAxis("Vertical"));

        //// 3.鼠标横向移动时  -1 到 1 左 右
        //print(Input.GetAxis("Mouse X"));

        //// 4.鼠标竖向移动时  -1 到 1 下 上
        //print(Input.GetAxis("Mouse Y"));


        // 默认的 GetAxis 是有渐变的    会在 -1~0~1 之间渐变  会出现小数
        //5. GetAxisRow 和 GetAxis 使用方式相同      只不过 他的返回值 只会是 -1 0 1 不会有中间值
        #endregion


        #region 五、其他
        // 1.是否有任意键或鼠标长按
        if (Input.anyKey)
        {
            print("有一个键被长按");
        }

        // 2.是否有任意键或鼠标按下
        if (Input.anyKeyDown)
        {
            print("有一个键被按下");
            // 3.这一帧的键盘输入
            print(Input.inputString);
        }


        // 4.手柄输入相关
        // 4.1 得到连接的手柄的所有按钮名字
        string[] strs = Input.GetJoystickNames();

        // 4.2 某一个手柄键按下
        if (Input.GetButtonDown("Jump"))
        {

        }

        // 4.3 某一个手柄键长按
        if (Input.GetButtonUp("Jump"))
        {

        }

        // 4.4 某一个手柄键抬起
        if (Input.GetButton("Jump"))
        {

        }


        // 5.移动设备触摸相关
        if (Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];    // 得到第一个手指的信息

            // 位置
            print(t1.position);
            // 相对上次位置的变化
            print(t1.deltaPosition);
        }

        // 5.1 是否启用多点触控
        Input.multiTouchEnabled = true;

        // 5.2 陀螺仪(重力感应)    (必须开启后才能使用)
        Input.gyro.enabled = true;

        // 5.2.1 重力加速度向量
        print(Input.gyro.gravity);

        // 5.2.2 旋转速度
        print(Input.gyro.rotationRate);

        // 5.2.3 陀螺仪 当前的旋转四元数       
        // eg:使用角度信息 来控制 长经商的一个3D物体受到重力影响       ->      手机怎么动 它就怎么动
        print(Input.gyro.attitude);

        #endregion

    }


    /*
        总结：
            Input类  提供了大部分和输入相关的内容
                eg:鼠标、键盘、触屏、手柄、重力感应
            
            对于我们目前来说
                鼠标、键盘 是必须掌握的核心知识
     */
}
