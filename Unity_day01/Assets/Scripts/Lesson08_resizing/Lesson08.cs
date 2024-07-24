using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson08 : MonoBehaviour
{
    public Transform lookAtObj;

    // Start is called before the first frame update
    void Start()
    {
        #region 一、缩放
        // 相对世界坐标系
        print(this.transform.lossyScale);

        // 相对于本地坐标系（父对象）
        print(this.transform.localScale);

        /*
         注意：
            1.缩放只能同时修改x、y、z(相对于世界坐标系的缩放大小只能得 不能改)
              所以一般修改缩放大小 都是改的 相对于父对象的 缩放大小 localScale
                this.transform.localScale = new Vector3(3, 3, 3);
            
            2.Unity没有提供关于缩放的 API
              如果想要让 缩放 发生变化 自能自己去写（自己算）
         */

        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        // 2.Unity没有提供关于缩放的 API
        // 如果想要让 缩放 发生变化 自能自己去写（自己算）
        // this.transform.localScale += Vector3.one * Time.deltaTime;

        #region 二、看向
        // 让一个和对象的面朝向 可以一直看向某一个点或者某一个对象
        // 1.看向一个点
        // this.transform.LookAt(Vector3.zero);

        // 2.看向一个对象 (传入一个对象的 transform 信息)
        this.transform.LookAt(lookAtObj);

        #endregion
    }

    /*
        总结：
            缩放：
            相对于 世界坐标系的缩放 只能得 不能改
            只能去修改相对于本地坐标系的缩放 （相对于父对象）
            没有提供对应的 API 来 缩放变化 只能自己算
            
            朝向:
            LookAt  看向一个点   或者  看向一个对象
            一定记得    是写再 Update 里面 才能不停变化
            
     */
}
