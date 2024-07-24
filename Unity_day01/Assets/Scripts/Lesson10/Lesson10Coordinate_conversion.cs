﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Vector3.forward);
        #region 一、世界坐标转本地坐标

        // 世界坐标系 转换 为本地坐标系      可以帮助我们大概判断一个相对位置

        // 1.世界坐标系的点 转换 为本地坐标系的点
        // 受缩放影响
        print("转换后的点" + this.transform.InverseTransformPoint(Vector3.forward));

        // 2.世界坐标系的方向 转换 为相对本地坐标系的方向
        // 不受缩放影响
        print("转换后的点" + this.transform.InverseTransformDirection(Vector3.forward));
        // 受缩放影响
        print("转换后的点(受缩放影响)" + this.transform.InverseTransformVector(Vector3.forward));

        #endregion

        #region 二、本地坐标转世界坐标
        // 1.本地坐标系的点 转换 为相对世界坐标系的点 受到缩放影响   (最常用)
        print("本地 转 世界 点" + this.transform.TransformPoint(Vector3.forward));

        // 2.本地坐标系的方向 转换 为相对世界坐标系的方向
        // 不受到缩放影响
        print("本地 转 世界 方法" + this.transform.TransformDirection(Vector3.forward));
        // 受到缩放影响
        print("本地 转 世界 方法" + this.transform.TransformVector(Vector3.forward));
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
        总结：
            最重要 -> 本地坐标系的点 转世界坐标系的点
                eg：现在玩家要在自己面前的n个单位前 放一团火 这个时候 我不用关心世界坐标系
                    通过 相对于本地坐标系的位置 转换为 世界坐标系的点 进行 特效的创建 或者 攻击范围的判断
     */
}
