﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;

namespace SwaggerDemoClient.Models
{
    public partial class IEdmTerm
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
        
        private string _namespaceVariable;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Namespace
        {
            get { return this._namespaceVariable; }
            set { this._namespaceVariable = value; }
        }
        
        private int? _schemaElementKind;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? SchemaElementKind
        {
            get { return this._schemaElementKind; }
            set { this._schemaElementKind = value; }
        }
        
        private int? _termKind;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? TermKind
        {
            get { return this._termKind; }
            set { this._termKind = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IEdmTerm class.
        /// </summary>
        public IEdmTerm()
        {
        }
    }
}