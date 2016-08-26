﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace NetPlan.Model
{
    [Serializable]
    public class PLAData
    {
        /// <summary>
        /// 工单号
        /// </summary>
        public long WorkOrder = 0;
        /// <summary>
        /// 基站信息
        /// </summary>
        public AirComLTENodeBaseInfo BaseInfo;
        /// <summary>
        /// 扇区信息
        /// </summary>
        public List<CellSector> CellSectors = new List<CellSector>();

        /// <summary>
        /// 保存目录
        /// </summary>
        internal string Savedir = "C:\\";
        /// <summary>
        /// 工程名称
        /// </summary>
        public string ProjectName ="工程名";
        /// <summary>
        /// 仿真范围
        /// </summary>
        internal GeoRegion RegionBound = new GeoRegion();
        /// <summary>
        /// 仿真半径，单位KM
        /// </summary>
        public double CoverRadius=1.00;

        public int LonLatToXY(double Lon, double Lat, out double X, out double Y, int ProjNo)
        {
            double longitude1, latitude1, longitude0, X0, Y0, xval, yval;
            double a, e2, ee, NN, T, C, A, M, iPI, FN;

            double __K0 = 0.9996;
            double __A = 6378137.0;
            double __B = 6356752.3142;
            double __F = (__A - __B) / __A;

            int ZoneWide = 6;

            iPI = Math.PI / 180.0;

            a = __A;
            FN = 0;


            longitude0 = (ProjNo - 30) * ZoneWide - ZoneWide / 2;

            longitude0 = longitude0 * iPI;

            longitude1 = ((Lon + 180) - (int)((Lon + 180) / 360) * 360 - 180) * iPI;     //经度转换为弧度   //确保longtitude位于-180.00----179.9之间
            latitude1 = Lat * iPI;     //纬度转换为弧度
            e2 = 2 * __F - __F * __F;
            ee = e2 * (1.0 - e2);
            NN = a / Math.Sqrt(1.0 - e2 * Math.Sin(latitude1) * Math.Sin(latitude1));
            T = Math.Tan(latitude1) * Math.Tan(latitude1);
            C = ee * Math.Cos(latitude1) * Math.Cos(latitude1);
            A = (longitude1 - longitude0) * Math.Cos(latitude1);
            M = a * ((1 - e2 / 4 - 3 * e2 * e2 / 64 - 5 * e2 * e2 * e2 / 256) * latitude1 - (3 * e2 / 8 + 3 * e2 * e2 / 32 + 45 * e2 * e2
            * e2 / 1024) * Math.Sin(2 * latitude1)
            + (15 * e2 * e2 / 256 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(4 * latitude1) - (35 * e2 * e2 * e2 / 3072) * Math.Sin(6 * latitude1));
            xval = __K0 * (NN * (A + (1 - T + C) * A * A * A / 6 + (5 - 18 * T + T * T + 72 * C - 58 * ee) * A * A * A * A * A / 120));
            yval = __K0 * (M + NN * Math.Tan(latitude1) * (A * A / 2 + (5 - T + 9 * C + 4 * C * C) * A * A * A * A / 24 + (61 - 58 * T + T * T + 600 * C - 330 * ee) * A * A * A * A * A * A / 720));
            X0 = 500000L;
            Y0 = FN;
            xval = xval + X0; yval = yval + Y0;
            X = xval;
            Y = yval;
            return 0;
        }

        public void GetExtend(double lon, double lat, out double eastmin, out double eastmax, out double northmin, out double northmax, double offset, int ProjNo)
        {   //如果offset 是1000m,则是左右2000m,上下2000m,OFFSET单位是米
            double x, y;
            LonLatToXY(lon, lat, out x, out y, ProjNo);

            eastmin = x - offset;
            eastmax = x + offset;
            northmin = y - offset;
            northmax = y + offset;
        }







    }
}