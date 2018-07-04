/***
 * 标题：
 * 数据代理类
 * 
 * 功能：
 * 属于模型层，数据的各种操作
 * 
 * 用法：
 * 
 * 
 * 思路：
 * 
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns.Proxy;
using UnityEngine;

//using Kernel;
//using Global;

namespace PureMVCDemo {
	/// <summary>
	/// 模型代理类
	/// </summary>
	public class DataProxy : Proxy {

		//声明本类的名称（覆盖父类中的声明）
		public new const string NAME = "DataProxy";
		//引用实体类
		private MyData _MyData = null;


		/// <summary>
		/// 必须定义一个构造函数，继承带有NAME参数的父类构造函数
		/// </summary>
		public DataProxy() : base(NAME){
			//实例化实体类
			_MyData = new MyData();
		}


		/// <summary>
		/// 增加等级
		/// </summary>
		public void AddNum(int num){
			//把参数累加到实体类中
			_MyData.Number += num;
			//把变化后的数据，发送到视图层
			SendNotification(SysDefine.MSG_NAME_AddNum,_MyData);
		}


	}
}