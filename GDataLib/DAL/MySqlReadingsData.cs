using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDataLib.BO;
using MySql.Data.MySqlClient;

namespace GDataLib.DAL
{
    class MySqlReadingsData
    {
        public bool Create(Readings Readings)
        {
            String _Sql = "INSERT INTO Readings(ReadingsId,Date,Field,OilProduced,GasLift,NAGProduced,CONGProduced,BSWProduced,AGProduced) VALUES(?ReadingsId,?Date,?Field,?OilProduced,?GasLift,?NAGProduced,?CONGProduced,?BSWProduced,?AGProduced)";
            var _Connection = new MySqlConnection(Config.MySqlConnString);
            try
            {


                List<MySqlParameter> _Parameters = new List<MySqlParameter>()
                {
                    new MySqlParameter(){ParameterName="?ReadingsId",DbType= System.Data.DbType.String,Value=Readings.ReadingsId.ToString()},
                    new MySqlParameter(){ParameterName="?Date",DbType= System.Data.DbType.DateTime,Value=Readings.Date},
                    new MySqlParameter(){ParameterName="?Field",DbType= System.Data.DbType.String,Value=Readings.Field},
                    new MySqlParameter(){ParameterName="?OilProduced",DbType= System.Data.DbType.Double,Value=Readings.OilProduced},
                    new MySqlParameter(){ParameterName="?GasLift",DbType= System.Data.DbType.Double,Value=Readings.GasLift},
                    new MySqlParameter(){ParameterName="?NAGProduced",DbType= System.Data.DbType.Double,Value=Readings.NAGProduced},
                    new MySqlParameter(){ParameterName="?CONGProduced",DbType= System.Data.DbType.Double,Value=Readings.CONGProduced},
                    new MySqlParameter(){ParameterName="?BSWProduced",DbType= System.Data.DbType.Double,Value=Readings.BSWProduced},
                    new MySqlParameter(){ParameterName="?AGProduced",DbType= System.Data.DbType.Double,Value=Readings.AGProduced}
                };
                _Connection.Open();
                int i = MySqlHelper.ExecuteNonQuery(_Connection, _Sql, _Parameters.ToArray<MySqlParameter>());
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
            finally
            {
                if (_Connection != null)
                {
                    if (_Connection.State == System.Data.ConnectionState.Open)
                    {
                        _Connection.Close();
                    }
                }
            }
        }


        public List<Readings> Read()
        {
            String _Sql = "SELECT ReadingsId,Date,Field,OilProduced,GasLift,NAGProduced,CONGProduced,BSWProduced,AGProduced FROM Readings";
            List<Readings> _Readings = null;
            var _Connection = new MySqlConnection(Config.MySqlConnString);
            try
            {

                _Connection.Open();

                var _Reader = MySqlHelper.ExecuteReader(Config.MySqlConnString, _Sql);

                if (_Reader != null)
                {
                    _Readings = new List<Readings>();
                    if (_Reader.HasRows)
                    {
                        while (_Reader.Read())
                        {
                            var _Reading = new Readings();
                            _Reading.ReadingsId = Guid.Parse(_Reader["ReadingsId"].ToString());
                            _Reading.Date = Convert.ToDateTime(_Reader["Date"]);
                            _Reading.Field = _Reader["Field"].ToString();
                            _Reading.OilProduced = Convert.ToDouble(_Reader["OilProduced"]);
                            _Reading.GasLift = Convert.ToDouble(_Reader["GasLift"]);
                            _Reading.NAGProduced = Convert.ToDouble(_Reader["NAGProduced"]);
                            _Reading.CONGProduced = Convert.ToDouble(_Reader["CONGProduced"]);
                            _Reading.BSWProduced = Convert.ToDouble(_Reader["BSWProduced"]);
                            _Reading.AGProduced = Convert.ToDouble(_Reader["AGProduced"]);
                            _Readings.Add(_Reading);
                        }
                    }
                }


                return _Readings;
            }
            catch (Exception Ew)
            {
                return null;
            }
            finally
            {
                if (_Connection != null)
                {
                    if (_Connection.State == System.Data.ConnectionState.Open)
                    {
                        _Connection.Close();
                    }
                }
            }

        }


        public bool Update(Readings Readings)
        {
            String _Sql = "UPDATE  Readings SET Date = ?Date,Field = ?Field,OilProduced= ?OilProduced,GasLift = ?GasLift,NAGProduced = ?NAGProduced,CONGProduced = ?CONGProduced,BSWProduced = ?BSWProduced,AGProduced = ?AGProduced WHERE  ReadingsId=?ReadingsId";
            var _Connection = new MySqlConnection(Config.MySqlConnString);
            try
            {
               

                List<MySqlParameter> _Parameters = new List<MySqlParameter>()
                {
                    new MySqlParameter(){ParameterName="?ReadingsId",DbType= System.Data.DbType.String,Value=Readings.ReadingsId.ToString()},
                    new MySqlParameter(){ParameterName="?Date",DbType= System.Data.DbType.DateTime,Value=Readings.Date},
                    new MySqlParameter(){ParameterName="?Field",DbType= System.Data.DbType.String,Value=Readings.Field},
                    new MySqlParameter(){ParameterName="?OilProduced",DbType= System.Data.DbType.Double,Value=Readings.OilProduced},
                    new MySqlParameter(){ParameterName="?GasLift",DbType= System.Data.DbType.Double,Value=Readings.GasLift},
                    new MySqlParameter(){ParameterName="?NAGProduced",DbType= System.Data.DbType.Double,Value=Readings.NAGProduced},
                    new MySqlParameter(){ParameterName="?CONGProduced",DbType= System.Data.DbType.Double,Value=Readings.CONGProduced},
                    new MySqlParameter(){ParameterName="?BSWProduced",DbType= System.Data.DbType.Double,Value=Readings.BSWProduced},
                    new MySqlParameter(){ParameterName="?AGProduced",DbType= System.Data.DbType.Double,Value=Readings.AGProduced}
                };
                _Connection.Open();
                int i = MySqlHelper.ExecuteNonQuery(_Connection, _Sql, _Parameters.ToArray<MySqlParameter>());
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
            finally
            {
                if (_Connection != null)
                {
                    if (_Connection.State == System.Data.ConnectionState.Open)
                    {
                        _Connection.Close();
                    }
                }
            }
        }


        public bool Delete(Readings Readings)
        {
            String _Sql = "DELETE  FROM Readings  WHERE  ReadingsId=?ReadingsId";
            var _Connection = new MySqlConnection(Config.MySqlConnString);
            try
            {
                _Connection.Open();
                int i = MySqlHelper.ExecuteNonQuery(_Connection, _Sql, new MySqlParameter(){ParameterName="?ReadingsId",DbType= System.Data.DbType.String,Value=Readings.ReadingsId.ToString()});
                return true;
            }
            catch (Exception Ew)
            {
                return false;
            }
            finally
            {
                if (_Connection != null)
                {
                    if (_Connection.State == System.Data.ConnectionState.Open)
                    {
                        _Connection.Close();
                    }
                }
            }
        }
    }
}
