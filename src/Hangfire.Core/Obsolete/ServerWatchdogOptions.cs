// This file is part of Hangfire.
// Copyright � 2013-2014 Sergey Odinokov.
// 
// Hangfire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// Hangfire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with Hangfire. If not, see <http://www.gnu.org/licenses/>.

#if NETFULL

using System;

// ReSharper disable once CheckNamespace
namespace Hangfire.Server
{
    /// <exclude />
    [Obsolete("Please use `BackgroundJobServerOptions` properties instead. Will be removed in 2.0.0.")]
    public class ServerWatchdogOptions
    {
        public ServerWatchdogOptions()
        {
            ServerTimeout = ServerWatchdog.DefaultServerTimeout;
            CheckInterval = ServerWatchdog.DefaultCheckInterval;
        }

        public TimeSpan ServerTimeout { get; set; }
        public TimeSpan CheckInterval { get; set; }
    }
}

#endif