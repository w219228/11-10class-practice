using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"Delete FROM News WHERE ID=@ID";
			var dbHelper = new SqlDBHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
				.AddInt("id", 2)
				.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);
				Console.WriteLine("紀錄已delete");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗,原因{ex.Message}");
			}
		}
	}
}
