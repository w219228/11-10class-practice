using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Utility
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> Parameter = new List<SqlParameter>();

		public SqlParameterBuilder AddNVarchar(string name, int length, string value)
		{
			var param = new SqlParameter(name, SqlDbType.NVarChar, length){Value=value};
			Parameter.Add(param);

			return this;
		}
		public SqlParameterBuilder AddInt(string name, int value)
		{
			var param = new SqlParameter(name, SqlDbType.Int) { Value = value };
			Parameter.Add(param);

			return this;
		}
		public SqlParameterBuilder AddDatetime(string name, DateTime value)
		{
			var param = new SqlParameter(name, SqlDbType.DateTime) { Value = value };
			Parameter.Add(param);

			return this;
		}

		public SqlParameterBuilder AddBool(string name, bool value)
		{
			var param = new SqlParameter(name, SqlDbType.Bit) { Value = value };
			Parameter.Add(param);

			return this;
		}
		public SqlParameter[] Build()
		{
			return Parameter.ToArray();
		}
	}
}
