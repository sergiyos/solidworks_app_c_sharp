using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.cosworks;
using SolidWorks.Interop.swmotionstudy;

namespace WindowsFormsSOLIDWORKSApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SldWorks swApp;
        IModelDoc2 swModel;
        AssemblyDoc swAssembly = null;
        int longstatus = 0;
        int longwarnings = 0;
        int errors = 0;

        public void ErrorMsg(object SwApp, string Message, bool EndTest)
        {
            MessageBox.Show(Message);
            MessageBox.Show("'*** WARNING - General");
            MessageBox.Show("'*** " + Message);
            MessageBox.Show("");

            if (EndTest)
            {
            }
        }

        private void ErrorMsg(string Message, bool EndTest)
        {
            swApp.SendMsgToUser2(Message, 0, 0);
            swApp.RecordLine("'*** WARNING - General");
            swApp.RecordLine("'*** " + Message);
            swApp.RecordLine("");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            swApp = new SldWorks();
            swApp.Visible = true;
            swApp.NewPart();
            swModel = swApp.IActiveDoc2;

            swModel.Extension.SelectByID2("Справа", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
                        
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0, 0.004, 0, -0, 0.006, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();
            
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0, 0.006, 0, 0.01, 0.006, 0);              
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.01, 0.006, 0, 0.01, 0.011, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.01, 0.011, 0, 0.015, 0.011, 0);
            swModel.SketchAddConstraints("sgFIXED");            
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.015, 0.011, 0, 0.015, 0.0065, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.015, 0.0065, 0, 0.02, 0.0065, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.02, 0.0065, 0, 0.026, 0.005, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.026, 0.005, 0, 0.028, 0.0065, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.028, 0.0065, 0, 0.034, 0.005, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.034, 0.005, 0, 0.036, 0.0065, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.036, 0.0065, 0, 0.042, 0.005, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.042, 0.005, 0, 0.044, 0.0065, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.044, 0.0065, 0, 0.05, 0.005, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.05, 0.005, 0, 0.05, 0.004, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.05, 0.004, 0, 0, 0.004, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0, 0.004, 0, 0.05, 0.004, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCenterLine(-0, 0, 0, 0.05, 0, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();
            swModel.SketchManager.InsertSketch(true);
            
           // swModel.Extension.SelectByID2("Line17@Эскиз1", "EXTSKETCHSEGMENT", 0, 9.94238977252735E-02, 0.105960140100876, false, 16, null, 0);
           // swModel.Extension.SelectByID2("Эскиз1", "SKETCH", -2.66009057248503E-03, 3.07631837781458E-03, -1.74442594135417E-02, true, 2, null, 0);
            swModel.SelectionManager.EnableContourSelection = true;
            swModel.Extension.SelectByID2("Эскиз1", "SKETCHREGION", -2.66009057248503E-03, 3.07631837781458E-03, -1.74442594135417E-02, true, 2, null, 0);

            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SelectionManager.EnableContourSelection = false;

            
            swModel.Extension.SelectByID2("Спереди", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, -0.012, -0, 0);

            swModel.SketchManager.CreatePolygon(0, 0, 0, -0.011, 0, 0, 6, true);
            // swModel.SketchAddConstraints("sgFIXED");
            // swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);


            swModel.FeatureManager.FeatureCut4(true, false, false, 0, 0, 0.1, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
            // swModel.SelectionManager.EnableContourSelection = false;

           

            swModel.Extension.SelectByID2("Справа", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.014, 0.011, 0, 0.015, 0.011, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();
 
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.015, 0.011, 0, 0.015, 0.009526, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();

            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.015, 0.009526, 0, 0.014, 0.011, 0);
            swModel.SketchAddConstraints("sgFIXED");
            swModel.SetPickMode();     

            swModel.SketchManager.InsertSketch(true);


            swModel.Extension.SelectByID2("Line17@Эскиз1", "EXTSKETCHSEGMENT", 1.91276838961301E-02, 0, 0, true, 0, null, 0);
            swModel.Extension.SelectByID2("Эскиз3", "SKETCHREGION", 3.39317975691915E-03, 1.13603218378812E-02, -1.59961262883416E-02, true, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.Extension.SelectByID2("Line17@Эскиз1", "EXTSKETCHSEGMENT", 1.91276838961301E-02, 0, 0, false, 16, null, 0);
            swModel.Extension.SelectByID2("Эскиз3", "SKETCH", 3.39317975691915E-03, 1.13603218378812E-02, -1.59961262883416E-02, true, 2, null, 0);
            swModel.SelectionManager.EnableContourSelection = true;
            swModel.Extension.SelectByID2("Эскиз3", "SKETCHREGION", 3.39317975691915E-03, 1.13603218378812E-02, -1.59961262883416E-02, true, 2, null, 0);

            swModel.FeatureManager.FeatureRevolve2(true, true, false, true, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SelectionManager.EnableContourSelection = false;
            




        }
    }
}
