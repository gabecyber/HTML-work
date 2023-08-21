﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace lab09_Interiano {
    public partial class Page4 : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			// Display the data if this is the first time on the page.
			if (!Page.IsPostBack) {
				displayData();
			}
		}
		/// <summary>
		/// Deletes a row from the Players table.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnDelete_Click(object sender, EventArgs e) {
			// Create the Command object
			IDbCommand cmd = getCommand();
			// Set the Delete SQL statement into the Command
			cmd.CommandText = getDeleteSql();
			// Display the SQL statement
			txtMsg.Text = "DELETE Sql statement:\n" + cmd.CommandText + "\n";
			try {
				// Open the connection.
				cmd.Connection.Open();
				// Deletes the row from the Players table and returns how many rows are affected.
				// If successful, this will be 1, as 1 row has been deleted. If not successfull,
				// then 0 will be returned.
				int rowsAffected = cmd.ExecuteNonQuery();
				txtMsg.Text += "Rows affected=" + rowsAffected + "\n";
				cmd.Connection.Close();
				// Display the updated GridView.
				displayData();
				clearTextBoxes();
			}
			catch (Exception ex) {
				txtMsg.Text += ex.ToString();
			}
		}

		/// <summary>
		/// Updates a row in the Players table.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnUpdate_Click(object sender, EventArgs e) {
			// Create the Command object
			IDbCommand cmd = getCommand();
			// Set the Update SQL statement into the Command
			cmd.CommandText = getUpdateSql();
			// Display the SQL statement
			txtMsg.Text = "UPDATE Sql statement:\n" + cmd.CommandText + "\n";
			try {
				// Open the connection.
				cmd.Connection.Open();
				// Updates the row in the Players table and returns how many rows are affected.
				// If successful, this will be 1, as 1 row has been added. If not successfull,
				// then 0 will be returned.
				int rowsAffected = cmd.ExecuteNonQuery();
				txtMsg.Text += "Rows affected=" + rowsAffected + "\n";
				cmd.Connection.Close();
				// Display the updated GridView
				displayData();
				clearTextBoxes();
			}
			catch (Exception ex) {
				txtMsg.Text += ex.ToString();
			}
		}

		/// <summary>
		/// Displays the data from the Players table in a GridView.
		/// </summary>
		private void displayData() {
			IDbCommand cmd = getCommand();
			cmd.CommandText = getSelectSql();
			try {
				// Open the connection.
				cmd.Connection.Open();
				// Load data into the reader
				IDataReader dr = cmd.ExecuteReader();
				// Link the Gridview to the reader
				gvPlayers.DataSource = dr;
				// Bind the reader to GridView, i.e. put the data into the GridView.
				gvPlayers.DataBind();
				dr.Close();
				cmd.Connection.Close();
			}
			catch (Exception ex) {
				txtMsg.Text += ex.ToString();
			}
		}

		/// <summary>
		/// Returns a Command object that is connected to a Connection object. The Connection
		/// object has its ConnectionString property set to the value in web.config.
		/// </summary>
		/// <returns>Command object</returns>
		private IDbCommand getCommand() {
			IDbConnection con = new System.Data.OleDb.OleDbConnection();
			IDbCommand cmd = new System.Data.OleDb.OleDbCommand();
			string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["playersConnectionString"].ConnectionString;
			con.ConnectionString = connectionString;
			cmd.Connection = con;
			return cmd;
		}

		/// <summary>
		/// Returns a SQL statement that selects all the data from the Players table
		/// sorted on last name, then first name.
		/// </summary>
		/// <returns>Select SQL statement</returns>
		private string getSelectSql() {
			string sql =
				"SELECT " +
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
			return sql;
		}

		/// <summary>
		/// Returns a SQL statement that updates a row in the Players table, using the 
		/// values from the text boxes for the field values in the table.
		/// </summary>
		/// <returns>Insert SQL statement</returns>
		private string getUpdateSql() {
			string sql =
				"UPDATE Players SET " +
				"TeamID=" + txtTeamID.Text + ", " +
				"LName='" + txtLName.Text + "', " +
				"FName='" + txtFName.Text + "', " +
				"PNumber=" + txtPNum.Text + ", " +
				"BDate='" + txtBDate.Text + "' " +
				"WHERE PlayerID=" + txtPlayerID.Text;
			return sql;
		}

		/// <summary>
		/// Clear the text boxes.
		/// </summary>
		private void clearTextBoxes() {
			txtPlayerID.Text = String.Empty;
			txtTeamID.Text = String.Empty;
			txtLName.Text = String.Empty;
			txtFName.Text = String.Empty;
			txtPNum.Text = String.Empty;
			txtBDate.Text = String.Empty;
			txtPlayerIDDelete.Text = String.Empty;
		}

		/// <summary>
		/// Returns a SQL statement that deletes a row in the Players table.
		/// </summary>
		/// <returns>Insert SQL statement</returns>
		private string getDeleteSql() {
			string sql =
				"DELETE FROM Players WHERE PlayerID=" + txtPlayerIDDelete.Text;
			return sql;
		}


	}
}