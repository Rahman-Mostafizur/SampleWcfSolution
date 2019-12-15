using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationCarClient.CarServiceReference;

namespace WebApplicationCarClient.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

            client.Open();

            var data = client.GetCars();

            client.Close();
            return View(data);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

            client.Open();

            var data = client.GetCar(id);

            client.Close();

            return View(data);
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        public ActionResult Create(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

                    client.Open();

                    var data = client.SaveCar(car);

                    client.Close();


                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }




            }
            catch
            {
                return View(car);
            }
            return View(car);
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

            client.Open();

            var data = client.GetCar(id);

            client.Close();

            return View(data);
        }

        // POST: Car/Edit/5
        [HttpPost]
        public ActionResult Edit(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

                    client.Open();

                    client.UpdateCar(car);

                    client.Close();


                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View(car);
            }
             return View(car);
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

            client.Open();

            var data = client.GetCar(id);

            client.Close();

            return View(data);
        }

        // POST: Car/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {

                CarServiceReference.CarServiceClient client = new CarServiceReference.CarServiceClient();

                client.Open();

                var data = client.GetCar(id);
                 client.DeleteCar(data);

                client.Close();


                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
