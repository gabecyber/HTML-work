using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace lab8_test_db {
	public partial class Default : System.Web.UI.Page {
		private string format = "{0,20} : {1}\n";
		private string dataFormat = "{0,-9} {1,-7} {2,-10} {3,-11} {4,-11} {5,-11}\n";
		private string result = "";
		protected void Page_Load(object sender, EventArgs e) {
			testDatabaseAccess();
		}
		protected void testDatabaseAccess() {
			string data = "";
			// Create connection object
			IDbConnection con = new OleDbConnection();
			// Create command object
			IDbCommand cmd = new OleDbCommand();
			// Get connection string from web.config.
			string conn = ConfigurationManager.ConnectionStrings["playersConnectionString"].ConnectionString;
			// Attach connection string to connection object.
			con.ConnectionString = conn;
			// Attach the connection object to the command object
			cmd.Connection = con;

			// Display information about the connection.
			result += "Before cmd.Connection.Open() called" + "\n\n";
			result += string.Format(format, "Connection String", con.ConnectionString);
			result += string.Format(format, "Connection State", cmd.Connection.State);
			result += "\n";

			// Build sql string
			string sql = buildSqlString();
			// Add sql string to command object
			cmd.CommandText = sql;

			// Display SQL statement. Very useful debugging technique.
			result += string.Format(format, "Sql statement", cmd.CommandText);
			result += "\n";

			try {
				// Open the connection.
				cmd.Connection.Open();

				result += "After cmd.Connection.Open() called" + "\n\n";
				result += string.Format(format, "Connection State", cmd.Connection.State);
				result += "\n";

				// Read the data and put the results in data reader.
				IDataReader dr = cmd.ExecuteReader();

				result += "After cmd.ExecuteReader() called" + "\n\n";
				result += string.Format(format, "DataReader.IsClosed", dr.IsClosed);
				result += "\n";

				string header = string.Format(dataFormat, "PlayerID", "TeamID", "Last Name", "First Name", "Jersey Num", "Birth Date");
				data += header;

				int i = 1;
				// Read the data from the data reader. 
				// Note that this is one-pass, forward only.
				while (dr.Read()) {
					// Read the data. Must specify the data type you 
					// are reading (e.g. GetInt32) and the position
					// in the reader: 0, 1, etc. Note that this order
					// is the same as the order in the SQL statement.
					int pID = dr.GetInt32(0);
					int tID = dr.GetInt32(1);
					string lName = dr.GetString(2);
					string fName = dr.GetString(3);
					int jerNum = dr.GetInt32(4);
					DateTime bDate = dr.GetDateTime(5);
					
					// Stop after processing 3 rows of data.
					if (i++ < 4) {
						data += string.Format(dataFormat, pID, tID, lName, fName, jerNum, bDate);
					}
					else {
						break;
					}
				}

				// Close data reader and connection
				dr.Close();
				cmd.Connection.Close();

				result += "Read concluded, dr.Close() & cmd.Connection.Close() called" + "\n\n";
				result += string.Format(format, "DataReader.IsClosed", dr.IsClosed);
				result += string.Format(format, "Connection state", cmd.Connection.State);
				result += "\n";

				result += "First 3 rows of data: \n\n" + data + "\n";
				result += "--> SUCCESS <--" + "\n";
				txtMsg.Text += result;

			}
			catch (Exception ex) {
				txtMsg.Text += "--> Exception Thrown: " + "\n";
				txtMsg.Text += ex.ToString();
				txtMsg.Text += "--> FAILURE <--" + "\n";
			}
		}

		private static string buildSqlString() {
			return "SELECT " +
					"Players.PlayerID, " +
					"Players.TeamID, " +
					"Players.LName, " +
					"Players.FName, " +
					"Players.PNumber, " +
					"Players.BDate " +
				"FROM " +
					"Players " +
				"ORDER BY " +
					"Players.LName Asc, " +
					"Players.FName Asc";
		}
	}
}