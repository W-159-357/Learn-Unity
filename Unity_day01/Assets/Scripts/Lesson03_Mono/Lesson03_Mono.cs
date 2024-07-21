using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson03_Mono : MonoBehaviour
{
    public Lesson03_Mono otherLesson03;

    // Start is called before the first frame update
    void Start()
    {
        #region 一、重要成员

        // 1.获取依附的GameObject
        print(this.gameObject.name);

        // 2.获取GameObject的依附信息
        print(this.transform.position);     // 位置
        print(this.transform.eulerAngles);  // 旋转角度
        print(this.transform.lossyScale);   // 缩放大小
        //print(this.gameObject.transform);

        // 3.获取脚本是否激活
        this.enabled = true;

        // 获取别的脚本对象 依附的gameObject和 transform位置信息
        print(otherLesson03.gameObject.name);
        print(otherLesson03.transform.position);

        #endregion

        #region 二、重要方法

        // 得到依附对象上挂在的其他脚本

        // 1.得到自己挂在的单个脚本
        // 1.1 根据脚本名    如果获取失败，默认返回为空
        Lesson03_Test t =  this.GetComponent("Lesson03_Test") as Lesson03_Test;
        print(t);

        // 1.2 根据Type获取
        t = this.GetComponent(typeof(Lesson03_Test)) as Lesson03_Test;
        print(t);

        // 1.3 根据泛型获取（建议）不需要二次转换
        t = this.GetComponent<Lesson03_Test>();
        print(t);

        // 只要你能得到场景中别的对象或者对象依附的脚本，就可以获取到他的所有信息

        // 2. 得到自己挂载的多个脚本
        Lesson03_Mono[] array = this.GetComponents<Lesson03_Mono>();
        print(array.Length);

        List<Lesson03_Mono> list = new List<Lesson03_Mono>();
        this.GetComponents<Lesson03_Mono>(list);
        print(list.Count);

        // 3. 得到子对象挂载的脚本（默认会找自己身上是否挂载该脚本）
        // 3.1 函数参数默认不传是 false ：如果子对象失活 是不会去找这个对象， 如果为 true  失活也会寻找
        t = this.GetComponentInChildren<Lesson03_Test>(true);
        print(t);

        // 3.2 得子对象 挂载脚本 单个
        Lesson03_Test[] lts = this.GetComponentsInChildren<Lesson03_Test>(true);
        print(lts.Length);

        // 3.3 得子对象 挂载脚本 多个
        List<Lesson03_Test> list2 = new List<Lesson03_Test>();
        this.GetComponentsInChildren<Lesson03_Test>(true, list2);
        print(list2.Count);

        // 4. 得到父对象挂载的脚本
        t = this.GetComponentInParent<Lesson03_Test>();
        print(t);

        lts = this.GetComponentsInParent<Lesson03_Test>();
        print(lts.Length);

        // 5. 尝试获取脚本
        Lesson03_Test l3t;
        if (this.TryGetComponent<Lesson03_Test>(out l3t))
        { 
            print(l3t);
        }
        


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
