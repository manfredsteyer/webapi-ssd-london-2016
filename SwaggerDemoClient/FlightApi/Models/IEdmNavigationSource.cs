﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using SwaggerDemoClient.Models;

namespace SwaggerDemoClient.Models
{
    public partial class IEdmNavigationSource
    {
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<IEdmNavigationPropertyBinding> _navigationPropertyBindings;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<IEdmNavigationPropertyBinding> NavigationPropertyBindings
        {
            get { return this._navigationPropertyBindings; }
            set { this._navigationPropertyBindings = value; }
        }
        
        private IEdmPathExpression _path;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmPathExpression Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        
        private IEdmType _type;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationSource class.
        /// </summary>
        public IEdmNavigationSource()
        {
            this.NavigationPropertyBindings = new LazyList<IEdmNavigationPropertyBinding>();
        }
    }
}
