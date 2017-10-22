/*
 * 由SharpDevelop创建。
 * 用户： su
 * 日期: 2017/4/2
 * 时间: 21:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
//using System.IO;
using SQLite;
using System.Configuration;


namespace SQLite
{	
	
	/// <summary>
	/// Description of SQLiteHelper.
	/// </summary>
	public class SQLiteHelper : SQLiteConnection
	{
		public string DBPath {get;set;}
		
		private static SQLiteHelper instance;
		
		public SQLiteHelper(): base(ConfigurationManager.ConnectionStrings["SqliteDatabase"].ConnectionString, false )
		{
			Trace = true;
            
		}
		
		public static SQLiteHelper Instance
	    {
			get
			{
	    	// Uses "Lazy initialization"
	    	if( instance == null )
	      		instance = new SQLiteHelper();
	
	    	return instance;
			}
	    }		
		
	}
}
