using ISpan.Utility;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = "INSERT INTO News(Title,vContent,ModifyTime)VALUES(@Title,@vContent,getdate())";
			var dbHelper = new SqlDBHelper("default");
				try
				{
					var parameter = new SqlParameterBuilder()
					.AddNVarchar("title",50,"xx")
					.AddNVarchar("vContent",3000,"xxx")
					.Build();
					
					dbHelper.ExecuteNonQuery(sql, parameter);
					Console.WriteLine("紀錄已新增");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"操作失敗,原因{ex.Message}");
				}
		}
	}
}
