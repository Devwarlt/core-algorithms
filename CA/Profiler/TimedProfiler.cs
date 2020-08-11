﻿using System;
using System.Diagnostics;

namespace CA.Profiler
{
    /// <summary>
    /// Display total elapsed time of a procedure interval
    /// until <see cref="TimedProfiler"/> is disposed.
    ///
    /// Author: Slendergo
    /// </summary>
    public sealed class TimedProfiler : IDisposable
    {
#pragma warning disable
        private readonly Action<string> _logger;
        private readonly string _message;
        private readonly Stopwatch _stopwatch;

        public TimedProfiler(string message) : this(message, null)
        { }

        public TimedProfiler(string message, Action<string> logger)
        {
            _message = message;
            _logger = logger;
            _stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _stopwatch.Stop();

            var time = _stopwatch.Elapsed;
            var ms = _stopwatch.ElapsedMilliseconds;
            var info = $"{_message} - Elapsed: {time} ({ms}ms)";

            if (_logger != null)
                _logger.Invoke(info);
            else
                Console.WriteLine(info);
        }

#pragma warning restore
    }
}
