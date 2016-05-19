﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using SwaggerDemoClient.Models;

namespace SwaggerDemoClient.Models
{
    public partial class IEdmStructuredType
    {
        private IEdmStructuredType _baseType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IEdmStructuredType BaseType
        {
            get { return this._baseType; }
            set { this._baseType = value; }
        }
        
        private IList<IEdmProperty> _declaredProperties;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<IEdmProperty> DeclaredProperties
        {
            get { return this._declaredProperties; }
            set { this._declaredProperties = value; }
        }
        
        private bool? _isAbstract;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? IsAbstract
        {
            get { return this._isAbstract; }
            set { this._isAbstract = value; }
        }
        
        private bool? _isOpen;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? IsOpen
        {
            get { return this._isOpen; }
            set { this._isOpen = value; }
        }
        
        private int? _typeKind;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? TypeKind
        {
            get { return this._typeKind; }
            set { this._typeKind = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IEdmStructuredType class.
        /// </summary>
        public IEdmStructuredType()
        {
            this.DeclaredProperties = new LazyList<IEdmProperty>();
        }
    }
}
