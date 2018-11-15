﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSource.Client
{
    /// <summary>
    /// API Request
    /// </summary>
    public class ApiRequest<T>
    {
        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public IList<string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the data (parsed HTTP Request body)
        /// </summary>
        /// <value>The data.</value>
        public T Data { get;  set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRequest&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiRequest(IList<string> headers, T data)
        {
            this.Headers = headers;
            this.Data = data;
        }
    }
}