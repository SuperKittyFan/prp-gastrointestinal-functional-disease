using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;


namespace ҽԺ����ϵͳ
{
	/// <summary>
	/// ysheng ��ժҪ˵����
	/// </summary>
	public class ysheng : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected ҽԺ����ϵͳ.dsa dsa1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.TextBox tdz;
		protected System.Web.UI.WebControls.TextBox tem;
		protected System.Web.UI.WebControls.TextBox tdh;
		protected System.Web.UI.WebControls.DropDownList d4;
		protected System.Web.UI.WebControls.DropDownList d3;
		protected System.Web.UI.WebControls.TextBox tzz;
		protected System.Web.UI.WebControls.TextBox tjg;
		protected System.Web.UI.WebControls.DropDownList d2;
		protected System.Web.UI.WebControls.DropDownList d1;
		protected System.Web.UI.WebControls.RadioButtonList r1;
		protected System.Web.UI.WebControls.TextBox tname;
		protected System.Web.UI.WebControls.Panel Panel2;
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button Button5;
		protected System.Web.UI.WebControls.Button Button6;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator5;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator6;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator7;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator8;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator9;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator11;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Submit;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Data.SqlClient.SqlCommand cmd1;
		protected System.Web.UI.WebControls.Button Button7;
		protected System.Data.SqlClient.SqlCommand cmd2;
		protected System.Web.UI.WebControls.DropDownList d6;
		protected System.Data.SqlClient.SqlDataAdapter sda1;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Button Button8;
	   Cpass cpa =new Cpass();
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				string user= Session["usename"].ToString();
				string pwd=Session["pwds"].ToString() ; //��ñ���ֵ	
				if(cpa.CH(user, pwd, "���ڷ���")=="Norights")//�û��������������Ȩ��					
					Response.Redirect("index.aspx"); } 
			catch{  Response.Redirect("index.aspx");} 	
			fills();// �ڴ˴������û������Գ�ʼ��ҳ��
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.cnn = new System.Data.SqlClient.SqlConnection();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sda = new System.Data.SqlClient.SqlDataAdapter();
			this.dsa1 = new ҽԺ����ϵͳ.dsa();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sda1 = new System.Data.SqlClient.SqlDataAdapter();
			this.cmd1 = new System.Data.SqlClient.SqlCommand();
			this.cmd2 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dsa1)).BeginInit();
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button7.Click += new System.EventHandler(this.Button7_Click);
			this.Submit.Click += new System.EventHandler(this.Submit_Click);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// cmd
			// 
			this.cmd.CommandText = "[myinxiu]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@put", System.Data.SqlDbType.NVarChar, 12));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@mydata", System.Data.SqlDbType.VarBinary, 2147483647));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������ò", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ѧ��", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְ��", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ͥ��ַ", System.Data.SqlDbType.NVarChar, 50));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[hh1]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "[del]";
			this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteCommand1.Connection = this.cnn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			// 
			// sda
			// 
			this.sda.DeleteCommand = this.sqlDeleteCommand1;
			this.sda.InsertCommand = this.sqlInsertCommand1;
			this.sda.SelectCommand = this.sqlSelectCommand1;
			this.sda.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dsa1
			// 
			this.dsa1.DataSetName = "dsa";
			this.dsa1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[select1]";
			this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand2.Connection = this.cnn;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sel", System.Data.SqlDbType.NVarChar, 20));
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 50));
			// 
			// sda1
			// 
			this.sda1.DeleteCommand = this.sqlDeleteCommand2;
			this.sda1.InsertCommand = this.sqlInsertCommand2;
			this.sda1.SelectCommand = this.sqlSelectCommand2;
			this.sda1.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// cmd1
			// 
			this.cmd1.CommandText = "[xiangxi]";
			this.cmd1.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd1.Connection = this.cnn;
			this.cmd1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			// 
			// cmd2
			// 
			this.cmd2.CommandText = "[myimin1]";
			this.cmd2.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd2.Connection = this.cnn;
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@mydata", System.Data.SqlDbType.VarBinary, 2147483647));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 10));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������ò", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ѧ��", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְ��", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ͥ��ַ", System.Data.SqlDbType.NVarChar, 50));
			this.Button8.Click += new System.EventHandler(this.Button8_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsa1)).EndInit();

		}
		#endregion

		

		private void fills()
		{
		
			if(cnn.State==0) cnn.Open();
			sda.SelectCommand.ExecuteNonQuery();
			dsa1.Clear(); 
			sda.Fill(dsa1); 
			cnn.Close();
			DataGrid1.DataBind(); 
			
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			
			if(cnn.State==0) cnn.Open();
			sda1.SelectCommand.Parameters["@sel"].Value=TextBox1.Text;
			sda1.SelectCommand.Parameters["@name"].Value=TextBox2.Text;
			sda1.SelectCommand.ExecuteNonQuery ();
			this.dsa1.Clear();
			this.sda1.Fill(dsa1);
			this.DataGrid1.DataBind();
			cnn.Close();
	
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Panel2.Visible =true;
            Submit.Visible =false;
			
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			Panel1.Visible =true;
//			this.DataGrid1.SelectedIndex=-1;
			
		}

		private void Button6_Click(object sender, System.EventArgs e)
		{
			if(DataGrid1.SelectedIndex==-1)
			{
				Response.Write("<script language=javascript>alert('�㻹ûѡ��');</script>") ;
			}
			else
			{
				Panel2.Visible =true;

				Submit.Text="�޸�";
				Button7.Visible =false;
				if(cnn.State==0) cnn.Open();
				cmd1.Parameters["@id"].Value=Convert.ToInt32(DataGrid1.SelectedItem.Cells[1].Text);
				SqlDataReader rd=cmd1.ExecuteReader();
				while (rd.Read())
				{
					tname.Text=rd.GetValue(1).ToString();
					tjg.Text=rd.GetValue(4).ToString();
					tzz.Text =rd.GetValue(5).ToString();
					
					tdh.Text=rd.GetValue(9).ToString();
					tem.Text =rd.GetValue(10).ToString();
					tdz.Text =rd.GetValue(11).ToString();

				}
			}
			
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGrid1.CurrentPageIndex = e.NewPageIndex;
			fills();
		}

		private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Panel2.Visible =false;


		}

		private void Submit_Click(object sender, System.EventArgs e)
		{
			Panel2.Visible =false;
			if(this.File1.Value=="")
			{
				Response.Write("<script language=javascript>alert('�㻹ûѡ��ͼƬ·����')</script>") ;
				return;
			}
			else
			{
			
				string file=File1.PostedFile.FileName ;
				string type=file.Substring(file.LastIndexOf(".")+1);
				byte[] fileCont = new byte[File1.PostedFile.ContentLength];
				File1.PostedFile.InputStream.Read(fileCont,0,(int)File1.PostedFile.ContentLength); //���ļ����е�����ת��byte����
				if(cnn.State==0) cnn.Open();
				cmd.Parameters["@put"].Value=Submit.Text;
				if(Submit.Text=="�ϴ�")
				{
				   cmd.Parameters["@id"].Value=11;
	
				}
				else
				{
					cmd.Parameters["@id"].Value=DataGrid1.SelectedItem.Cells[1].Text;
				}
				cmd.Parameters["@mydata"].Value = fileCont ; 			
				cmd.Parameters ["@����"].Value =tname.Text ;
				cmd.Parameters ["@�Ա�"].Value =r1.SelectedValue ;
				cmd.Parameters ["@��������"].Value =d1.SelectedValue + "-" + d2.SelectedValue;
				cmd.Parameters ["@����"].Value =tjg.Text  ;
				cmd.Parameters ["@����"].Value =tzz.Text  ;
				cmd.Parameters ["@������ò"].Value =d3.SelectedValue;
				cmd.Parameters ["@ѧ��"].Value =d4.SelectedValue  ;
				cmd.Parameters ["@ְ��"].Value =d6.SelectedValue  ;
				cmd.Parameters ["@�绰"].Value =tdh.Text  ;
				cmd.Parameters ["@����"].Value =tem.Text  ;
				cmd.Parameters ["@��ͥ��ַ"].Value =tdz.Text  ;
				cmd.ExecuteNonQuery();
				cnn.Close();
//				fills();
//				Response.Write("<script language=javascript>alert('��ϲ�㣡�������ѳɹ������꣡')</script>") ;                 
				string kk="";
				if(Submit.Text=="�ϴ�")
				{
					kk="���ӳɹ���";
				}
				else
				{
					kk="�޸ĳɹ���";
				}
				Response.Write("<script language=javascript>alert('"+kk+"');</script>") ;
				fills();
				this.DataGrid1.SelectedIndex=-1;
				tname.Text="";
				tjg.Text="";
				tzz.Text ="";
				
				tdh.Text="";
				tem.Text ="";
				tdz.Text ="";
			}
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			if(DataGrid1.SelectedIndex==-1)
			{
				Response.Write("<script language=javascript>alert('�㻹ûѡ��');</script>") ;
			}
			else
			{
		
				if(cnn.State==0) cnn.Open();
				sda.DeleteCommand.Parameters["@id"].Value=DataGrid1.SelectedItem.Cells[1].Text;
				sda.DeleteCommand.ExecuteNonQuery ();
				cnn.Close();
				fills();
				this.DataGrid1.SelectedIndex=-1;

			}
		}

		private void Button7_Click(object sender, System.EventArgs e)
		{
			Panel2.Visible =false;
			if(this.File1.Value=="")
			{
				Response.Write("<script language=javascript>alert('�㻹ûѡ��ͼƬ·����')</script>") ;
				return;
			}
			else
			{
			
				string file=File1.PostedFile.FileName ;
				string type=file.Substring(file.LastIndexOf(".")+1);
				byte[] fileCont = new byte[File1.PostedFile.ContentLength];
				File1.PostedFile.InputStream.Read(fileCont,0,(int)File1.PostedFile.ContentLength); //���ļ����е�����ת��byte����
				if(cnn.State==0) cnn.Open();
				cmd2.Parameters["@mydata"].Value = fileCont ; 			
				cmd2.Parameters ["@����"].Value =tname.Text ;
				cmd2.Parameters ["@�Ա�"].Value =r1.SelectedValue ;
				cmd2.Parameters ["@��������"].Value =d1.SelectedValue + "-" + d2.SelectedValue;
				cmd2.Parameters ["@����"].Value =tjg.Text  ;
				cmd2.Parameters ["@����"].Value =tzz.Text  ;
				cmd2.Parameters ["@������ò"].Value =d3.SelectedValue;
				cmd2.Parameters ["@ѧ��"].Value =d4.SelectedValue  ;
				cmd2.Parameters ["@ְ��"].Value =d6.SelectedValue  ;
				cmd2.Parameters ["@�绰"].Value =tdh.Text  ;
				cmd2.Parameters ["@����"].Value =tem.Text  ;
				cmd2.Parameters ["@��ͥ��ַ"].Value =tdz.Text  ;
				cmd2.ExecuteNonQuery();
				cnn.Close();
				fills();
				
			}
		}

		private void Button8_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("index.aspx");
		}

		

	}
}