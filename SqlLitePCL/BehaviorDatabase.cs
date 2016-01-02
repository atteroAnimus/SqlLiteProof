using System;
using SQLite;
using Xamarin.Forms;

namespace SqlLitePCL
{
	public class BehaviorDatabase : ISQLite
	{
		private SQLiteConnection _connection;

		public BehaviorDatabase()
		{
			_connection = DependencyService.Get<ISQLite>().GetConnection();
			_connection.CreateTable<Behavior>();
		}

		public SQLiteConnection GetConnection()
		{
			throw new NotImplementedException();
		}
	}
}

