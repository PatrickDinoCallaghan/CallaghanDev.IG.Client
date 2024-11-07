﻿using System;

namespace Lightstreamer.DotNet.Client.Log
{
  public interface ILogger
  {
    void Error(string line);

    void Error(string line, Exception exception);

    void Warn(string line);

    void Warn(string line, Exception exception);

    void Info(string line);

    void Info(string line, Exception exception);

    void Debug(string line);

    void Debug(string line, Exception exception);

    void Fatal(string line);

    void Fatal(string line, Exception exception);

    bool IsDebugEnabled { get; }

    bool IsInfoEnabled { get; }

    bool IsWarnEnabled { get; }

    bool IsErrorEnabled { get; }

    bool IsFatalEnabled { get; }
  }
}
