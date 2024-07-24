using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public Transform son;

    // Start is called before the first frame update
    void Start()
    {
        #region 一、获取和设置父对象
        // 获取父对象
        // print(this.transform.parent.name);

        // 设置父对象 断绝父子关系
        // this.transform.parent = null;

        // 设置父对象
        // this.transform.parent = GameObject.Find("Father2").transform;

        // 通过 API 来进行父子关系的设置    SetParent
        // this.transform.SetParent(null);
        // this.transform.SetParent(GameObject.Find("Father2").transform);

        // 参数一：要设置的父对象      参数二：是否保留世界坐标的 位置 角度 缩放 信息
        //      true  会保留 世界坐标系下的状态 和 父对象 进行计算 得到本地坐标系的信息
        //      false 不会保留 会直接把世界坐标系下的 位置角度缩放 直接赋值到 本地坐标系下
        // this.transform.SetParent(GameObject.Find("Father3").transform, true);
        #endregion

        #region 二、抛妻弃子
        // this.transform.DetachChildren();    // 与所有的子对象断开连接
        #endregion

        #region 三、获取子对象
        // 按名字查找儿子      Find方法 可以找到失活对象     GmaeObject相关 查找 无法找到失活对象
        print(this.transform.Find("Cube (1)").name);
        // 只能找到自己的儿子对象
        // print(this.transform.Find("GameObject").name);
        // 虽然他的效率 比GameObject.Find相比 要高一些 但是 前提是你必须知道父亲是谁 才能找

        // 遍历儿子
        // 1.如果得到有多少个儿子     (失活的也会统计)
        print(this.transform.childCount);
        // 2.通过索引号 去得到自己对应的儿子
        this.transform.GetChild(0);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            print("儿子的名字" + this.transform.GetChild(i).name);
        }

        #endregion

        #region 四、儿子的操作
        // 1.判断自己的爸爸是谁 (一个对象 判断自己是不是另一个对象的儿子)
        if (son.IsChildOf(this.transform))
        {
            print("是我的儿子");
        }

        // 2.得到自己作为儿子的编号
        print(son.GetSiblingIndex());

        // 3.把自己设置为第一个儿子
        son.SetAsFirstSibling();

        // 4.把自己设置为最后一个儿子
        son.SetAsLastSibling();

        // 5.把自己设置为指定的儿子    (如果索引溢出，会被设置为最后一个儿子)
        son.SetSiblingIndex(5);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
        总结：
            1.设置父对象相关的内容
            2.获取子对象
            
            3.抛妻弃子
            4.儿子的操作
     */
}
