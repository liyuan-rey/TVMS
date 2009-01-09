///////////////////////////////////////////////////////////
//  TenementInfo.cs
//  Implementation of the Class TenementInfo
//  Generated by Enterprise Architect
//  Created on:      07-一月-2009 20:08:54
//  Original author: anaki
///////////////////////////////////////////////////////////

using System;


namespace TVMS.Model {
	public class TenementInfo {

		/// <summary>
		/// 项目编号
		/// </summary>
		private int tenementId;
		/// <summary>
		/// 项目名称
		/// </summary>
		private string name;

		public TenementInfo(){

		}

        /// 
        /// <param name="tenementId"></param>
        /// <param name="name"></param>
        public TenementInfo(int tenementId, string name)
        {

        }

        /// <summary>
		/// 项目编号
		/// </summary>
		public int TenementId{
			get{
				return tenementId;
			}
			set{
				tenementId = value;
			}
		}

		/// <summary>
		/// 项目名称
		/// </summary>
		public string Name{
			get{
				return name;
			}
			set{
				name = value;
			}
		}

	}//end TenementInfo

}//end namespace Model