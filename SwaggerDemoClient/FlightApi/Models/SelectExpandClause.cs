﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;

namespace SwaggerDemoClient.Models
{
    public partial class SelectExpandClause
    {
        private bool? _allSelected;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? AllSelected
        {
            get { return this._allSelected; }
            set { this._allSelected = value; }
        }
        
        private IList<string> _selectedItems;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> SelectedItems
        {
            get { return this._selectedItems; }
            set { this._selectedItems = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SelectExpandClause class.
        /// </summary>
        public SelectExpandClause()
        {
            this.SelectedItems = new LazyList<string>();
        }
    }
}
