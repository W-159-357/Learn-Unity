using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson04_GameObj : MonoBehaviour
{
    /*
        准备用来克隆的对象
            1.直接是场景的某个对象
            2.可以是一个预设体对象
     */
    public GameObject myObj;

    public GameObject myObj2;

    // Start is called before the first frame update
    void Start()
    {
        #region 一、GameObject中的成员变量
        // 1.名字
        print(this.gameObject.name);
        this.gameObject.name = "Lesson04_最小单位";
        print(this.gameObject.name);

        // 2.激活状态
        print(this.gameObject.activeSelf);

        // 3.是否是静态
        print(this.gameObject.isStatic);

        // 4.层级
        print(this.gameObject.layer);

        // 5.标签
        print(this.gameObject.tag);

        // 6.transfrom  (位置信息)
        print(this.transform.position);     // 也可以 this.gameObject.transform.position

        #endregion

        #region 二、GameObject的静态方法
        // 1.创建自带集合体    (只要得到了一个GameObject对象，就可以得到它身上的所有信息)
        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj1.name = "新创建的物体";

        // 2.查找对象
        // 2.1.查找单个对象   (无法找到失活对象)
        // 2.1.1.通过对象名查找    (效率较低，查找场景中的所有对象)
        GameObject obj2 = GameObject.Find("TTT");
        if(obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("没有找到这个GameObject !");
        }

        // 2.1.2.通过tag查找
        GameObject obj3 = GameObject.FindWithTag("Monster");
        if (obj3 != null)
        {
            print("根据tag找的对象" + obj3.name);
        }
        else
        {
            print("没有找到这个GameObject !");
        }

        // 2.2.查找多个对象
        // 2.2.1.找多个对象 只能通过tag去找 通过名字 没有找多个的方法
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Monster");
        print("通过tag找到的对象的数量为: " + objs.Length);

        // 3.实例化对象（克隆对象）
        // 根据一个GameObject对象 创建出一个和它一样的对象
        // 如果继承了 MonoBehavior 可以不用写 GameObject一样可以使用
        GameObject obj4 = Instantiate(myObj);             // GameObject.Instantiate(obj);

        /*
           4.删除对象   Destroy("要删除的对象", 删除延迟时间)
                作用：
                    1.删除指定的一个游戏对象
                    2.删除指定的一个脚本对象
         */
        GameObject.Destroy(obj4, 5);
        GameObject.Destroy(myObj2);
        // Destroy 还可以删除对象挂载的脚本
        // GameObject.Destroy(this);
        // 如果没有特殊需要     不要使用 DestroyImmediate() 方法

        // 5.过场景不移除
        // 默认情况下 在切换场景时 场景中的对象都会被自动删除掉
        // 不想谁在过场景被移除 就在下面代码中传谁 一般都是传依附的 GameObject 对象
        GameObject.DontDestroyOnLoad(this.gameObject);

        #endregion

        #region 三、GameObject中的成员方法
        // 1.创建空物体
        GameObject obj5 = new GameObject();
        GameObject obj6 = new GameObject("新创建的空物体 obj6");
        GameObject obj7 = new GameObject("顺便加脚本的空物体 obj7 ", typeof(Lesson02_Inspector), typeof(Lesson01_));

        // 2.为对象添加脚本    (通过返回值 可以得到加入的脚本信息 来进行一些处理)
        Lesson02_Inspector les2 = obj6.AddComponent<Lesson02_Inspector>();

        // 3.得到脚本的方法和继承 MonoBehaviour 类的发放一样 

        // 4.标签比较
        if (this.gameObject.CompareTag("Monster"))
        {
            print("对象的标签是 Monster");
        }

        // 5.设置激活失活     true -> 激活  false -> 失活
        obj7.SetActive(false);


        // 次要的成员方法  *不建议使用
        // 通过广播或发送消息的形式 让自己或者别人 执行某些行为方法
        // 通知自己 执行传入的函数（TestFun）自己身上所有挂载的脚本都会执行
        this.gameObject.SendMessage("TestFun");
        this.gameObject.SendMessage("TestFun2", 99);

        //this.gameObject.BroadcastMessage("函数名");      让自己和自己的子对象都执行
        //this.gameObject.SendMessageUpwards("函数名");    让自己和自己的父对象都执行

        #endregion
    }

    public void TestFun()
    {
        print("Lesson04的TestFun");
    }

    public void TestFun2(int a)
    {
        print("Lesson04的TestFun2 " + a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
        总结：
            GameObject的常用内容
                基本成员变量
                    1.名字    失活激活装填  标签  层级....
                
                静态方法有关
                    1.创建自带几何体
                    2.查找场景中对象
                    3.实例化对象
                    4.删除对象
                    5.过场景不移除
                
                成员方法
                    1.为对象动态添加指定脚本
                    2.设置失活激活状态
                    3.和MonoBehavior中相同的 得到脚本相关的方法
     */
}
