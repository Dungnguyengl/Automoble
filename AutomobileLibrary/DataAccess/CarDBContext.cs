using AutomobileLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
        // Singetoning all over the place
        private static List<Car> CarList = new List<Car>()
        {
            new Car
            {
                CarID = 1,
                CarName = "CRV",
                Manufacturer = "Honda",
                Price = 30000,
                ReleaseYear = 2021
            },
            new Car
            {
                CarID = 2,
                CarName = "Ford Focus",
                Manufacturer = "Ford",
                Price = 15000,
                ReleaseYear = 2020
            }
        };

        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public List<Car> GetCarList()
        {
            IDataReader? dataReader = null;
            string SQLSelect =
                "Select CarID, CarName, Manufacturer, Price, ReleaseYear from Cars";
            var cars = new List<Car>();
            try
            {
                dataReader = DataProvider
                    .GetDataReader(SQLSelect, CommandType.Text, out Connection);
                while (dataReader.Read())
                {
                    cars.Add(new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return cars;
        }

        public Car GetCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            try
            {                
                string SQLSelect = "Select CarID, CarName, Manufacturer, Price, ReleaseYear "
                    + "From Cars where CarID = @CarID";
                var param = DataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out Connection, param);
                if (dataReader.Read())
                {
                    car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return car;
        }

        public void AddNew(Car car)
        {
            try
            {
                Car pro = GetCarByID(car.CarID);
                if (pro == null)
                {
                    string SQLInsert
                        = "Insert Cars values (@CarID,@CarName, @Manufacturer, @Price, @ReleaseYear)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Car is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarID);
                if (c != null)
                {
                    string SQLUpdate
                       = "Update Cars Set " +
                       "CarName = @CarName, " +
                       "Manufacturer = @Manufacturer, " +
                       "Price = @Price, " +
                       "ReleaseYear = @ReleaseYear WHERE CarID=@CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    DataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int CarID)
        {
            try
            {
                Car p = GetCarByID(CarID);
                if (p != null)
                {
                    string SQLDelete = "DELETE Cars WHERE CarID = @CarID";
                    var param = DataProvider.CreateParameter("@CarID", 4, CarID, DbType.Int32);
                    DataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("Car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
