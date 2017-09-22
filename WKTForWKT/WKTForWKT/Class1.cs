using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKTForWKT
{
    public class Class1
    {
        [CommandMethod("MKENTS")]
        public void MKENTS()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;
            Transaction trans = doc.TransactionManager.StartTransaction();
            try
            {
                PromptResult pr = ed.GetString("输入WKT字符串");
                if(pr.Status == PromptStatus.OK)
                {
                    string wktStr = pr.StringResult;

                }



            }
            catch
            {


            }
            finally
            {
                trans.Dispose();
            }
        }
    }
}
