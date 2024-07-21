using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum E_TestEnum
{
    Normal,
    Player,
    Monster,
    Boss
}

[System.Serializable]
public struct MyStruct
{
    public int age;
    public bool sex;
}

[System.Serializable]
public class MyClass
{
    public int age;
    public bool sex;
}

public class Lesson02_Inspector : MonoBehaviour
{
    #region 一、私有和保护无法显示编辑
    private int i1;
    protected string str1;
    #endregion

    #region 二、让私有和保护的也可以被显示     [SerializeField]
    [SerializeField]
    private int privateInt;
    [SerializeField]
    protected string protectedStr;
    #endregion

    #region 三、公共的可以显示编辑
    public int publicInt = 10;
    public bool publicBool = false;
    #endregion

    #region 四、公共的也不让其显示编辑       [HideInInspector]
    [HideInInspector]
    public int publicInt2 = 20;
    #endregion

    #region 五、大部分类型都能显示编辑
    public int[] array;
    public List<int> list;
    public E_TestEnum type;
    public GameObject gameObj;

    // 不能显示编辑   字典不能被Inspector显示
    public Dictionary<int, int> dict;
    // 自定义类型变量
    public MyStruct myStruct;
    public MyClass myClass;
    #endregion

    #region 六、让自定义类型可以被访问   [System.Serializable]
    // 字典怎么样都不行
    #endregion

    #region 七、一些辅助特性
    // 1.分组说明特性 Header，为成员分组     [Header("分组说明")]
    [Header("基础属性")]
    public int age;
    public bool sex;

    [Header("战斗属性")]
    public int atk;
    public int def;

    // 2.悬停注释 [Tooltip("")]   为变量添加说明
    [Tooltip("闪避")]
    public int miss;

    // 3.间隔特性 [Space()]
    [Space()]
    public int crit;

    // 4.修饰数据的滑条范围  [Range(最小值, 最大值)]
    [Range(0, 10)]
    public float luck;

    // 5.多行显示字符串 默认不写参数显示3行 [Multiline(4)]
    [Multiline(5)]
    public string tips;

    // 6.滚动条显示字符串   [TextArea(3, 4)]    最少显示三行四列 超过四行就显示滚动条
    [TextArea(3, 4)]
    public string myLife;

    // 7.为变量添加快捷方法  [ContextMenuItem("显示按钮名", "方法名")]
    [ContextMenuItem("重置钱", "ResetMoney")]
    public int money;
    private void ResetMoney()   // 必须为无返回值
    {
        money = 99;
    }

    // 8.为方法添加特性能够在Inspector中执行 [ContextMenu("测试函数")]
    [ContextMenu("Click TestFun")]
    private void TestFun()
    {
        print("测试方法");
    }

    #endregion

    #region 八、注意事项
    /*
        1.Inspector窗口中的变量关联的就是对象的成员变量，运行时改变他们就是在改变成员变量
        2.拖拽到GameObject对象后 再改变脚本中变量默认值 界面上不会改变
        3.运行中修改的信息不会保存
    */
    #endregion

    private void Start()
    {
        print(privateInt);
        print(protectedStr);
    }
}
