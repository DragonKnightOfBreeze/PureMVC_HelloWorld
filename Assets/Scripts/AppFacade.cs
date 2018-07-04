/***
 * 标题：
 * 全局管理类（Facade：外观）
 * 
 * 功能：
 * PureMVC项目控制类
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
using PureMVC.Interfaces;
using PureMVC.Patterns.Facade;
using UnityEngine;

//using Kernel;
//using Global;

namespace PureMVCDemo {
	/// <summary>
	/// 全局管理类
	/// </summary>
	public class AppFacade : Facade {

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="goRootNode">UI界面的根结点</param>
		public AppFacade(GameObject goRootNode){
			/* MVC三层的关联绑定 */

			//控制层注册（命令消息与控制层类的对应关系，建立消息绑定）
			//只要调用这个消息，就能执行命令层的Execute()方法

			RegisterCommand(SysDefine.REG_NAME_StartDataCommand,DataCommand.GetInstance);
			//视图层注册（把类的对象注册到框架里面）
			RegisterMediator(new DataMediator(goRootNode));
			//模型层注册（把类的对象注册到框架里面）
			RegisterProxy(new DataProxy());
			

		}


	}
}