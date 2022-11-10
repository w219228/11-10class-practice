using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"UPDATE News 
			SET Title=@Title,
			vContent=@vContent,
			ModifyTime=getdate()
			WHERE ID=@ID";
			var dbHelper = new SqlDBHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
				.AddNVarchar("title", 50, "xx")
				.AddNVarchar("vContent", 3000, "1xxx")
				.AddInt("id",2)
				.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("紀錄已update");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗,原因{ex.Message}");
			}
		}
	}
}
