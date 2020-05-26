using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication4.Repositories;

namespace WebApplication4.Models
{
   // public class QuestRoomHandler:IRepository
   // {
        //SqlConnection conn;

        //public int Count => throw new NotImplementedException();

        //public QuestRoom Add(QuestRoom item)
        //{
        //    CreateConnection();
        //    string query = "INSERT INTO QuestRoom " +
        //        "(Adress, Company, [Description], Email, LavelOfFear, LevelOfDifficulty, Logo," +
        //        "MaxPlayers, MinPlayers, [Name], Rating, [Time], Number) " +
        //        "VALUES(@adress, @company, @description, @email, @lavelOfFear, @levelOfDifficulty, " +
        //        "@logo, @maxPlayers, @minPlayers, @name, @rating, @time, @number)";
        //    int count = 0;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand command = new SqlCommand(query, conn);


        //        SqlParameter param1 = new SqlParameter();
        //        SqlParameter param2 = new SqlParameter();
        //        SqlParameter param3 = new SqlParameter();
        //        SqlParameter param4 = new SqlParameter();
        //        SqlParameter param5 = new SqlParameter();
        //        SqlParameter param6 = new SqlParameter();
        //        SqlParameter param7 = new SqlParameter();
        //        SqlParameter param8 = new SqlParameter();
        //        SqlParameter param9 = new SqlParameter();
        //        SqlParameter param10 = new SqlParameter();
        //        SqlParameter param11 = new SqlParameter();
        //        SqlParameter param12 = new SqlParameter();
        //        SqlParameter param13 = new SqlParameter();
        //        SqlParameter param14 = new SqlParameter();
        //        SqlParameter param15 = new SqlParameter();

        //        param1.ParameterName = "@adress";
        //        param1.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param1.Value = item.Adress;

        //        param2.ParameterName = "@company";
        //        param2.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param2.Value = item.Company;

        //        param3.ParameterName = "@description";
        //        param3.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param3.Value = item.Description;

        //        param4.ParameterName = "@email";
        //        param4.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param4.Value = item.Email;

        //        param5.ParameterName = "@lavelOfFear";
        //        param5.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param5.Value = item.LavelOfFear;

        //        param6.ParameterName = "@levelOfDifficulty";
        //        param6.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param6.Value = item.LevelOfDifficulty;

        //        param9.ParameterName = "@logo";
        //        param9.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param9.Value = item.Logo;

        //        param10.ParameterName = "@maxPlayers";
        //        param10.SqlDbType = System.Data.SqlDbType.Int;
        //        param10.Value = item.MaxPlayers;

        //        param11.ParameterName = "@minPlayers";
        //        param11.SqlDbType = System.Data.SqlDbType.Int;
        //        param11.Value = item.MinPlayers;

        //        param12.ParameterName = "@name";
        //        param12.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param12.Value = item.Name;

        //        param13.ParameterName = "@rating";
        //        param13.SqlDbType = System.Data.SqlDbType.Int;
        //        param13.Value = item.Rating;

        //        param14.ParameterName = "@time";
        //        param14.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param14.Value = item.Time;

        //        param15.ParameterName = "@number";
        //        param15.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param15.Value = item.Number;

        //        command.Parameters.AddRange(new[] { param1, param2, param3, param4, param5,
        //        param6, param9, param10, param11, param12, param13, param14, param15});
        //        count = command.ExecuteNonQuery();
        //    }
        //    finally
        //    {
        //        conn?.Close();
        //    }
        //    return item;

        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<QuestRoom> GetAll()
        //{
        //    CreateConnection();
        //    string query = "SELECT * FROM QuestRoom";
        //    List<QuestRoom> rooms = new List<QuestRoom>();
        //    DataTable dt = null;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand command = new SqlCommand(query, conn);
        //        SqlDataAdapter da = new SqlDataAdapter(command);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //    }
        //    finally
        //    {
        //        conn?.Close();
        //    }
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        QuestRoom room = new QuestRoom();
        //        room.Id = Convert.ToInt32(row["Id"]);
        //        room.Adress = row["Adress"].ToString();
        //        room.Company = row["Company"].ToString();
        //        room.Description = row["Description"].ToString();
        //        room.Email = row["Email"].ToString();
        //        room.LavelOfFear = Convert.ToInt32(row["LavelOfFear"]);
        //        room.LevelOfDifficulty = Convert.ToInt32(row["LevelOfDifficulty"]);
        //        room.Logo = row["Logo"].ToString();

        //        room.MaxPlayers = Convert.ToInt32(row["MaxPlayers"]);
        //        room.MinPlayers = Convert.ToInt32(row["MinPlayers"]);

        //        room.Name = row["Name"].ToString();
        //        room.Rating = Convert.ToInt32(row["Rating"]);
        //        room.Time = row["Time"].ToString();
        //        //room.Number = row["Number"].ToString();

        //        rooms.Add(room);
        //    }
        //    return rooms;

        //}

        //public QuestRoom GetById(int id)
        //{
        //    CreateConnection();
        //    string query = "SELECT * FROM QuestRoom where Id=" + id;
        //    QuestRoom room = new QuestRoom();
        //    DataTable dt = null;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand command = new SqlCommand(query, conn);
        //        SqlDataAdapter da = new SqlDataAdapter(command);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //    }
        //    finally
        //    {
        //        conn?.Close();
        //    }
        //    foreach (DataRow row in dt.Rows)
        //    {
          
        //        room.Id = Convert.ToInt32(row["Id"]);
        //        room.Adress = row["Adress"].ToString();
        //        room.Company = row["Company"].ToString();
        //        room.Description = row["Description"].ToString();
        //        room.Email = row["Email"].ToString();
        //        room.LavelOfFear = Convert.ToInt32(row["LavelOfFear"]);
        //        room.LevelOfDifficulty = Convert.ToInt32(row["LevelOfDifficulty"]);
        //        room.Logo = row["Logo"].ToString();

        //        room.MaxPlayers = Convert.ToInt32(row["MaxPlayers"]);
        //        room.MinPlayers = Convert.ToInt32(row["MinPlayers"]);

        //        room.Name = row["Name"].ToString();
        //        room.Rating = Convert.ToInt32(row["Rating"]);
        //        room.Time = row["Time"].ToString();
        //        room.Number = row["Number"].ToString();

        //    }
        //    return room;
        //}

        //public QuestRoom Update(QuestRoom item)
        //{
        //    CreateConnection();

        //    string query = "UPDATE QuestRoom SET Adress = @Adress," +
        //        " Company = @Company, Description = @Description," +
        //         " Email = @Email, LavelOfFear = @LavelOfFear," +
        //          " LevelOfDifficulty = @LevelOfDifficulty, Logo = @Logo," +
        //           " MaxPlayers = @MaxPlayers, MinPlayers = @MinPlayers," +
        //            " Name = @Name, Rating = @Rating," +
        //             " Time = @Time, Number = @Number," +
        //        " WHERE Id = @id";
        //    int count = 0;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand command = new SqlCommand(query, conn);

        //        SqlParameter param1 = new SqlParameter();
        //        param1.ParameterName = "@id";
        //        param1.SqlDbType = System.Data.SqlDbType.Int;
        //        param1.Value = item.Id;

        //        SqlParameter param2 = new SqlParameter();
        //        param2.ParameterName = "@Adress";
        //        param2.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param2.Value = item.Adress;

        //        SqlParameter param3 = new SqlParameter();
        //        param3.ParameterName = "@Company";
        //        param3.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param3.Value = item.Company;

        //        SqlParameter param4 = new SqlParameter();
        //        param4.ParameterName = "@Description";
        //        param4.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param4.Value = item.Description;

        //        SqlParameter param5 = new SqlParameter();
        //        param5.ParameterName = "@LavelOfFear";
        //        param5.SqlDbType = System.Data.SqlDbType.Int;
        //        param5.Value = item.LavelOfFear;

        //        SqlParameter param6 = new SqlParameter();
        //        param6.ParameterName = "@Email";
        //        param6.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param6.Value = item.Email;

        //        SqlParameter param7 = new SqlParameter();
        //        param7.ParameterName = "@LevelOfDifficulty";
        //        param7.SqlDbType = System.Data.SqlDbType.Int;
        //        param7.Value = item.LevelOfDifficulty;

        //        SqlParameter param8 = new SqlParameter();
        //        param8.ParameterName = "@Logo";
        //        param8.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param8.Value = item.Logo;

        //        SqlParameter param9 = new SqlParameter();
        //        param9.ParameterName = "@MaxPlayers";
        //        param9.SqlDbType = System.Data.SqlDbType.Int;
        //        param9.Value = item.MaxPlayers;

        //        SqlParameter param10 = new SqlParameter();
        //        param10.ParameterName = "@MinPlayers";
        //        param10.SqlDbType = System.Data.SqlDbType.Int;
        //        param10.Value = item.MinPlayers;

        //        SqlParameter param11 = new SqlParameter();
        //        param11.ParameterName = "@Name";
        //        param11.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param11.Value = item.Name;

        //        SqlParameter param12 = new SqlParameter();
        //        param12.ParameterName = "@Rating";
        //        param12.SqlDbType = System.Data.SqlDbType.Int;
        //        param12.Value = item.Rating;

        //        SqlParameter param13 = new SqlParameter();
        //        param13.ParameterName = "@Time";
        //        param13.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param13.Value = item.Time;

        //        SqlParameter param14 = new SqlParameter();
        //        param14.ParameterName = "@Number";
        //        param14.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        //param14.Value = item.Number;



        //        command.Parameters.AddRange(new[] { param1, param2, param3, param4, param5,
        //        param6, param7, param8, param9, param10, param11, param12, param13, param14});
        //        count = command.ExecuteNonQuery();
        //    }
        //    finally
        //    {
        //        conn?.Close();
        //    }
        //    return item;

        //}

        //private void CreateConnection()
        //{
        //    conn = new SqlConnection();
        //    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuestRoomDBString"].ConnectionString;
        //}

        //public bool 
    //}
}