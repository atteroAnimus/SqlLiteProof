using System;
using SQLite;

namespace SqlLitePCL
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

