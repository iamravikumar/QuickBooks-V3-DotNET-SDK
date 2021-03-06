﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// Modified for Intuit's Oauth2 implementation

using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
    /// <summary>
    /// Formatter for Basic Authentication header
    /// </summary>
    public class BasicAuthenticationHeaderValue : AuthenticationHeaderValue
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="clientId">clientId</param>
        /// <param name="clientSecret">clientSecret</param>
        public BasicAuthenticationHeaderValue(string clientId, string clientSecret)
            : base("Basic", EncodeCredential(clientId, clientSecret))
        { }

        /// <summary>
        /// Encode Credential
        /// </summary>
        /// <param name="clientId">clientId</param>
        /// <param name="clientSecret">clientSecret</param>
        private static string EncodeCredential(string clientId, string clientSecret)
        {
            if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentNullException(nameof(clientSecret));

            Encoding encoding = Encoding.ASCII;
            string credential = String.Format("{0}:{1}", clientId, clientSecret);

            return Convert.ToBase64String(encoding.GetBytes(credential));
        }
    }
}