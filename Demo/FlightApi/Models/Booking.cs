﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Client.Models;
using Newtonsoft.Json.Linq;

namespace Client.Models
{
    public partial class Booking
    {
        private int? _bookingId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? BookingId
        {
            get { return this._bookingId; }
            set { this._bookingId = value; }
        }
        
        private string _firstName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        
        private Flight _flight;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Flight Flight
        {
            get { return this._flight; }
            set { this._flight = value; }
        }
        
        private int? _flightId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? FlightId
        {
            get { return this._flightId; }
            set { this._flightId = value; }
        }
        
        private string _lastName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Booking class.
        /// </summary>
        public Booking()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken bookingIdValue = inputObject["BookingId"];
                if (bookingIdValue != null && bookingIdValue.Type != JTokenType.Null)
                {
                    this.BookingId = ((int)bookingIdValue);
                }
                JToken firstNameValue = inputObject["FirstName"];
                if (firstNameValue != null && firstNameValue.Type != JTokenType.Null)
                {
                    this.FirstName = ((string)firstNameValue);
                }
                JToken flightValue = inputObject["Flight"];
                if (flightValue != null && flightValue.Type != JTokenType.Null)
                {
                    Flight flight = new Flight();
                    flight.DeserializeJson(flightValue);
                    this.Flight = flight;
                }
                JToken flightIdValue = inputObject["FlightId"];
                if (flightIdValue != null && flightIdValue.Type != JTokenType.Null)
                {
                    this.FlightId = ((int)flightIdValue);
                }
                JToken lastNameValue = inputObject["LastName"];
                if (lastNameValue != null && lastNameValue.Type != JTokenType.Null)
                {
                    this.LastName = ((string)lastNameValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Booking
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.BookingId != null)
            {
                outputObject["BookingId"] = this.BookingId.Value;
            }
            if (this.FirstName != null)
            {
                outputObject["FirstName"] = this.FirstName;
            }
            if (this.Flight != null)
            {
                outputObject["Flight"] = this.Flight.SerializeJson(null);
            }
            if (this.FlightId != null)
            {
                outputObject["FlightId"] = this.FlightId.Value;
            }
            if (this.LastName != null)
            {
                outputObject["LastName"] = this.LastName;
            }
            return outputObject;
        }
    }
}
