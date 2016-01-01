using System;

namespace SqlLitePCL
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

