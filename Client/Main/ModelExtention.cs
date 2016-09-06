using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetPlan.Model;

namespace NetPlanClient
{
    public static class ModelExtention
    {
        /// <summary>
        /// 转为服务引用的模型
        /// </summary>
        /// <param name="myModel"></param>
        /// <returns></returns>
        public static List<AirComService.AirComAntennaType> TransAntenner(this List<AirComAntennaType> myModel)
        {

            List<AirComService.AirComAntennaType> Models = new List<AirComService.AirComAntennaType>();
            myModel.ForEach(fo =>
            {
                Models.Add(new AirComService.AirComAntennaType()
                {
                    AntennaTypeName = fo.AntennaTypeName,
                    Celliid = fo.Celliid,
                    Azimuth = fo.Azimuth,
                    Burthen = fo.Burthen,
                    CarrierAlias = fo.CarrierAlias,
                    CarrierId = fo.CarrierId,
                    ElectricalDownTilt = fo.ElectricalDownTilt,
                    Height = fo.Height,
                    Location = new AirComService.AirComLocationType()
                    {

                        Latitude = fo.Location.Latitude,
                        LongitudeField = fo.Location.LongitudeField,
                        LongitudeSpecified1 = fo.Location.LongitudeSpecified
                    },
                    MechanicalDownTilt = fo.MechanicalDownTilt,
                    ModelType = fo.ModelType
                });

            });
            return Models;
        }
    }
}
