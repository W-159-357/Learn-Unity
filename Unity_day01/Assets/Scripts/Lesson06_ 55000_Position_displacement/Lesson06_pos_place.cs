using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson06_pos_place : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Transform用处
        // GameObject 位移、旋转、缩放、父子关系、坐标转换等相关操作都由它处理
        #endregion

        #region 一、Vector3
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;
        // 只传 x、y,则 z 默认为0
        Vector3 v2 = new Vector3(10, 10);
        Vector3 v3 = new Vector3(10, 10, 10);

        // Vector3 的 基本计算 + - * /
        Vector3 v1 = new Vector3(1, 1, 1);
        Vector3 v12 = new Vector3(2, 2, 2);
        print(v1 + v12);
        print(v1 - v12);
        print(v1 * 10);
        print(v2 / 2);

        // 常用
        print(Vector3.zero);        // 000
        print(Vector3.right);       // 100
        print(Vector3.left);        // -100
        print(Vector3.forward);     // 001
        print(Vector3.back);        // 00-1
        print(Vector3.up);          // 010
        print(Vector3.down);        // 0-10

        // 计算两个点之间的距离
        print(Vector3.Distance(v1, v12));
        #endregion

        #region 二、位置
        // 1.相对世界坐标系
        print(this.transform.position);

        // 2.相对父对象(本地坐标系)  (这两个坐标很重要   以面试标准为基础 -> localPosition)
        print(this.transform.localPosition);

        // 注意：位置的赋值不能直接改变x,y,z 只能整体改变
        this.transform.position = new Vector3(10, 0, 5);
        this.transform.localPosition = Vector3.up * 10;
        print(this.transform.position);
        print(this.transform.localPosition);
        // 如果只想改一个坐标，其他坐标不变
        // 2.1.直接赋值
        this.transform.position = new Vector3(7, this.transform.position.y, this.transform.position.z);
        // 2.2.先取出来 再赋值
        Vector3 vPos = this.transform.localPosition;
        vPos.x = 6;
        this.transform.localPosition = vPos;

        // 3.对象当前的各朝向   （得到对象当前的一个朝向   用transform. 出来）
        // 3.1.当前对象的面朝向
        print(this.transform.forward);
        // 3.2.当前对象的头顶朝向
        print(this.transform.up);
        // 3.3 当前对象的右手边
        print(this.transform.right);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 三、位移
        // 坐标系下的位移计算公式  （路程 = 方向 * 速度 * 时间）

        // 方法一. 自己计算    (当前位置 + 位移的距离 = 最终位置)
        // this.transform.position = this.transform.forward * 1 * Time.deltaTime;
        // this.transform.position += Vector3.forward * 1 * Time.deltaTime;

        // 方法二. API
        // 参数一：表示位移多少       （路程 = 方向 * 速度 * 时间）
        // 参数二：表示 相对坐标系

        // 1.相对于世界坐标系的 Z轴 动       （始终是朝 世界坐标系 的 Z轴方向移动）
        // this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.World);

        // 2.相对于世界坐标的 自己的面朝向去动        （始终朝自己的面朝向移动）
        // this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);

        // 3.相对于自己坐标的 下的 自己的面朝向移动       （一定不会这样让物体移动）   XXXX
        // this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.Self);

        // 4.相对于自己坐标的 下的 Z轴正方向朝向移动      (始终朝自己的面朝向移动)
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.Self);

        // 注意：一般使用API来进行位移
        #endregion

    }

    /*
        总结
            Vector3
                1.申明  
                2.提供的常用静态属性
                3.计算距离的方法
     */
}
