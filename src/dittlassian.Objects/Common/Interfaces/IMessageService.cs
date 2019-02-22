using System;
using System.Collections.Generic;
using System.Text;

namespace dittlassian.Objects.Common.Interfaces
{
    public interface IMessageService
    {
        bool ProcessWebHook(object webHook, Configuration configuration);
    }
}