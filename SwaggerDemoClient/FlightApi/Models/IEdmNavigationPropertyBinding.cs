﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using SwaggerDemoClient.Models;

namespace SwaggerDemoClient.Models
{
    public partial class IEdmNavigationPropertyBinding
    {
        private IEdmNavigationProperty _navigationProperty;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmNavigationProperty NavigationProperty
        {
            get { return this._navigationProperty; }
            set { this._navigationProperty = value; }
        }
        
        private IEdmNavigationSource _target;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmNavigationSource Target
        {
            get { return this._target; }
            set { this._target = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationPropertyBinding
        /// class.
        /// </summary>
        public IEdmNavigationPropertyBinding()
        {
        }
    }
}
