using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
	 string onlinePDF="C:\\IIS\\ImageDB_RPT\\onlinepdf\\";
	
    protected void Page_Load(object sender, EventArgs e)
    {
        string DBIP = ConfigurationSettings.AppSettings.Get("CrystalReport-DB-IP");
        string UserID = ConfigurationSettings.AppSettings.Get("CrystalReport-DB-UserID");
        string UserPassword = ConfigurationSettings.AppSettings.Get("CrystalReport-DB-UserPassword");   
        
        
        try
        {                     
            string rptFile = "";
            ReportDocument report = new ReportDocument();
            CrystalReportViewer1.DisplayGroupTree  = false;
            
            int i = Convert.ToInt16(Request["rpt"]);
            string randomId=Request["randomId"];
            switch (i)
            {
                case 0:
                    rptFile = this.Server.MapPath("rpt/CustomerPriceList.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("customerId", Request["customerId"] );
                    //saveDisk1(report, "CustomerPriceList"); 
                break; 
                
                case 1:
                    rptFile = this.Server.MapPath("rpt/QuotedPrice.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["quotedPrice"] );
                    saveDisk1(report, "QuotedPrice-"+ Request["quotedPrice"]+"-"+randomId); 
                break;
                
                case 2:
                    rptFile = this.Server.MapPath("rpt/PrintPurchaseLable.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["purchase"] );
                    //saveDisk1(report, "PrintPurchaseLable"); 
                 break;
                 
                 case 3:
                    rptFile = this.Server.MapPath("rpt/PurchaseList.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );                     
                    //saveDisk1(report, "PurchaseList");    
                 break;
                
                
                case 4:
                    rptFile = this.Server.MapPath("rpt/PurchaseList.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );  
                    //saveDisk1(report, "PurchaseList");               
                 break;
                 
                 case 5:
                    rptFile = this.Server.MapPath("rpt/QuotedPrice.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["quotedPrice"] );
                    saveDisk1(report, "QuotedPrice");
                 break;

             //示意圖A
                 case 6:
                    rptFile = this.Server.MapPath("rpt/Signal1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );                                   
                    saveDisk1(report, "Signal1-"+ Request["id"]+"-"+randomId);
                 break;
                 

                 case 7:
                    rptFile = this.Server.MapPath("rpt/Completion2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );   
                    saveDisk1(report, "Completion2-"+ Request["id"]+"-"+randomId);            
                 break;
                 
                 case 8:
                    rptFile = this.Server.MapPath("rpt/Completion1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );   
                    saveDisk1(report, "Completion1-"+ Request["id"]+"-"+randomId);            
                 break;
                 
                  case 9:
                    rptFile = this.Server.MapPath("rpt/sticker1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );    
                    saveDisk1(report, "sticker1-"+ Request["id"]+"-"+randomId);                               
                 break;
                 
                 case 10:
                    rptFile = this.Server.MapPath("rpt/sticker2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );     
                    saveDisk1(report, "sticker2-"+ Request["id"]+"-"+randomId);                              
                 break;
                
             //示意圖B                 
                  case 11:
                    rptFile = this.Server.MapPath("rpt/Signal2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );    
                    saveDisk1(report, "Signal2-"+ Request["id"]+"-"+randomId);                                    
                 break;
                 
                 
                 case 12:
                    rptFile = this.Server.MapPath("rpt/sticker3.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );  
                    saveDisk1(report, "sticker3-"+ Request["id"]+"-"+randomId);                                 
                 break;
                            
                case 13:
                    rptFile = this.Server.MapPath("rpt/Reaction.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );                                                                     
                 break;   
                 
                 case 14:
                    rptFile = this.Server.MapPath("rpt/QuotedPriceItemLable.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["quotedPrice"] );
                    saveDisk1(report, "QuotedPriceLine-"+ Request["quotedPrice"]+"-"+randomId); 
                break;
                
                 case 15:
                    rptFile = this.Server.MapPath("rpt/PrintPage.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );
                break; 
                
                 case 16:
                    rptFile = this.Server.MapPath("rpt/applicationForConstruction1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("id", Request["id"] );
                    saveDisk1(report,Request["randomId"] ); 
                break;
                
                
                case 17:
                    rptFile = this.Server.MapPath("rpt/quotedPriceCustomerDpt.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("ids", Request["ids"] );
                break;
                
                case 18:
                    rptFile = this.Server.MapPath("rpt/StaffPerformace.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("date", Request["date"] );
                break;                
                
                case 19:
                    rptFile = this.Server.MapPath("rpt/ProductionCapacity.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                break;
                
                case 20:
                    rptFile = this.Server.MapPath("rpt/ProductionCapacity1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("start", Request["start"] );
                    report.SetParameterValue("end", Request["end"] );
                    saveDisk1(report,Request["randomId"] );
                break;
                
                case 21:
                    rptFile = this.Server.MapPath("rpt/ProductionCapacity2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                    report.SetParameterValue("start", Request["start"] );
                    report.SetParameterValue("end", Request["end"] );
                    report.SetParameterValue("member", Request["member"] );
                    report.SetParameterValue("groupId", Request["groupId"] );
                break;
                
                case 22:
                    rptFile = this.Server.MapPath("rpt/CHCrementVerification.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                break;
                
                case 23:
                    rptFile = this.Server.MapPath("rpt/ConstructionQuery.rpt");
                    report.Load(rptFile);               
                    report.SetParameterValue("startDate", Request["startDate"] );
                    report.SetParameterValue("endDate", Request["endDate"] );
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "ImageDB");
                break;
                
                          
                
            }
           
            CrystalReportViewer1.ReportSource = report;
            CrystalReportViewer1.DataBind();            
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("printReport=" + ex.Message);
        }
        
    }
    

  public void SaveStreamToFile(string fileFullPath, System.IO.Stream stream)
   {
    if (stream.Length == 0) return;
    // Create a FileStream object to write a stream to a file
    using (System.IO.FileStream fileStream = System.IO.File.Create(fileFullPath, (int)stream.Length))
    {
        // Fill the bytes[] array with the stream data
        byte[] bytesInStream = new byte[stream.Length];
        stream.Read(bytesInStream, 0, (int)bytesInStream.Length);
        // Use FileStream object to write to the specified file
        fileStream.Write(bytesInStream, 0, bytesInStream.Length);
     }
   }

   public void saveDisk1(ReportDocument report, String fileName)
    {       
                    
                System.IO.Stream stream1 = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                //byte[] bytes1 = new byte[stream1.Length];
                //stream1.Read(bytes1, 0, bytes1.Length);
                //stream1.Seek(0, System.IO.SeekOrigin.Begin);                
                SaveStreamToFile(onlinePDF+"\\"+fileName+".pdf", stream1);
    }
        
   public void saveDisk(ReportDocument report, String fileName, String fileType)
    {       
        switch (fileType)
        {
            case "excel":
                System.IO.Stream stream = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel);
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                //export file
                Response.ClearContent();
                Response.ClearHeaders();
                Response.AddHeader("content-disposition", "attachment;filename=" + fileName+".xls");
                Response.ContentType = "application/vnd.ms-excel";
                Response.OutputStream.Write(bytes, 0, bytes.Length);
                Response.Flush();
                Response.Close();
            break;
            case "pdf":
                System.IO.Stream stream1 = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                byte[] bytes1 = new byte[stream1.Length];
                stream1.Read(bytes1, 0, bytes1.Length);
                stream1.Seek(0, System.IO.SeekOrigin.Begin);
                //export file
                Response.ClearContent();
                Response.ClearHeaders();
                Response.AddHeader("content-disposition", "attachment;filename=" + fileName+".pdf");
                Response.ContentType = "application/pdf";
                Response.OutputStream.Write(bytes1, 0, bytes1.Length);
                Response.Flush();
                Response.Close();
                break;
            case "word":
                System.IO.Stream stream2 = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows);
                byte[] bytes2 = new byte[stream2.Length];
                stream2.Read(bytes2, 0, bytes2.Length);
                stream2.Seek(0, System.IO.SeekOrigin.Begin);
                //export file
                Response.ClearContent();
                Response.ClearHeaders();
                Response.AddHeader("content-disposition", "attachment;filename=" + fileName+".doc");
                Response.ContentType = "application/vnd.ms-word";
                Response.OutputStream.Write(bytes2, 0, bytes2.Length);
                Response.Flush();
                Response.Close();
            break;
        }        
    }
    
}