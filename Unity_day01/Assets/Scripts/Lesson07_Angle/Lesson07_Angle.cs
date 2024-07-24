using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson07_Angle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 一、角度
        // 相对世界坐标角度
        print(this.transform.eulerAngles);

        // 相对父对象角度
        print(this.transform.localEulerAngles);

        // 注意：设置角度和设置位置一样 不能单独设置x、y、z 要一起设置
        // this.transform.localEulerAngles = new Vector3(10, 10, 10);
        print(this.transform.localEulerAngles);

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        #region 二、旋转相关
        // 1.自己计算 和位置一样  不停改变角度即可

        // 2.API    Rotate
        // 自转  每个轴具体转多少度   参数一: 旋转角度   参数二：参考坐标系
        // this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        // this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.World);

        // 相对于某个轴 转多少度
        // 参数一：相对哪个轴转动      参数二：旋转的角度       参数三：参考坐标系
        // this.transform.Rotate(Vector3.right, 10 * Time.deltaTime);
        // this.transform.Rotate(Vector3.right, 10 * Time.deltaTime, Space.World);

        // 相对于某一个点转     RotateAround
        // 参数一：围绕哪一个点       参数二：相对哪个轴转队     参数三：旋转角度 （旋转速度 * 时间）
        this.transform.RotateAround(Vector3.zero, Vector3.right, 10 * Time.deltaTime);
        #endregion

    }

    /*
        总结
            角度相关和位置相关 差不多
            1.如何得到角度
                通过 transform 可以得到相对于世界坐标系和相对于父对象的
            
            2.如何自传和绕着别人转
                Rotate      
                RotateAround
     */
}
