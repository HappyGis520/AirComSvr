﻿/*******************************************************************
 * * 版权所有： 王建军
 * * 文件名称： BDLBaseStation .cs
 * * 功   能： 数据库 dbo.BaseStation表，数据访问业务逻辑
 * * 作   者： 王建军
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2016/02/23 13:05:09
 * * 修改记录： 
 * * 日期时间： 2016/02/23 13:05:09  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using NetPlan.DAL;
using NetPlan.Model;

namespace NetPlan.BDL
{
    /// <summary>
    /// 数据库 dbo.BaseStation表，数据访问业务逻辑
    /// </summary>
    public static class BDLBaseStation
    {

        /// <summary>
        /// 添加一个对象,返回新对象ID号
        /// </summary>
        /// <param name="entityPdt"></param>
        /// <returns></returns>
        public static Int32 Add(EtBaseStation etBaseStation)
        {
            return DALBaseStation.Add(etBaseStation);
        }
        /// <summary>
        /// 删除指定主键值的记录,并返回受影响行数
        /// </summary>
        /// <param name="iD">数据库中的唯一ＩＤ号''</param>
        public static int DeleteByStationID(int stationID)
        {
            return DALBaseStation.DeleteByStationID(stationID);
        }
        /// <summary>
        /// 修改主键值一致的记录，并返回受影响行数
        /// </summary>
        /// <param name="entityPdt">数据库相对应的对象实例</param>
		public static int Modify(EtBaseStation etBaseStation)
        {
            return DALBaseStation.Modify(etBaseStation);
        }
        /// <summary>
        /// 获取所有对象
        /// </summary>
        /// <returns></returns>
        public static IList<EtBaseStation> GetAllBaseStations()
        {
            return DALBaseStation.GetAllBaseStations();
        }
        /// <summary>
        /// 根据条件获取所有对象
        /// </summary>
        /// <returns></returns>
        public static IList<EtBaseStation> GetAllBaseStationsWithDynamicCondition(string where)
        {
            return DALBaseStation.GetAllBaseStationsWithDynamicCondition(where);
        }
        /// <summary>
        /// 使用存储过程分页返回记录对象集
        /// </summary>
        /// <param name="DataTbleName">输出表名称</param>
        /// <param name="ReturnFields">返回的字段，多个时，有逗号隔开</param>
        /// <param name="Where">条件语句，可以为空，表示不使用条件</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="Sort">排序字段，可以为空,使用默认</param>
        /// <param name="pageSize">每页的行数</param>
        /// <param name="AllRecords">满足条件的记录数</param>
        /// <returns></returns>
        public static IList<EtBaseStation> GetPageBaseStationsWithDynamicCondition(string DataTbleName, string ReturnFields, string SqlWhere, int pageIndex, string Sort, int pageSize, out Int32 AllRecords)
        {
            return DALBaseStation.GetPageBaseStations(DataTbleName, ReturnFields, SqlWhere, pageIndex, Sort, pageSize, out AllRecords);

        }
        /// <summary>
        /// 获取记录条数
        /// </summary>
        /// <returns></returns>
		public static int GetRowCountOfAllBaseStations()
        {
            return DALBaseStation.GetRowCountOfAllBaseStations();
        }

    }
}