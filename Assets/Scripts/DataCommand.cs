/***
 * 标题：
 * 控制类
 * 
 * 功能：
 * 属于控制层，接受玩家的输入，进行处理（或者视图层发来的消息）
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
using PureMVC.Patterns.Command;
using UnityEngine;

//using Kernel;
//using Global;

namespace PureMVCDemo {
	/// <summary>
	/// 控制类
	/// </summary>
	public class DataCommand : SimpleCommand {

		private static DataCommand _Instance = null;
		public static DataCommand GetInstance(){
			if (_Instance == null) {
				_Instance = new DataCommand();
			}
			return _Instance;
		}

		/// <summary>
		/// 执行方法
		/// （在调用特定消息时执行）
		/// </summary>
		/// <param name="notification"></param>
		public override void Execute(INotification notification){
			//调用数据层的“增加数字”的方法
			DataProxy proxy = (DataProxy) Facade.RetrieveProxy(DataProxy.NAME);
			proxy.AddNum(10);
		}
	}
}