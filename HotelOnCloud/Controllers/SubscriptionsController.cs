using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelOnCloud.BusinessLayer;

namespace HotelOnCloud.Controllers
{
    public class SubscriptionsController : Controller
    {
        //
        // GET: /Subscriptions/
        HotelCloudEntities entities = new HotelCloudEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(HotelOnCloud.Models.SubscribeModel model )
        {
            //if(ModelState.IsValid )
            {
                Client newClient = new Client();

                newClient.ID = 1;
                newClient.Address = model.Address;
                newClient.City = model.City;
                newClient.Country = model.Country;
                newClient.Email = model.Email;
                newClient.Name = model.Name;
                newClient.OwnerName = model.OwnerName;
                newClient.State = model.State;
                newClient.ZipCode = model.ZipCode;
                entities.Clients.Add(newClient);

                entities.SaveChanges();

                Property iProperty = new Property();
                iProperty.ID = 1;
                iProperty.Address = model.PropertyAddress;
                iProperty.City = model.PropertyCity;
                iProperty.ClientID = newClient.ID;
                iProperty.ContactNumber = model.ContactNumber;
                iProperty.ContactPerson = model.ContactPerson;
                iProperty.Country = model.PropertyCountry;
                iProperty.Email = model.PropertyEmail;
                iProperty.PropertyName = model.PropertyName;
                iProperty.Fax = model.Fax;
                iProperty.State = model.PropertyState;
                iProperty.Website = model.PropertyWebsite;

                entities.Properties.Add(iProperty);

                entities.SaveChanges();

                Subscription newSubscription = new Subscription();
                newSubscription.ID = 1;
                newSubscription.PropertyID = iProperty.ID;
                newSubscription.StartDate = DateTime.Today.Date;
                newSubscription.EndDate = DateTime.Today.Date.AddDays(30);
                newSubscription.SubscriptionStatus = "A";
                entities.Subscriptions.Add(newSubscription);
                entities.SaveChanges();

                Authentication iAuthentication = new Authentication();
                iAuthentication.ID = 1;
                iAuthentication.UserName = newClient.Email;
                int randomNumber = Utils.RandomNumber();
                string encryptPasssword = Utils.Encrypt(model.Password.ToLower().Trim(), randomNumber.ToString(), true);
                iAuthentication.HashCode = Convert.ToString (randomNumber);
                iAuthentication.Password = encryptPasssword;
                iAuthentication.Confirmed = 0;
                iAuthentication.ConfCode = Utils.RandomString(48);
                entities.Authentications.Add(iAuthentication);

                Authentication pAuthentication = new Authentication();
                pAuthentication.ID = 2;
                pAuthentication.UserName = model.PropertyEmail ;
                randomNumber = Utils.RandomNumber();
                encryptPasssword = Utils.Encrypt(model.PropertyPassword .ToLower().Trim(), 
                    randomNumber.ToString(), true);
                pAuthentication.HashCode = Convert.ToString(randomNumber);
                pAuthentication.Password = encryptPasssword;
                pAuthentication.Confirmed = 0;
                pAuthentication.ConfCode = Utils.RandomString(48);
                entities.Authentications.Add(pAuthentication);
                entities.SaveChanges();

            }
            return View();
        }
    }
}
