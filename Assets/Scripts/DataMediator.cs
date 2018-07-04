 /***
 * 标题：
 * 视图类
 * 
 * 功能：
 * 属于视图层，显示玩家UI页面
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
using System.Linq;
using PureMVC.Patterns.Mediator;
using UnityEngine;
using UnityEngine.UI;

using Kernel;
using PureMVC.Interfaces;

//using Global;

namespace PureMVCDemo {
	/// <summary>
	/// 视图类
	/// </summary>
	public class DataMediator : Mediator {

		//定义类的名称
		public new const string NAME = "DataMediator";
		//定义两个显示的控件
		private Text Txt_Num;		//显示数字
		private Button Btn_Count;	//增加数字


		/// <summary>
		/// 必须定义一个构造函数，继承带有NAME参数的父类构造函数
		/// </summary>
		/// <param name="goRootNode">界面UI的根节点</param>
		public DataMediator(GameObject goRootNode): base(NAME) {
			//找到控件
			Txt_Num = UnityHelper.FindChildNode(goRootNode, nameof(Txt_Num)).gameObject.GetComponent<Text>();
			Btn_Count = UnityHelper.FindChildNode(goRootNode, nameof(Btn_Count)).gameObject.GetComponent<Button>();

			//注册按钮
			Btn_Count.onClick.AddListener(OnClick_AddNum);
		}


		/// <summary>
		/// （允许接收那些消息）
		/// 新版本中返回类型不再是IList
		/// </summary>
		/// <returns></returns>
		public override string[] ListNotificationInterests() {
			string[] listResult = new string[] {
				SysDefine.MSG_NAME_AddNum
			};
			//可以接收的消息（集合）
			//可以写很多条
			return listResult;
		}

		/// <summary>
		/// （如何处理已经接收消息）
		/// 处理所有其他类，发给本类允许处理的消息
		/// </summary>
		/// <param name="notification"></param>
		public override void HandleNotification(INotification notification){
			switch (notification.Name) {
				case SysDefine.MSG_NAME_AddNum:
					//把模型层发来的数据，显示给控件
					//TODO：可能的重构
					MyData myData = notification.Body as MyData;
					Txt_Num.text = myData?.Number.ToString();
					break;
				default:
					break;
			}
		}


		#region 【私有方法】

		/// <summary>
		/// 定义点击事件
		/// </summary>
		private void OnClick_AddNum(){
			//定义消息，发送到“控制层”
			SendNotification(SysDefine.REG_NAME_StartDataCommand);
		}

		

		#endregion

	}
}