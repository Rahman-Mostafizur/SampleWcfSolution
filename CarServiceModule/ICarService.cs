using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarServiceModule
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarService" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        List<Car> GetCars();

        [OperationContract]
        Car GetCar(int id);

        [OperationContract]
        Car SaveCar(Car car);

        [OperationContract]
        Car UpdateCar(Car car);

        [OperationContract]
        Car DeleteCar(Car car);
    }
}
