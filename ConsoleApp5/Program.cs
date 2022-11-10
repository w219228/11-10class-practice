using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var dbHelper = new SqlDBHelper("default");
			string sql = "SELECT Id,Title FROM News WHERE Id>@Id ORDER BY Id ASC ";
				try
				{
					var parameters = new SqlParameterBuilder().AddInt("id",0).Build();

					DataTable news = dbHelper.Select(sql,parameters);
					foreach (DataRow row in news.Rows)
					{
						int id = row.Field<int>("id");
						string title=row.Field<string>("title");
						Console.WriteLine($"Id={id},Title={title}");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"操作失敗,原因{ex.Message}");
				}
			
		}
	}
}
