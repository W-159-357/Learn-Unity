using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01_ : MonoBehaviour
{
    // 对象被创建时调用，才能调用该生命周期函数(类似构造函数)
    protected virtual void Awake()
    {
        // 1.没有继承 MonoBehaviour 类
        //Debug.Log("Awake is running !");
        //Debug.LogError("It is Error !");
        //Debug.LogWarning("It is Warning !");

        // 2.继承了 MonoBehaviour 有一个线程的方法 可以使用
        print("Awake !!");
    }

    // 想要当一个对象被激活时 进行一些逻辑处理
    private void OnEnable()
    {
        print("OnEnable !!");
    }

    // 在对象 进行第一次帧更新前才执行
    void Start()
    {
        print("Start !!");
    }

    // 物理更新
    private void FixedUpdate()
    {
        print("FixedUpdate !!");
    }

    // 主要用于处理游戏核心逻辑更新
    void Update()
    {
        print("Update !!");
    }

    // 一般用于更新摄像机位置  （处理我们动画相关的更新）
    private void LateUpdate()
    {
        print("LateUpdate !!");
    }

    // 在对象失活时做一些处理
    private void OnDisable()
    {
        print("OnDisable !!");
    }

    // 对象删除时
    private void OnDestroy()
    {
        print("OnDestroy !!");
    }

    #region 支持封装、继承、多态

    #endregion

    /*
        1.如果不用，就不能写生命周期函数
    */

}
