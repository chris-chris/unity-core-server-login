using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DotnetCoreServer.Models
{
    public interface IStageResultDao{
        bool InsertStageRecord(long UserID, int Point);
    }

    public class StageResultDao : IStageResultDao
    {
        public IDB db {get;}

        public StageResultDao(IDB db){
            this.db = db;
        }

        public bool InsertStageRecord(long UserID, int Point){
            
            string query = String.Format(
                @"INSERT INTO tb_stage_record 
                (user_id, point, record_time)
                  VALUES ('{0}','{1}', now())",
                    UserID, Point);

            Console.WriteLine(query);

            using(MySqlConnection conn = db.GetConnection())
            using(MySqlCommand cmd = (MySqlCommand)conn.CreateCommand())
            {

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                conn.Close();
            }

        
            return true;
        }




    }
}