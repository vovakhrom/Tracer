using System;

namespace Lab_Tracer
    {
        namespace Serilization
        {
            public interface ISerializer
            {
                string Serialize(TraceResult traceResult);
                string GetExtension();
            }
        }
    }