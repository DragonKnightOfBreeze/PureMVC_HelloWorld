/***
 * 标题：
 * 游戏开始类
 * 
 * 功能：
 * 游戏的入口
 * 
 * 用法：
 * 挂载到Canvas上
 * 
 * 思路：
 * 
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using Kernel;
//using Global;

namespace PureMVCDemo {
	/// <summary>
	/// 游戏开始类
	/// </summary>
	public class GameStart : MonoBehaviour {

		void Start(){
			//启动PureMVC框架
			//this.gameObject：表示UI界面的根节点
			new AppFacade(this.gameObject);
		}




	}
}