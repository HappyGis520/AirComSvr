﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using EDSProxy.EDSClient;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using JLIB.CSharp;
using JLIB.Utility;
using NetPlan.BLL;
using NetPlan.Model;
using NetPlanClient.AirComService;
using ZipOneCode.ZipProvider;
using AirComAntennaType = NetPlan.Model.AirComAntennaType;
using AirComLTENodeBaseInfo = NetPlan.Model.AirComLTENodeBaseInfo;
using AircomCell = NetPlan.Model.AircomCell;
using PLAData = NetPlan.Model.PLAData;


namespace NetPlanClient
{
    public partial class FrmMain : Form
    {
        AirComService.AirComService Server = new AirComService.AirComService();

        //AirComService AirComServer =null;
        /// <summary>
        /// 扇区天线列表
        /// </summary>
       List<AirComAntennaType> CELLAntenners = new  List<AirComAntennaType>();
        /// <summary>
        /// 天线列表
        /// </summary>
        private List<AirComAntennaType> _AllAntennas = new List<AirComAntennaType>();
        private BindingSource _bindingSource = new BindingSource();
        /// <summary>
        /// 地市名称，服务端根据该名称获取工程名称
        /// </summary>
        private string CityName = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
            InitionParam();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            RegistEventHandle();
        }

        #region 初始化方法 
        private void InitionParam()
        {
            JLog.Instance.AppInfo("初始化WebService对象");
            //AirComServer = new AirComService();
            _bindingSource.DataSource = _AllAntennas;
            dgvStation.AutoGenerateColumns = false;
            dgvStation.DataSource = _bindingSource;
        }
        private void RegistEventHandle()
        {
            ucLTEStationType1.RegistCreateNewStation_ClickEvent(SubDoCreateNewSector);
        }
        #endregion
        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        #region 其它窗体事件处理

        private void btnBuildXML_Click(object sender, EventArgs e)
        {
            try
            {
                var baseInfo = ucLTEStationType1.BuildBasicInfo();
                string dir = string .Empty;
                 BuilLTEXMLFiles(baseInfo,CELLAntenners,_AllAntennas,dir );
            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message, MethodBase.GetCurrentMethod().Name,
                    MethodBase.GetCurrentMethod().Module.Name);
            }
        }


        private void dataGridViewX1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (_bindingSource == null || _bindingSource.Count < 1)
                    return;
                if (e.RowIndex >= 0 && _bindingSource.Count > e.RowIndex)
                {
                    AirComAntennaType obj = _bindingSource[e.RowIndex] as AirComAntennaType;
                    var editers = _AllAntennas.Where(fo => fo.Celliid == obj.Celliid).ToList();
                    if (editers != null && editers.Count > 0)
                    {
                        EditSectors(obj.Celliid,editers);
                    }
                    //if (Sectors.TryGetValue(obj.SectorId, out SelectAntenna))
                    //{
                    //    EditSectors(obj.SectorId, SelectAntenna);
                    //}

                }
            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message, MethodBase.GetCurrentMethod().Name,
                    MethodBase.GetCurrentMethod().Module.Name);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {


        }
        private void tabCreateTask_Click(object sender, EventArgs e)
        {
            //if (pnlContainer.Controls.Count > 1)
            //{

            //    string ControlName = pnlContainer.Controls[0].Name;
            //    if (!ControlName.Equals(tabCreateTask.Tag as string))
            //    {
            //        pnlContainer.Controls.Clear();
            //        CreateTaskPanel = new ucCreateTask();
            //        pnlContainer.Controls.Add(CreateTaskPanel);
            //        CreateTaskPanel.Name = tabCreateTask.Tag as string;
            //        CreateTaskPanel.Dock = DockStyle.Fill;
            //        return;

            //    }
            //}
            //else
            //{
            //    CreateTaskPanel = new ucCreateTask();
            //    pnlContainer.Controls.Add(CreateTaskPanel);
            //    CreateTaskPanel.Name = tabCreateTask.Tag as string;
            //    CreateTaskPanel.Dock = DockStyle.Fill;
            //    return;
            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {


            UserConfigParam pp = new UserConfigParam();
            pp.AntennaTypes.Add("a");
            pp.AntennaTypes.Add("aa");
            pp.CarrierItems.Add(new MCarrierItem() { Alias = "天线1", ID = 0 });
            pp.CarrierItems.Add(new MCarrierItem() { Alias = "天线2", ID = 2 });
            pp.EDSLoadAppFile = "D:\\EDSLoadApp.exe";
            pp.ModelTypes.Add("模型1");
            pp.ModelTypes.Add("模型2");
            pp.ProjectNames.Add(new MProjectName() { CityName = "杭州", ProjectName = "杭州工程" });
            pp.ProjectNames.Add(new MProjectName() { CityName = "南京", ProjectName = "南京工程" });
            pp.XmlFileSaveDir = "D:\\XML";
            pp.EAWSSchemaName = "wjj";
            pp.EAWSRealseDir = "F:\\";
            pp.FTPDir = "D:\\";
            JLIB.CSharp.JFileExten.ToXML(pp, @".\test.xml");
        }
        #endregion

        #region 业务事件处理
        private void SubDoCreateNewSector(object Sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                object[] Params = new object[] { Sender, e };
                this.Invoke(new Action<object, EventArgs>(this.SubDoCreateNewSector), Params);
                return;
            }

            FrmSector _frmSector = new FrmSector();
            _frmSector.RegistAppendSectorEvent(SubDoAppenSectorEvent);
            _frmSector.ShowDialog();

        }
        private void SubDoAppenSectorEvent(IList<AirComAntennaType> AntennaTypes)
        {
            if (this.InvokeRequired)
            {
                object[] Params = new object[] {  AntennaTypes };
                this.Invoke(new Action< IList<AirComAntennaType>>(this.SubDoAppenSectorEvent), Params);
                return;

            }
            try
            {
                AppendSectorInfo(AntennaTypes);
            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message, MethodBase.GetCurrentMethod().Name,
                    MethodBase.GetCurrentMethod().Module.Name);
            }
        }
        /// <summary>
        /// 添加扇区至界面
        /// </summary>
        /// <param name="SectorID"></param>
        /// <param name="AntennaTypes"></param>
        private void AppendSectorInfo( IList<AirComAntennaType> AntennaTypes)
        {
            try
            {
                var _olds = _AllAntennas.Where(fo => fo.Celliid == AntennaTypes[0].Celliid).ToList();
                _olds.ForEach(fo=>_bindingSource.Remove(fo));
                foreach (var obj in AntennaTypes)
                {
                    _bindingSource.Add(obj);
                }
                CELLAntenners.AddRange( AntennaTypes.ToList());
            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message, MethodBase.GetCurrentMethod().Name,
                    MethodBase.GetCurrentMethod().Module.Name);
            }




        }
        /// <summary>
        /// 编辑扇区
        /// </summary>
        /// <param name="SectorID"></param>
        /// <param name="MyAntennaTypes"></param>
        protected void EditSectors(string SectorID, List<AirComAntennaType> MyAntennaTypes)
        {
            FrmSector _frmSector = new FrmSector();
            _frmSector.LoadSectorInfo(SectorID, MyAntennaTypes);
            _frmSector.RegistAppendSectorEvent(SubDoAppenSectorEvent);
            _frmSector.ShowDialog();

        }
        /// <summary>
        /// 生成XML文件 
        /// </summary>
        /// <param name="BaseInfo">站点基本信息</param>
        /// <param name="Sectors">扇区信息，每个扇区的天线信息</param>
        /// <param name="AllAntennas">所有天线的信息</param>
        /// <param name="Savedir">保存目录</param>
        /// <returns></returns>
        private bool BuilLTEXMLFiles(AirComLTENodeBaseInfo BaseInfo,  List<AirComAntennaType> Sectors, List<AirComAntennaType> AllAntennas, string Savedir)
        {
            //LTENodeType _LteNode = new LTENodeType();


            //LteNodeBuildFactory.BuildStationInfo(BaseInfo, ref _LteNode);

            //LteNodeBuildFactory.BuildCarrierInfo(Sectors, ref _LteNode);

            //LteNodeBuildFactory.BuildAntennaInfo(AllAntennas, ref _LteNode);

            //LteNodeBuildFactory.BuildCellInfo(Sectors, ref _LteNode);

            //#region 生成XML

            //List<RootEntityType> Nodes = new List<RootEntityType>();
            //List<LTENodeType> nodesList = new List<LTENodeType>();
            //Nodes.Add(_LteNode);
            //nodesList.Add(_LteNode);
            //Savedir = GlobalInfo.Instance.ConfigParam.XmlFileSaveDir.Trim();
            //if (!Directory.Exists(Savedir))
            //{
            //    DirectoryInfo dirInfo = Directory.CreateDirectory(Savedir);
            //}
            //LteNodeBuildFactory.BuildLteNodeXML(Nodes, Savedir);
            //LteNodeBuildFactory.BuilLteNodeDeleteXML(nodesList, Savedir);
            //LteNodeBuildFactory.BuildLocationXML(BaseInfo, Savedir);
            //LteNodeBuildFactory.BuildLocationDeleteXML(BaseInfo, Savedir);

            //#endregion

            return true;
        }
        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //try
            //{
            //    PLAData data = new PLAData();
            //    var baseInfo = ucLTEStationType1.BuildBasicInfo();
            //    data.BaseInfo = baseInfo;
            //    data.CellSectors = new CellSector[Sectors.Count];
            //    int index = 0;
            //    foreach (var sector in Sectors)
            //    {
            //        data.CellSectors[0] = new CellSector()
            //        {
            //            Antenners = sector.Value.ToArray(),
            //            CellID = sector.Key
            //        };
            //        index++;
            //    }

            //    //AirComServer.CreateTask(data);
            //}
            //catch (Exception ex)
            //{
            //    JLog.Instance.Error(ex.Message);

            //}

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                PLAData data = new PLAData();
                data.ProjectName = txtPrjName.Text;
                data.WorkOrder = 1000;
                data.CoverRadius = double.Parse(txtCoverRadius.Text);
       

                var baseInfo = ucLTEStationType1.BuildBasicInfo();
                baseInfo.CityName = txtCityName.Text;
                data.BaseInfo = baseInfo;

                data.CellSectors = new List<AircomCell>();
                int index = 0;
                foreach (var sector in CELLAntenners)
                {
                    data.CellSectors.Add(new AircomCell()
                    {
                        Antenners = sector,
                        CellID = index+1
                    });
                    index++;
                }
                
                string FileName = string.Format(@"E:\SendXML{0}.xml", DateTime.Now.ToString("hh-mm-ss"));
                JLog.Instance.AppInfo(string.Format("生成XML{0}",FileName));
                JFileExten.ToXML(data, FileName);
                JLog.Instance.AppInfo("调用传对象接口");
                //AirComServer.CreateTask(data);
                BLLDoTask.Instance.CreateTask(data);

            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message);

            }
        }




        private void buttonX2_Click(object sender, EventArgs e)
        {
            //if( AirComServer.HelloWord())
            //{
            //    JLog.Instance.AppInfo("调用完成");
            //}
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                JLog.Instance.AppInfo("通xml数据串调用..");
                PLAData data = new PLAData();
                var baseInfo = ucLTEStationType1.BuildBasicInfo();
                data.BaseInfo = baseInfo;
                //data.CellSectors = new CellSector[Sectors.Count];     
               data.CellSectors = new List<AircomCell>(); 
                data.CoverRadius = 12;
                int index = 0;
                HashSet<string> celliids = new HashSet<string>();
                foreach (var sector in CELLAntenners)
                {
                    if (!celliids.Contains(sector.Celliid))
                    {
                        celliids.Add(sector.Celliid);
                        data.CellSectors.Add(new AircomCell()
                        {
                            Celliid = sector.Celliid,
                            Antenners = CELLAntenners.Where(fo=>fo.Celliid.Equals(sector.Celliid)).ToList()
                            
                        });
                        index++;
                    }
                    

                }
                var Dir = AppDomain.CurrentDomain.BaseDirectory+Path.DirectorySeparatorChar+"XML\\";
                string FileName = string.Format(@"E:\SendXML{0}.xml", DateTime.Now.ToString("hh-mm-ss"));
                //string FileName = string.Format(@"SendXML{0}.xml", DateTime.Now.ToString("hh-mm-ss"));
                string Msg = string.Empty;
                var str =   XMLHelper.SerializeToXmlStr(data,true);

                JFileExten.SaveToCreateFile(FileName, str, out Msg);
                //if (AirComServer.CreateTaskByXML(str))
                //{
                //    JLog.Instance.AppInfo("通xml数据串调用成功");
                //}
            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message);

            }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            Inspur.InspurRequestApiModel model = new Inspur.InspurRequestApiModel()
            {
                flow_id = 1,
                name = "wjj",
                remark = "dfsafsafasf"
            };
            //var objs = XMLHelper.SerializeToXmlStr(model, false);
            var objs2 = XMLHelper.SerializeToXmlStr(model,true);
            //var objs3 = XMLHelper.XmlDeserialize<Inspur.InspurRequestApiModel>(objs);
            var objs4 = XMLHelper.XmlDeserialize<Inspur.InspurRequestApiModel>(objs2);
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            WGS84ToUTM.Exute(null);
            var baseInfo = ucLTEStationType1.BuildBasicInfo();
            baseInfo.Lng = 119.97;
            baseInfo.Lat = 31.81;
            var r = 1;
            GeoRegion reg = new GeoRegion();
            //PLAData.GetExtend(baseInfo.Lng,baseInfo.Lat, out reg.EastMin,out reg.Eastmax,out reg.NorthMin,out reg.NorthMax, r*1000,50);
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "E:\\";
            openFileDialog1.Filter = "txt files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var imageFile = openFileDialog1.FileName;
                    txtXMLFile.Text = imageFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var data = XMLHelper.XmlFileDeserialize<PLAData>(txtXMLFile.Text.Trim());
            
            BLLDoTask.Instance.CreateTask(data);
        }

        private void btnCallWebSerivce_Click(object sender, EventArgs e)
        {
            try
            {
               AirComService.PLAData data = new AirComService.PLAData();
                data.ProjectName = txtPrjName.Text;
                data.WorkOrder = 1000;
                data.CoverRadius = double.Parse(txtCoverRadius.Text);
                

                

                var baseInfo = ucLTEStationType1.BuildBasicInfo();
                baseInfo.CityName = txtCityName.Text;
                data.BaseInfo = new AirComService.AirComLTENodeBaseInfo()
                {
                    CityName = baseInfo.CityName,
                    CoverType = (AirComService.EnumCoverType) (byte) baseInfo.CoverType,
                    Lat = baseInfo.Lat,
                    Lng = baseInfo.Lng,
                    SaveType = (AirComService.EnumSaveType) (byte) baseInfo.SaveType,
                    StationAlias = baseInfo.StationAlias,
                    StationId = baseInfo.StationId,
                    StationType = (AirComService.EnumStationType) (Byte) baseInfo.StationType

                };
                //data.CellSectors = new AirComService.[CELLAntenners.Count];
                List<AirComService.AircomCell> cellss = new List<AirComService.AircomCell>();

                HashSet<string> ceiids = new HashSet<string>();
                int n = 0;
                foreach (var sector in CELLAntenners)
                {

                    if (!ceiids.Contains(sector.Celliid))
                    {
             
                        ceiids.Add(sector.Celliid);

                        var anteners = CELLAntenners.Where(fo => fo.Celliid.Equals(sector.Celliid)).ToList();
                        AirComService.AircomCell cell = new AirComService.AircomCell();
                        cell.Celliid = sector.Celliid;
                        cell.Antenners = anteners.TransAntenner().ToArray();
                        cellss.Add(cell);

                        n++;
                    }
                }
                data.CellSectors = cellss.ToArray();
                string FileName = string.Format(@"E:\SendXML{0}.xml", DateTime.Now.ToString("hh-mm-ss"));
                JLog.Instance.AppInfo(string.Format("生成XML{0}", FileName));
                JFileExten.ToXML(data, FileName);
                JLog.Instance.AppInfo("调用传对象接口");
                if (Server.CreateTask(data))
                {
                    MessageBox.Show("调用成功");
                }
                else
                {
                    MessageBox.Show("调用失败");
                }

            }
            catch (Exception ex)
            {
                JLog.Instance.Error(ex.Message);

            }
        }
    }
}
