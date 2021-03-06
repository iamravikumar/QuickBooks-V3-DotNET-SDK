﻿////*********************************************************
// <copyright file="LinearRetryElement.cs" company="Intuit">
/*******************************************************************************
 * Copyright 2016 Intuit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *******************************************************************************/
// <summary>This file contains Linear retry element.</summary>
////*********************************************************

namespace Intuit.Ipp.Utility
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Linear retry element.
    /// </summary>
    public class LinearRetryElement : ConfigurationElement
    {
        /// <summary>
        /// Gets the Retry Count.
        /// </summary>
        [ConfigurationProperty("retryCount", DefaultValue = 0)]
        public int RetryCount
        {
            get
            {
                return (int)this["retryCount"];
            }
        }

        /// <summary>
        /// Gets the Retry interval.
        /// </summary>
        [ConfigurationProperty("retryInterval")]
        public TimeSpan RetryInterval
        {
            get
            {
                return (TimeSpan)this["retryInterval"];
            }
        }
    }
}
