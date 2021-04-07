using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Windows.Forms;

namespace PutevoiListAvto
{
    class SqlQueues
    {
        public void WriteCompany(string cName1, string cAdress1, string cName2, string cAdress2, string distance2)
        {
            string distance = distance2.Replace(",", ".");
            SQLiteConnection DB = new SQLiteConnection(LoadConnectionString());
            DB.Open();
            SQLiteCommand command = new SQLiteCommand(
                            "INSERT INTO PutevoiTable(CompanyName,CompanyAdress)" +
                            "SELECT * FROM(SELECT '" + cName1 + "','" + cAdress1 + "')" +
                            "WHERE NOT EXISTS(SELECT CompanyName FROM PutevoiTable Where CompanyName='" + cName1 + "') " +
                            "LIMIT 1;" +

                            "INSERT INTO PutevoiTable(CompanyName,CompanyAdress)" +
                            "SELECT * FROM(SELECT '" + cName2 + "','" + cAdress2 + "')" +
                            "WHERE NOT EXISTS(SELECT CompanyName FROM PutevoiTable Where CompanyName='" + cName2 + "') " +
                            "LIMIT 1;" +

                            "INSERT INTO Distance(CompanyIn,AddressIn,CompanyOut,AddressOut,distance)" +
                            "SELECT * FROM(SELECT '" + cName1 + "','" + cAdress1 + "'," + "'" + cName2 + "', '" + cAdress2 + "'," + distance + ")" +
                            "WHERE NOT EXISTS(SELECT CompanyIn,CompanyOut from Distance where CompanyIn='" + cName1 + "'" +
                            " AND CompanyOut='" + cName2 + "')" +
                            "LIMIT 1", DB);
            command.ExecuteNonQuery();
            command.Dispose();
            DB.Close();
        }

        public List<string[]> SuggestCompanyNames() //suggest companies in BD
        {
            SQLiteConnection DB = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand command = new SQLiteCommand("Select CompanyName, CompanyAdress from PutevoiTable", DB);
            List<string[]> name = new List<string[]>();
            SQLiteDataReader Reader = null;
            try
            {
                DB.Open();
                Reader = command.ExecuteReader();
                int i = 0;
                while (Reader.Read())
                {
                    string[] buffer = { Reader.GetString(0), Reader.GetString(1) };
                    name.Add(buffer);
                    i += 1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), Ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Reader != null)
                    Reader.Close();
                DB.Close();
            }
            return name;
        }
        public string FindAdressAdressForCompanyName(string companyName)
        {
            SQLiteConnection DB = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand command = new SQLiteCommand("SELECT CompanyAdress FROM PutevoiTable" +
                                        "WHERE CompanyName= '" + companyName + "'", DB);
            SQLiteDataReader reader = null;
            string companyAdress = "";
            try
            {
                DB.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    companyAdress = reader.GetString(0);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), Ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                DB.Close();
            }
            return companyAdress;
        }

        public double FindDistanceBetweenAddresses(string companyIn, string companyOut)
        {
            SQLiteConnection db = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand command = new SQLiteCommand("SELECT distance from Distance WHERE CompanyIn='" + companyIn + "' And CompanyOut='" + companyOut + "'", db);
            SQLiteDataReader reader = null;
            double distance = -1;
            try
            {
                db.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    distance = reader.GetDouble(0);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), Ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                db.Close();
            }
            return distance;
        }

        public List<string[]> SelectBDTable()
        {
            SQLiteConnection db = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand command = new SQLiteCommand("SELECT CompanyIn, AddressIn, CompanyOut, AddressOut, distance FROM Distance", db);
            SQLiteDataReader reader = null;
            List<string[]> listDistance = new List<string[]>();
            try
            {
                db.Open();
                reader = command.ExecuteReader();
                string[] buffer;
                while (reader.Read())
                {
                    buffer = new string[5];
                    buffer[0] = reader.GetString(0);
                    buffer[1] = reader.GetString(1);
                    buffer[2] = reader.GetString(2);
                    buffer[3] = reader.GetString(3);
                    buffer[4] = reader.GetDouble(4).ToString();
                    listDistance.Add(buffer);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), Ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                db.Close();
            }
            return listDistance;
        }
        public void UpdateCompany(string oldcName1, string oldcName2, DistanceEntity newDistanceEntity)
        {
            SQLiteConnection db = new SQLiteConnection(LoadConnectionString());
            string distance = newDistanceEntity.Distance.Replace(",", ".");
            SQLiteCommand command = new SQLiteCommand($"UPDATE PutevoiTable SET CompanyName='{newDistanceEntity.CompanyIn}'," +
                                                       $"CompanyAdress='{newDistanceEntity.AddressIn}' WHERE CompanyName='{oldcName1}';" +

                                                       $"UPDATE PutevoiTable SET CompanyName='{newDistanceEntity.CompanyOut}', " +
                                                       $"CompanyAdress='{newDistanceEntity.AddressOut}' WHERE CompanyName='{oldcName2}';"+
                                                       
                                                       $"UPDATE Distance SET AddressIn='{newDistanceEntity.AddressIn}'," +
                                                       $"CompanyIn='{newDistanceEntity.CompanyIn}' Where CompanyIn='{oldcName1}';" +

                                                       $"UPDATE Distance SET AddressOut='{newDistanceEntity.AddressIn}'," +
                                                       $"CompanyOut='{newDistanceEntity.CompanyIn}' Where CompanyOut='{oldcName1}';" +

                                                       $"UPDATE Distance SET AddressIn='{newDistanceEntity.AddressOut}'," +
                                                       $"CompanyIn='{newDistanceEntity.CompanyOut}' Where CompanyIn='{oldcName2}';" +

                                                       $"UPDATE Distance SET AddressOut='{newDistanceEntity.AddressOut}'," +
                                                       $"CompanyOut='{newDistanceEntity.CompanyOut}' Where CompanyOut='{oldcName2}';" +

                                                       $"UPDATE Distance SET distance='{distance}'" +
                                                       $"Where CompanyIn='{newDistanceEntity.CompanyIn}' AND " +
                                                       $"CompanyOut='{newDistanceEntity.CompanyOut}'"
                                                       , db);
            try
            {
                db.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                command.Dispose();
                db.Close();
            }
        }
        public void DeleteDistance( DistanceEntity distanceEntity)
        {
            SQLiteConnection db = new SQLiteConnection(LoadConnectionString());
            SQLiteCommand command = new SQLiteCommand($"DELETE FROM Distance WHERE CompanyIn='{distanceEntity.CompanyIn}'" +
                                                      $" AND CompanyOut ='{distanceEntity.CompanyOut}'", db);
            try
            {
                db.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                command.Dispose();
                db.Close();
            }
        }




        private string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }

}


