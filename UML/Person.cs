﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///VS中的UML的格式
///抽象类：虚框，字体为斜体
///接口：为绿框
///类：为蓝框，包括属性，方法等

///vs中属性是紫色的方形盒子，属性是黑色的扳手

///类中的成员可以按照类型分组为属性、方法等，也可以按照访问修饰符分组为public、private等

///在每个类图中，可以通过“——▶”看到其父类
///通过“○”表示实现了某个接口


///一个类中含有一个属性是另外的一个类的对象集合，使用“——>->”表示

///在VS的UML中除了继承和实现的关系外，其他的依赖关系，聚合关系，关联关系都是默认没有图示的
///但是，右键可以显示相应的关系
namespace UML
{
    public abstract class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
    }


}
