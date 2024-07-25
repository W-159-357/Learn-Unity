using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_CameraCode : MonoBehaviour
{
    public Transform obj;

    // Start is called before the first frame update
    void Start()
    {
        #region 一、重要静态成员
        // 1.获取摄像机
        // 获取主摄像机   (必须有一个 tag 为 MainCamera 的摄像机)
        print(Camera.main.name);
        // 获取摄像机的数量
        print(Camera.allCamerasCount);
        // 得到所有的摄像机
        Camera[] cameras = Camera.allCameras;
        print(cameras.Length);

        // 2.渲染相关委托
        // 摄像机  剔除前处理的委托函数
        Camera.onPreCull += (c) => { };
        // 摄像机  渲染前处理的委托
        Camera.onPreRender += (c) => { };
        // 摄像机  渲染后处理的委托
        Camera.onPostRender += (c) => { };

        #endregion


        #region 二、重要成员
        // 1.界面上的参数 都可以在Camera中获取到  depth 为其中一个参数
        Camera.main.depth = 3;

        // 2.世界坐标转屏幕坐标
        // 转换过后 x和y 对应的就是在Game里面的坐标 z 对应的是 这个3D物体离我们摄像机的距离
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);

        // 3.屏幕坐标转世界坐标
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        // 3.屏幕坐标转世界坐标
        // 如果不改变 Z轴 转换过去的世界坐标系的点 永远都是一个点  （可以理解为 视口 相交的焦点）
        // 如果改变了 Z轴 那么转换过去的世界坐标系的点 就是相当于 摄像头前方多少的单位的横截面上的世界坐标点
        Vector3 VMousePos = Input.mousePosition;
        VMousePos.z = 5;
        obj.position = Camera.main.ScreenToWorldPoint(VMousePos);
    }
}
