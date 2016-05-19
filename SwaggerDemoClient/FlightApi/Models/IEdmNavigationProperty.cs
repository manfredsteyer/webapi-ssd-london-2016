﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using SwaggerDemoClient.Models;

namespace SwaggerDemoClient.Models
{
    public partial class IEdmNavigationProperty
    {
        private bool? _containsTarget;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? ContainsTarget
        {
            get { return this._containsTarget; }
            set { this._containsTarget = value; }
        }
        
        private IEdmStructuredType _declaringType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmStructuredType DeclaringType
        {
            get { return this._declaringType; }
            set { this._declaringType = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int? _onDelete;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? OnDelete
        {
            get { return this._onDelete; }
            set { this._onDelete = value; }
        }
        
        private IEdmNavigationProperty _partner;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmNavigationProperty Partner
        {
            get { return this._partner; }
            set { this._partner = value; }
        }
        
        private int? _propertyKind;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? PropertyKind
        {
            get { return this._propertyKind; }
            set { this._propertyKind = value; }
        }
        
        private IEdmReferentialConstraint _referentialConstraint;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmReferentialConstraint ReferentialConstraint
        {
            get { return this._referentialConstraint; }
            set { this._referentialConstraint = value; }
        }
        
        private IEdmTypeReference _type;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmTypeReference Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationProperty class.
        /// </summary>
        public IEdmNavigationProperty()
        {
        }
    }
}
