﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;

namespace SwaggerDemoClient.Models
{
    public partial class ODataRawQueryOptions
    {
        private string _apply;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Apply
        {
            get { return this._apply; }
            set { this._apply = value; }
        }
        
        private string _count;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private string _deltaToken;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string DeltaToken
        {
            get { return this._deltaToken; }
            set { this._deltaToken = value; }
        }
        
        private string _expand;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Expand
        {
            get { return this._expand; }
            set { this._expand = value; }
        }
        
        private string _filter;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }
        
        private string _format;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }
        
        private string _orderBy;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }
        
        private string _select;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Select
        {
            get { return this._select; }
            set { this._select = value; }
        }
        
        private string _skip;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Skip
        {
            get { return this._skip; }
            set { this._skip = value; }
        }
        
        private string _skipToken;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string SkipToken
        {
            get { return this._skipToken; }
            set { this._skipToken = value; }
        }
        
        private string _top;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ODataRawQueryOptions class.
        /// </summary>
        public ODataRawQueryOptions()
        {
        }
    }
}
